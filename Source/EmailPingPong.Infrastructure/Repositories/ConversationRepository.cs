using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.Infrastructure.Repositories
{
	public class ConversationRepository : DbRepository<Conversation>, IConversationRepository
	{
		private readonly ConversationContext _conversationContext;

		public ConversationRepository(ConversationContext conversationContext)
			: base(conversationContext)
		{
			_conversationContext = conversationContext;
		}

		public override IEnumerable<Conversation> GetAll()
		{
			return _conversationContext.Conversations
									   .Include("Comments")
									   .Include("Comments.Answers")
									   .Include("Emails");
		}

		public IEnumerable<Conversation> GetByAccountId(string accountId)
		{
			return GetAll();
			//return _conversationContext.Conversations
			//						   .Where(c => c.NewestEmail.AccountId == accountId)
			//						   .Include(c => c.Comments)
			//						   .Include("Comments.Answers")
			//						   .Include(c => c.Emails);
		}

		public IEnumerable<Conversation> GetByAccountIdAndFolders(string accountId, IEnumerable<EmailFolder> folders)
		{
			return GetAll();
		}

		public IEnumerable<Conversation> GetByAccountIdAndEmails(string accountId, IEnumerable<EmailItem> emails)
		{
			return GetAll();
		}

		public override void Remove(Conversation entity)
		{
			var commentsToRemove = CascadeComments(entity.Comments);
			commentsToRemove.ForEach(c => _conversationContext.Comments.Remove(c));

			base.Remove(entity);
		}

		private IEnumerable<Comment> CascadeComments(IEnumerable<Comment> comments)
		{
			var aggregator = new List<Comment>();
			comments.ForEach(comment =>
				{
					aggregator.AddRange(comment.Answers);
					aggregator.AddRange(CascadeComments(comment.Answers));
					comment.Answers.Clear();
				});
			return aggregator;
		}

		public Conversation GetByConversationId(string conversationId)
		{
			return _conversationContext.Conversations.SingleOrDefault(c => c.ConversationId == conversationId);
		}
	}
}