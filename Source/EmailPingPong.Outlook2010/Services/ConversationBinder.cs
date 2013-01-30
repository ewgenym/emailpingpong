using EmailPingPong.Outlook.Common.Word;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using Conversation = EmailPingPong.Core.Model.Conversation;

namespace EmailPingPong.Outlook2010.Services
{
	public class ConversationBinder : IConversationBinder
	{
		private readonly IConversationParser _parser;
		private readonly IEmailItemBinder _emailItemBinder;
		private readonly IConversationMetadataTracker _metadataTracker;

		public ConversationBinder(IConversationParser parser,
			IEmailItemBinder emailItemBinder, 
			IConversationMetadataTracker metadataTracker)
		{
			_parser = parser;
			_emailItemBinder = emailItemBinder;
			_metadataTracker = metadataTracker;
		}

		public Conversation Bind(MailItem mailItem)
		{
			if (!IsTrackConversation(mailItem))
			{
				return null;
			}

			var email = _emailItemBinder.Bind(mailItem);

			var conversation = new Conversation
				{
					ConversationId = BindConversationId(mailItem),
					Topic = BindTopic(mailItem),
				};
			conversation.AddEmail(email);
			BindComments(mailItem, conversation);

			return conversation;
		}

		private bool IsTrackConversation(MailItem mailItem)
		{
			var document = (Document)mailItem.GetInspector.WordEditor;
			return document.ContentControls.Count > 0;
		}

		private string BindConversationId(MailItem mailItem)
		{
			return _metadataTracker.Read(mailItem).ConversationId;
		}

		private string BindTopic(MailItem mailItem)
		{
			//PR_NORMALIZED_SUBJECT_W
			return mailItem.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x0E1D001F");
		}

		private void BindComments(MailItem item, Conversation conversation)
		{
			var document = (Document)item.GetInspector.WordEditor;
			_parser.Parse(document, conversation);
		}
	}
}