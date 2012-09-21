using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Core.Services.Implementation
{
	public class ConversationService : IConversationService
	{
		private readonly IConversationRepository _conversationRepository;

		public ConversationService(IConversationRepository conversationRepository)
		{
			_conversationRepository = conversationRepository;
		}

		public void MergeConversation(Conversation source)
		{
			var target = _conversationRepository.GetByConversationId(source.ConversationId);
			if (target == null)
			{
				_conversationRepository.Add(source);
				return;
			}

			target.Merge(source);
		}
	}
}