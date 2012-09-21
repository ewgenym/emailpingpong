using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Infrastructure.Repositories
{
	public class ConversationRepository : DbRepository<Conversation>, IConversationRepository
	{
		private readonly ConversationContext _conversationContext;

		public ConversationRepository(ConversationContext conversationContext)
		{
			_conversationContext = conversationContext;
		}

		public Conversation GetByConversationId(string conversationId)
		{
			return _conversationContext.Conversations.SingleOrDefault(c => c.ConversationId == conversationId);
		}
	}
}