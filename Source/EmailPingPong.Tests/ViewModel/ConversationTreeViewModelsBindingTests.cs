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
			var conversation = Create.Conversation()
									 .WithComment(Create.Comment().Build())
									 .Build();
			_conversationRepository.GetByAccountId("").ReturnsForAnyArgs(new List<Conversation> { conversation });
			_conversationRepository.GetByAccountIdAndEmails("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
			_conversationRepository.GetByAccountIdAndFolders("", null).ReturnsForAnyArgs(new List<Conversation> { conversation });
		}

		[Fact]
		public async Task should_bind_to_conversation_view_model()
		{
			// act
			_viewModel.GroupBy = GroupBy.Email;
			await _viewModel.BindData();

			// assert
			_viewModel.Items[0].Should().BeAssignableTo<ConversationViewModel>();
		}

		[Fact]
		public async Task should_bind_to_folder_view_model()
		{
			// act
			_viewModel.GroupBy = GroupBy.Folder;
			await _viewModel.BindData();

			// assert
			_viewModel.Items[0].Should().BeAssignableTo<FolderViewModel>();
		}

		[Fact]
		public async Task should_bind_to_comment_view_model()
		{
			// act
			_viewModel.GroupBy = GroupBy.None;
			await _viewModel.BindData();

			// assert
			_viewModel.Items[0].Should().BeAssignableTo<CommentViewModel>();
		}
	}
}