using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Model;
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
			InternalMerge(command.Conversation);
		}

		public void Handle(UpdateMailItem command)
		{
			InternalMerge(command.Conversation);
		}

		private void InternalMerge(Conversation proposed)
		{
			var original = _conversationRepository.GetByConversationId(proposed.ConversationId);
			if (original != null)
			{
				_mergeConversationService.Merge(original, proposed);
			}
			else
			{
				_conversationRepository.Add(proposed);
			}
		}
	}
}