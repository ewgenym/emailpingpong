using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Services;

namespace EmailPingPong.Core.CommandHandlers
{
	public class ConversationCommandHandlers : ICommandHandler<MergeConversation>,
		ICommandHandler<UpdateMailItem>
	{
		private readonly IMergeConversationService _mergeConversationService;
		private readonly IConversationRepository _conversationRepository;

		public ConversationCommandHandlers(IMergeConversationService mergeConversationService,
			IConversationRepository conversationRepository)
		{
			_mergeConversationService = mergeConversationService;
			_conversationRepository = conversationRepository;
		}

		public void Handle(MergeConversation command)
		{
			var originalConversation = _conversationRepository.GetByConversationId(command.Conversation.ConversationId);
			if (originalConversation != null)
			{
				_mergeConversationService.Merge(originalConversation, command.Conversation);
			}
			else
			{
				_conversationRepository.Add(command.Conversation);
			}
		}

		public void Handle(UpdateMailItem command)
		{
			var conversation = _conversationRepository.GetByConversationId(command.Conversation.ConversationId);
			if (conversation != null)
			{
				conversation.UpdateEmail(command.Conversation.NewestEmail);
			}
		}
	}
}