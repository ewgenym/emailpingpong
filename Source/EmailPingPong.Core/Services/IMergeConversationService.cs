using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Services
{
	public interface IMergeConversationService
	{
		void Merge(Conversation original, Conversation proposed);
	}
}