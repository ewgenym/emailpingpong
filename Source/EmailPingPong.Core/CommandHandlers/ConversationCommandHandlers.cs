using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Core.CommandHandlers
{
	public class ConversationCommandHandlers : ICommandHandler<MergeConversation>
	{
		private readonly IConversationRepository _conversationRepository;

		public ConversationCommandHandlers(IConversationRepository conversationRepository)
		{
			_conversationRepository = conversationRepository;
		}

		public void Handle(MergeConversation command)
		{
			var sourceConversation = _conversationRepository.GetByConversationId(command.Conversation.ConversationId);
			if (sourceConversation != null)
			{
				sourceConversation.Merge(command.Conversation);
			}
			else
			{
				_conversationRepository.Add(command.Conversation);
			}
		}
	}
}