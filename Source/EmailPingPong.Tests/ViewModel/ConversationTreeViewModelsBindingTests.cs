using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace EmailPingPong.Tests.ViewModel
{
	public class ConversationTreeViewModelsBindingTests : ConversationTreeViewTestsBase
	{
		public ConversationTreeViewModelsBindingTests()
		{
			var email = Create.EmailItem()
							  .WithSubject("Subject1")
							  .WithFolder("1", "1", "1")
							  .WithCreationTime(new DateTime(2013, 1, 12))
							  .Build();

			var conversation = Create.Conversation()
									 .WithEmail(email)
									 .WithComment(Create.Comment().Build())
									 .Build();
			ConversationRepository.GetByAccountId("").ReturnsForAnyArgs(new List<Conversation> { conversation });
			ConversationRepository.GetByAccountIdAndEmails("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
			ConversationRepository.GetByAccountIdAndFolder("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
		}

		[Fact]
		public async Task should_bind_to_conversation_view_model()
		{
			// act
			ViewModel.GroupBy = GroupBy.Email;
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].Should().BeAssignableTo<ConversationViewModel>();
		}

		[Fact]
		public async Task should_bind_to_folder_view_model()
		{
			// act
			ViewModel.GroupBy = GroupBy.Folder;
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].Should().BeAssignableTo<FolderViewModel>();
		}

		[Fact]
		public async Task should_bind_to_comment_view_model()
		{
			// act
			ViewModel.GroupBy = GroupBy.None;
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].Should().BeAssignableTo<CommentViewModel>();
		}
	}
}