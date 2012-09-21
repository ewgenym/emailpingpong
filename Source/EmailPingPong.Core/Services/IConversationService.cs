using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Services
{
	public interface IConversationService
	{
		void MergeConversation(Conversation source);
	}
}