using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Conversation.Core.Domain;

namespace Conversation.Infrastructure.Repositories.Implementation
{
	public class CommentRepository : ICommentRepository
	{
		private readonly ConversationContext _conversationContext;

		public CommentRepository(ConversationContext conversationContext)
		{
			_conversationContext = conversationContext;
		}

		public IEnumerable<Comment> Comments
		{
			get { return _conversationContext.Comments; }
		}

		public IEnumerable<Question> Questions
		{
			get { return _conversationContext.Comments.OfType<Question>().Include(q => q.Comments); }
		}

		public void AddOrUpdate(IEnumerable<Question> questions)
		{
			foreach (var question in questions)
			{
				AddOrUpdate(question);
			}
		}

		private void AddOrUpdate(Question question)
		{
			Delete(question);

			_conversationContext.Comments.Add(question);
		}

		public void Delete(IEnumerable<Question> questions)
		{
			foreach (var question in questions)
			{
				Delete(question);
			}
		}

		private void Delete(Question question)
		{
			var existingQuestion = _conversationContext.Comments
				.OfType<Question>()
				.SingleOrDefault(c => c.Id == question.Id);

			if (existingQuestion != null)
			{
				var childComments = existingQuestion.Comments.ToList();
				foreach (var comment in childComments)
				{
					_conversationContext.Comments.Remove(comment);
				}

				_conversationContext.Comments.Remove(existingQuestion);
			}
		}

		public void SaveChanges()
		{
			_conversationContext.SaveChanges();
		}
	}
}
