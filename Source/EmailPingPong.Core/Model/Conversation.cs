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
		public virtual string ConversationId { get; set; }

		[Required]
		public virtual string AccountId { get; set; }

		public virtual string Topic { get; set; }

		public virtual IList<Comment> Comments { get; set; }

		public virtual void AddComment(Comment comment)
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

		public virtual IList<EmailItem> Emails { get; set; }

		public virtual void AddEmail(EmailItem emailItem)
		{
			Emails.Add(emailItem);
		}

		public virtual EmailItem NewestEmail
		{
			get { return Emails.OrderByDescending(e => e.CreationTime).FirstOrDefault(); }
		}

		public virtual bool IsNewerThanOrSame(Conversation conversation)
		{
			if (NewestEmail == null)
			{
				return false;
			}

			return NewestEmail.CreationTime.LaterThenOrEqual(conversation.NewestEmail.CreationTime);
		}

		public virtual bool UpdateEmail(EmailItem targetEmail)
		{
			var conversationEmail = Emails.SingleOrDefault(e => e.SameAs(targetEmail));
			if (conversationEmail != null)
			{
				conversationEmail.IsUnread = targetEmail.IsUnread;
			}

			return conversationEmail != null;
		}
	}
}