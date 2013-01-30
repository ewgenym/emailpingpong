using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Services;

namespace EmailPingPong.Core.CommandHandlers
{
	public class ConversationCommandHandlers : ICommandHandler<MergeConversation>,
		ICommandHandler<UpdateMailItem>,
		ICommandHandler<RemoveConversation>
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
			InternalMerge(command.Conversation, true);
		}

		public void Handle(UpdateMailItem command)
		{
			InternalMerge(command.Conversation, false);
		}

		public void Handle(RemoveConversation command)
		{
			var original = _conversationRepository.GetByConversationId(command.Conversation.ConversationId);
			if (original != null)
			{
				_conversationRepository.Remove(original);
			}
		}

		private void InternalMerge(Conversation proposed, bool addNew)
		{
			var original = _conversationRepository.GetByConversationId(proposed.ConversationId);
			if (original != null)
			{
				_mergeConversationService.Merge(original, proposed);
			}
			else if (addNew)
			{
				_conversationRepository.Add(proposed);
			}
		}
	}
}