using System;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace EmailPingPong.Tests.UI
{
	public class ConversationTreeItemsBinderTests
	{
		private readonly IConversationRepository _conversationRepository;
		private readonly ConversationTreeItemsBinder _binder;
		private readonly Conversation _closedConversation;

		public ConversationTreeItemsBinderTests()
		{
			_conversationRepository = Substitute.For<IConversationRepository>();
			_binder = new ConversationTreeItemsBinder(_conversationRepository);
			_closedConversation = Create.Conversation()
							.WithConversationId("1")
							.WithIsClosed()
							.WithComment(Create.Comment()
											   .WithId(Guid.NewGuid())
											   .Build())
							.Build();
			_conversationRepository.GetByAccountId(null).ReturnsForAnyArgs(new[] { _closedConversation });
			_conversationRepository.GetByAccountIdAndFolder(null, null).ReturnsForAnyArgs(new[] { _closedConversation });
			_conversationRepository.GetByAccountIdAndEmails(null, null).ReturnsForAnyArgs(new[] { _closedConversation });
		}

		[Fact]
		public async Task should_not_bind_closed_conversations_when_search_in_all_folder()
		{
			// arrange

			// act
			const bool showClosedConversations = false;
			var criteria = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "1", null,
														new EmailFolder("1", "1", "1"), showClosedConversations);
			var items = await _binder.BindTreeViewItems(criteria);

			// assert
			items.Should().BeEmpty();
			_conversationRepository.Received().GetByAccountId("1");
		}

		[Fact]
		public async Task should_bind_closed_conversations_when_show_closed_conversations_is_true()
		{
			// arrange

			// act
			const bool showClosedConversations = true;
			var criteria = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "1", null,
														new EmailFolder("1", "1", "1"), showClosedConversations);
			var items = await _binder.BindTreeViewItems(criteria);

			// assert
			items.Should().NotBeEmpty();
			_conversationRepository.Received().GetByAccountId("1");
		}

		[Fact]
		public async Task should_not_bind_closed_conversations_when_search_in_current_folder()
		{
			// arrange

			// act
			const bool showClosedConversations = false;
			var criteria = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentFolder, "1", null,
														new EmailFolder("1", "1", "1"), showClosedConversations);
			var items = await _binder.BindTreeViewItems(criteria);

			// assert
			items.Should().BeEmpty();
			_conversationRepository.ReceivedWithAnyArgs().GetByAccountIdAndFolder(null, null);
		}

		[Fact]
		public async Task should_bind_closed_conversations_when_search_in_current_folder_and_show_closed_conversations()
		{
			// act
			const bool showClosedConversations = true;
			var criteria = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentFolder, "1", null,
														new EmailFolder("1", "1", "1"), showClosedConversations);
			var items = await _binder.BindTreeViewItems(criteria);

			// assert
			items.Should().NotBeEmpty();
			_conversationRepository.ReceivedWithAnyArgs().GetByAccountIdAndFolder(null, null);
		}

		[Fact]
		public async Task should_not_bind_closed_conversations_when_search_in_current_email()
		{
			// arrange

			// act
			const bool showClosedConversations = false;
			var criteria = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "1", null,
														new EmailFolder("1", "1", "1"), showClosedConversations);
			var items = await _binder.BindTreeViewItems(criteria);

			// assert
			items.Should().BeEmpty();
			_conversationRepository.ReceivedWithAnyArgs().GetByAccountIdAndEmails(null, null);
		}

		[Fact]
		public async Task should_bind_closed_conversations_when_search_in_current_email_and_show_closed_conversations()
		{
			// act
			const bool showClosedConversations = true;
			var criteria = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "1", null,
														new EmailFolder("1", "1", "1"), showClosedConversations);
			var items = await _binder.BindTreeViewItems(criteria);

			// assert
			items.Should().NotBeEmpty();
			_conversationRepository.ReceivedWithAnyArgs().GetByAccountIdAndEmails(null, null);
		}
	}
}