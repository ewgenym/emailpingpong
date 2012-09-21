using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Repositories
{
	public interface IConversationRepository : IRepository<Conversation>
	{
		Conversation GetByConversationId(string conversationId);
	}
}