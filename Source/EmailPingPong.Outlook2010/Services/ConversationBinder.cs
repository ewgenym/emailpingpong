using EmailPingPong.Outlook.Common.Word;
using EmailPingPong.Outlook2010.Utils;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using Conversation = EmailPingPong.Core.Model.Conversation;

namespace EmailPingPong.Outlook2010.Services
{
	public class ConversationBinder : IConversationBinder
	{
		private const string EmailpingpongConversationIdKey = "EmailPingPong.ConversationId";
		private readonly IConversationParser _parser;
		private readonly IEmailItemBinder _emailItemBinder;

		public ConversationBinder(IConversationParser parser, IEmailItemBinder emailItemBinder)
		{
			_parser = parser;
			_emailItemBinder = emailItemBinder;
		}

		public Conversation Bind(MailItem mailItem)
		{
			if (!TracksConversation(mailItem))
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

		private bool TracksConversation(MailItem mailItem)
		{
			var document = (Document)mailItem.GetInspector.WordEditor;
			var conversationId = ConversationIdHelper.GetConversationId(document);
			return !string.IsNullOrEmpty(conversationId);
		}

		private string BindConversationId(MailItem mailItem)
		{
			var document = (Document)mailItem.GetInspector.WordEditor;
			return ConversationIdHelper.GetConversationId(document);
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