using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Tests.Stubs
{
	public class MemoryConversationRepository : MemoryRepository<Conversation>, IConversationRepository
	{
		public Conversation GetByConversationId(string conversationId)
		{
			return _repository.SingleOrDefault(c => c.ConversationId == conversationId);
		}

		public void Save(Conversation conversation)
		{
			throw new System.NotImplementedException();
		}
	}
}