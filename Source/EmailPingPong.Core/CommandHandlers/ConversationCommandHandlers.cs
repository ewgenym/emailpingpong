using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Services;

namespace EmailPingPong.Core.CommandHandlers
{
	public class ConversationCommandHandlers : ICommandHandler<MergeConversation>,
		ICommandHandler<UpdateMailItem>,
		ICommandHandler<RemoveConversation>,
		ICommandHandler<CloseConversation>,
		ICommandHandler<ReopenConversation>
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
			var proposed = command.Conversation;
			var original = _conversationRepository.GetByAccountIdAndConversationId(proposed.AccountId, proposed.ConversationId);
			if (original != null)
			{
				_conversationRepository.Remove(original);
			}
		}

		private void InternalMerge(Conversation proposed, bool addNew)
		{
			var original = _conversationRepository.GetByAccountIdAndConversationId(proposed.AccountId, proposed.ConversationId);
			if (original != null)
			{
				_mergeConversationService.Merge(original, proposed);
			}
			else if (addNew)
			{
				_conversationRepository.Add(proposed);
			}
		}

		public void Handle(CloseConversation command)
		{
			var conversation = _conversationRepository.GetByAccountIdAndConversationId(command.Conversation.AccountId,
			                                                                           command.Conversation.ConversationId);
			if (conversation != null)
			{
				conversation.Close();
			}
		}

		public void Handle(ReopenConversation command)
		{
			var conversation = _conversationRepository.GetByAccountIdAndConversationId(command.Conversation.AccountId,
																					   command.Conversation.ConversationId);
			if (conversation != null)
			{
				conversation.Reopen();
			}
		}
	}
}