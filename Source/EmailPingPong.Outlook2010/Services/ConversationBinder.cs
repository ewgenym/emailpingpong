using System;
using System.Collections.Generic;
using EmailPingPong.Outlook.Common.Word;
using Microsoft.Office.Interop.Outlook;
using EmailPingPong.Core.Model;
using Conversation = EmailPingPong.Core.Model.Conversation;

namespace EmailPingPong.Outlook2010.Services
{
	public class ConversationBinder : IConversationBinder
	{
		private readonly IConversationParser _parser;

		public ConversationBinder(IConversationParser parser)
		{
			_parser = parser;
		}

		public Conversation Bind(MailItem mailItem)
		{
			var email = BindEmailItem(mailItem);

			return new Conversation
				{
					ConversationId = BindConversationId(mailItem),
					Emails = new List<EmailItem> { email },
					Comments = BindComments(mailItem),
					Topic = BindTopic(mailItem),
				};
		}

		private string BindConversationId(MailItem mailItem)
		{
			//TODO: implement conversationId inside the email body
			return Guid.NewGuid().ToString();
		}

		private static EmailItem BindEmailItem(MailItem mailItem)
		{
			var folder = (Folder) mailItem.Parent;

			var email = new EmailItem
				{
					ItemId = mailItem.EntryID,
					Subject = mailItem.Subject,
					CreationTime = mailItem.ReceivedTime,
					Folder = new EmailFolder(folder.StoreID, folder.EntryID, folder.Name)
				};
			return email;
		}

		private string BindTopic(MailItem mailItem)
		{
			//TODO: this is e-mail subject but normalized using PR_SUBJECT_PREFIX_W property
			return mailItem.Subject;
		}

		private IList<Comment> BindComments(MailItem item)
		{
			var document = (Microsoft.Office.Interop.Word.Document)item.GetInspector.WordEditor;
			return _parser.Parse(document);
		}
	}
}