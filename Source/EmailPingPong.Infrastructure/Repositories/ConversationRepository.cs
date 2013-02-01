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
									   .Include("Comments.OriginalEmail")
									   .Include("Emails");
		}

		public IEnumerable<Conversation> GetByAccountId(string accountId)
		{
			return _conversationContext.Conversations
									   .Include("Comments")
									   .Include("Comments.Answers")
									   .Include("Comments.OriginalEmail")
									   .Include("Emails")
									   .Where(c => c.AccountId == accountId);
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
					aggregator.Add(comment);
					aggregator.AddRange(comment.Answers);
					aggregator.AddRange(CascadeComments(comment.Answers));
					comment.Answers.Clear();
				});
			return aggregator;
		}

		public Conversation GetByAccountIdAndConversationId(string accountId, string conversationId)
		{
			return _conversationContext.Conversations.Include("Comments")
									   .Include("Comments.Answers")
									   .Include("Comments.OriginalEmail")
									   .Include("Emails")
									   .SingleOrDefault(c => c.AccountId == accountId
															 && c.ConversationId == conversationId);
		}

		public IEnumerable<Conversation> GetByAccountIdAndFolder(string accountId, EmailFolder folder)
		{
			return _conversationContext.Conversations
									   .Include("Comments")
									   .Include("Comments.Answers")
									   .Include("Comments.OriginalEmail")
									   .Include("Emails")
									   .Where(c => c.AccountId == accountId
												   && c.Emails.Any(e => e.Folder.StoreId == folder.StoreId)
												   && c.Emails.Any(e => e.Folder.FolderId == folder.FolderId));
		}

		public IEnumerable<Conversation> GetByAccountIdAndEmails(string accountId, IEnumerable<EmailItem> emails)
		{
			var selectedEmail = emails.ElementAt(0);
			return _conversationContext.Conversations
									   .Include("Comments")
									   .Include("Comments.Answers")
									   .Include("Comments.OriginalEmail")
									   .Include("Emails")
									   .Where(c => c.AccountId == accountId
												   && c.Emails.Any(e => e.ItemId == selectedEmail.ItemId));
		}
	}
}