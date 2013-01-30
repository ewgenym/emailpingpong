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
using Xunit;
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
			ConversationRepository.GetByAccountId("").ReturnsForAnyArgs(new List<Conversation> { conversation });
			ConversationRepository.GetByAccountIdAndEmails("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
			ConversationRepository.GetByAccountIdAndFolder("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
		}

		[Fact]
		public async Task should_save_items_state_when_group_by_changes()
		{
			var groupBy1 = GroupBy.None;
			var groupBy2 = GroupBy.Email;
			
			// arrage
			ViewModel.GroupBy = groupBy1;
			await ViewModel.BindData();
		
			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			ViewModel.GroupBy = groupBy2;
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			ViewModel.GroupBy = groupBy1;
			await ViewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_search_in_changes(SearchIn searchIn1, SearchIn searchIn2)
		{
			// arrage
			ViewModel.SearchIn = searchIn1;
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			ViewModel.SearchIn = searchIn2;
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			ViewModel.SearchIn = searchIn1;
			await ViewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_account_id_changes(string accountId1, string accountId2)
		{
			// arrange
			EmailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId1, null));
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			EmailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId2, null));
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			EmailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId1, null));
			await ViewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_current_folder_changes(string accountId, EmailFolder folder1, EmailFolder folder2)
		{
			// arrage
			MailFolderSwitchedEvent.Publish(new MailFolderSwitchedArgs(accountId, folder1));
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			MailFolderSwitchedEvent.Publish(new MailFolderSwitchedArgs(accountId, folder2));
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			MailFolderSwitchedEvent.Publish(new MailFolderSwitchedArgs(accountId, folder1));
			await ViewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();

		}

		[Theory, AutoData]
		public async Task should_save_items_state_when_current_email_changes(string accountId, EmailItem[] emails1, EmailItem[] emails2)
		{
			// arrage
			EmailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId, emails1));
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			EmailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId, emails2));
			await ViewModel.BindData();

			ViewModel.Items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();

			EmailItemSwitchedEvent.Publish(new EmailItemSwitchedArgs(accountId, emails1));
			await ViewModel.BindData();

			// assert
			AssertConversationTreeIsExpanded();
		}

		private void AssertConversationTreeIsExpanded()
		{
			foreach (var item in new TreeViewItemsIterator(ViewModel.Items))
			{
				item.IsExpanded.Should().BeTrue();
			}
		}
	}
}