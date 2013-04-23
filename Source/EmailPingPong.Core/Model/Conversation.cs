using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EmailPingPong.Core.Comparers;
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

		[Required]
		public virtual DateTime CreatedOn { get; set; }

		public virtual IList<Comment> Comments { get; set; }

		public virtual void AddComment(Comment comment)
		{
			comment.Conversation = this;
			Comments.Add(comment);
			var comments = new FlatCommentsIterator(comment).ToList();
			foreach (var subComment in comments)
			{
				if (subComment.OriginalEmail == null)
				{
					subComment.OriginalEmail = LatestEmail;
				}
			}
		}

		public virtual IList<EmailItem> Emails { get; set; }

		public virtual void AddEmail(EmailItem emailItem)
		{
			Emails.Add(emailItem);
		}

		public virtual EmailItem LatestEmail
		{
			get { return Emails.OrderByDescending(e => e.CreationTime).FirstOrDefault(); }
		}

		[Required]
		public virtual bool IsClosed { get; set; }

		public virtual bool IsNewerThanOrSame(Conversation conversation)
		{
			if (LatestEmail == null)
			{
				return false;
			}

			return LatestEmail.CreationTime.LaterThenOrEqual(conversation.LatestEmail.CreationTime);
		}

		public virtual bool UpdateEmail(EmailItem targetEmail)
		{
			var conversationEmail = Emails.ToList().SingleOrDefault(e => new EmailItemComparer().Equals(e, targetEmail));
			if (conversationEmail != null)
			{
				conversationEmail.IsUnread = targetEmail.IsUnread;
			}

			return conversationEmail != null;
		}

		public virtual void Reopen()
		{
			IsClosed = false;
		}

		public virtual void Close()
		{
			IsClosed = true;
		}
	}
}