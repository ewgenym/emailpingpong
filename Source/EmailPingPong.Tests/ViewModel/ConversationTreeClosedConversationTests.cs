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
	public class ConversationTreeClosedConversationTests : ConversationTreeViewTestsBase
	{
		public ConversationTreeClosedConversationTests()
		{
			var conversation = Create.Conversation()
			                         .WithIsClosed()
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
		public async Task should_bind_conversation_is_closed_to_conversation_view_model()
		{
			// arrage
			ViewModel.GroupBy = GroupBy.Email;
			ViewModel.ShowClosedConversations = true;

			// act
			await ViewModel.BindData();

			var conversationViewModel = (ConversationViewModel)ViewModel.Items[0];
			conversationViewModel.IsClosed.Should().BeTrue();
		}

		[Fact]
		public async Task should_bind_conversation_is_closed_to_comments_view_model()
		{
			// arrage
			ViewModel.GroupBy = GroupBy.None;
			ViewModel.ShowClosedConversations = true;

			// act
			await ViewModel.BindData();

			var conversationViewModel = (CommentViewModel)ViewModel.Items[0];
			conversationViewModel.IsClosed.Should().BeTrue();
		}

		[Fact]
		public async Task should_bind_conversation_is_closed_to_answers_view_model()
		{
			// arrage
			ViewModel.GroupBy = GroupBy.None;
			ViewModel.ShowClosedConversations = true;

			// act
			await ViewModel.BindData();

			var conversationViewModel = (CommentViewModel)ViewModel.Items[0].Childs.ElementAt(0);
			conversationViewModel.IsClosed.Should().BeTrue();
		}
	}
}