using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using NSubstitute;
using Ploeh.AutoFixture.Xunit;
using Xunit.Extensions;

namespace EmailPingPong.Tests.ViewModel
{
	// TODO: avoid double binding in all theses tests
	public class ConversationTreeViewModelStatePersistanceTests : ConversationTreeViewTestsBase
	{
		public ConversationTreeViewModelStatePersistanceTests() : base()
		{
			var conversation = Create.Conversation()
						 .WithComment(Create.Comment()
											.WithAnswer(Create.Comment()
															  .Build())
											.Build())
						 .Build();
			_conversationRepository.GetByAccountId("").ReturnsForAnyArgs(new List<Conversation> { conversation });
			_conversationRepository.GetByAccountIdAndEmails("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
			_conversationRepository.GetByAccountIdAndFolders("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_group_by_changes(GroupBy groupBy1, GroupBy groupBy2)
		{
			// arrage
			_viewModel.GroupBy = groupBy1;
			await _viewModel.BindData();
		
			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			_viewModel.GroupBy = groupBy2;
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			_viewModel.GroupBy = groupBy1;
			await _viewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_search_in_changes(SearchIn searchIn1, SearchIn searchIn2)
		{
			// arrage
			_viewModel.SearchIn = searchIn1;
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			_viewModel.SearchIn = searchIn2;
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			_viewModel.SearchIn = searchIn1;
			await _viewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_account_id_changes(string accountId1, string accountId2)
		{
			// arrange
			_emailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId1, null));
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			_emailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId2, null));
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			_emailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId1, null));
			await _viewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_current_folder_changes(string accountId, EmailFolder[] folders1, EmailFolder[] folder2)
		{
			// arrage
			_mailFolderSwitchedEvent.Publish(new MailFolderSwitchedArgs(accountId, folders1));
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			_mailFolderSwitchedEvent.Publish(new MailFolderSwitchedArgs(accountId, folder2));
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			_mailFolderSwitchedEvent.Publish(new MailFolderSwitchedArgs(accountId, folders1));
			await _viewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();

		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_current_email_changes(string accountId, EmailItem[] emails1, EmailItem[] emails2)
		{
			// arrage
			_emailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId, emails1));
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			_emailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId, emails2));
			await _viewModel.BindData();

			_viewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			_emailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId, emails1));
			await _viewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		private void AssertConversationTreeIsExpanded()
		{
			foreach (var item in new TreeViewItemsIterator(_viewModel.Items))
			{
				item.IsExpanded.Should().BeTrue();
			}
		}
	}
}