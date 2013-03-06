using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using NSubstitute;
using Xunit;

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
	}
}