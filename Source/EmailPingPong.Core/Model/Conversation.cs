using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.Core.Model
{
	public class Conversation : ModelEntityWithLongId
	{
		public Conversation()
		{
			Comments = new List<Comment>();
			Emails = new List<EmailItem>();
		}

		[Required]
		public string ConversationId { get; set; }

		public string Topic { get; set; }

		public IList<Comment> Comments { get; set; }

		private void ClearComments()
		{
			Comments.Clear();
		}

		public void AddComment(Comment comment)
		{
			Comments.Add(comment);
			var comments = new FlatCommentsIterator(comment).ToList();
			foreach (var subComment in comments)
			{
				if (subComment.OriginalEmail == null)
				{
					subComment.OriginalEmail = NewestEmail;
				}
			}
		}

		public void RemoveComment(Comment comment)
		{
			Comments.Remove(comment);
		}

		public void AddCommentsRange(IEnumerable<Comment> comments)
		{
			comments.ForEach(AddComment);
		}

		public IList<EmailItem> Emails { get; set; }

		public void AddEmail(EmailItem emailItem)
		{
			Emails.Add(emailItem);
		}

		public EmailItem NewestEmail
		{
			get { return Emails.OrderByDescending(e => e.CreationTime).FirstOrDefault(); }
		}

		public bool IsNewerThan(Conversation conversation)
		{
			if (NewestEmail == null)
			{
				return false;
			}

			return NewestEmail.CreationTime.LaterThen(conversation.NewestEmail.CreationTime);
		}

		public void UpdateEmail(EmailItem targetEmail)
		{
			var conversationEmail = Emails.SingleOrDefault(e => e.AccountId == targetEmail.AccountId
																&& e.Folder.StoreId == targetEmail.Folder.StoreId
																&& e.ItemId == targetEmail.ItemId);
			if (conversationEmail != null)
			{
				conversationEmail.IsUnread = targetEmail.IsUnread;
			}
		}
	}
}