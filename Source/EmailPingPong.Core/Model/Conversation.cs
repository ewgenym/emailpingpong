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

		[Required]
		public string Topic { get; set; }

		public IList<Comment> Comments { get; set; }

		private void ClearComments()
		{
			Comments.Clear();
		}

		public void AddComment(Comment comment)
		{
			Comments.Add(comment);
			if (comment.OriginalEmail == null)
			{
				comment.OriginalEmail = NewestEmail;
			}
		}

		private void AddCommentsRange(IEnumerable<Comment> comments)
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
			get
			{
				return Emails.OrderByDescending(e => e.CreationTime).FirstOrDefault();
			}
		}

		public void Merge(Conversation sourceConversation)
		{
			if (string.Compare(ConversationId, sourceConversation.ConversationId, StringComparison.InvariantCultureIgnoreCase) != 0)
			{
				throw new InvalidOperationException("Can't merge conversations with different id's");
			}

			if (sourceConversation.IsNewerThan(this))
			{
				UpdateComments(sourceConversation);

				ClearComments();
				AddCommentsRange(sourceConversation.Comments);

				AddEmail(sourceConversation.NewestEmail);
			}
		}

		private void UpdateComments(Conversation sourceConversation)
		{
			var targetComments = new FlatCommentsIterator(Comments).ToList();
			var sourceComments = new FlatCommentsIterator(sourceConversation.Comments).ToList();

			var commentsToUpdate = sourceComments.Join(targetComments, first => first.Id, second => second.Id,
			                                                        (comment1, comment2) =>
			                                                        new {First = comment1, Second = comment2});

			commentsToUpdate.ForEach(t => { t.First.OriginalEmail = t.Second.OriginalEmail; });
		}

		private bool IsNewerThan(Conversation conversation)
		{
			if (NewestEmail == null)
			{
				return false;
			}

			return NewestEmail.CreationTime.LaterThen(conversation.NewestEmail.CreationTime);
		}
	}
}