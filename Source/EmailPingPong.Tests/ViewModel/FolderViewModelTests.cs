using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using Microsoft.Office.Interop.Outlook;
using NSubstitute;
using Xunit;
using Conversation = EmailPingPong.Core.Model.Conversation;

namespace EmailPingPong.Tests.ViewModel
{
	public class FolderViewModelTests : ConversationTreeViewTestsBase
	{
		public FolderViewModelTests()
		{
			// arrange
			var email1 = Create.EmailItem()
							  .WithSubject("Subject1")
							  .WithFolder("1", "1", "1")
							  .WithCreationTime(new DateTime(2013, 1, 12))
							  .Build();

			var conversation1 = Create.Conversation()
									 .WithEmail(email1)
									 .WithComment(Create.Comment()
														.Build())
									 .Build();

			var email2 = Create.EmailItem()
			                   .WithSubject("Subject2")
			                   .WithFolder("1", "1", "1")
			                   .WithCreationTime(new DateTime(2013, 3, 6))
			                   .Build();
			var conversation2 = Create.Conversation()
			                          .WithEmail(email2)
			                          .WithComment(Create.Comment().Build())
			                          .Build();

			ConversationRepository.GetByAccountId("").ReturnsForAnyArgs(new List<Conversation> { conversation1, conversation2 });
		}
		[Fact]
		public async Task should_bind_folder_view_model()
		{
			// act
			ViewModel.GroupBy = GroupBy.Folder;
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].Should().BeAssignableTo<FolderViewModel>();
		}

		[Fact]
		public async Task should_group_conversations_by_folder()
		{
			ViewModel.GroupBy = GroupBy.Folder;
			await ViewModel.BindData();

			// assert
			ViewModel.Items.Should().HaveCount(1);
			var folderViewModel = (FolderViewModel)ViewModel.Items[0];

			folderViewModel.Childs.Should().HaveCount(2);
			folderViewModel.Childs.ElementAt(0).Should().BeAssignableTo<ConversationViewModel>();
			folderViewModel.Childs.ElementAt(1).Should().BeAssignableTo<ConversationViewModel>();
		}

		[Fact]
		public void folder_view_models_should_be_equal_when_underlying_folders_equal()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var viewModel1 = new FolderViewModel(null, folder1, Enumerable.Empty<Conversation>());

			var folder2 = new EmailFolder("1", "1", "1");
			var viewModel2 = new FolderViewModel(null, folder2, Enumerable.Empty<Conversation>());

			// act
			var result = viewModel1 == viewModel2;

			// assert
			result.Should().BeTrue();
		}
	}
}