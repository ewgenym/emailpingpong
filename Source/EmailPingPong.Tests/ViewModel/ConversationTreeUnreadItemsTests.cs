using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace EmailPingPong.Tests.ViewModel
{
	public class ConversationTreeUnreadItemsTests : ConversationTreeViewTestsBase
	{
		private readonly EmailItem _email;
		private readonly Conversation _conversation;

		public ConversationTreeUnreadItemsTests()
		{
			// arrange
			_email = Create.EmailItem()
							  .WithSubject("Subject1")
							  .WithCreationTime(new DateTime(2013, 1, 12))
							  .Build();
			_conversation = Create.Conversation()
									 .WithEmail(_email)
									 .WithComment(Create.Comment()
														.Build())
									 .Build();
			ConversationRepository.GetByAccountId("").ReturnsForAnyArgs(new List<Conversation> { _conversation });
		}

		[Fact]
		public async Task should_bind_unread_conversation_items_to_conversation_view_model()
		{
			ViewModel.GroupBy = GroupBy.Email;
			await ViewModel.BindData();

			ViewModel.Items[0].IsUnread.Should().BeFalse();

			// act
			_email.IsUnread = true;
			EmailItemChangedEvent.Publish(new EmailItemChangedArgs(_email));
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].IsUnread.Should().BeTrue();
		}

		[Fact]
		public async Task should_bind_any_child_unread_conversation_items_to_conversation_view_model()
		{
			var secondEmail = Create.EmailItem()
			                        .WithIsUnread(true)
									.WithCreationTime(new DateTime(2013, 1, 11))
									.Build();
			_conversation.AddEmail(secondEmail);

			var answer = Create.Comment()
			                   .WithId(Guid.NewGuid())
			                   .WithOriginalEmail(secondEmail)
			                   .Build();
			_conversation.Comments[0].AddAnswer(answer);

			ViewModel.GroupBy = GroupBy.Email;
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].IsUnread.Should().BeTrue();
		}

		[Fact]
		public async Task should_bind_unread_conversation_items_to_folder_view_model()
		{
			// arrange
			ViewModel.GroupBy = GroupBy.Folder;
			await ViewModel.BindData();

			ViewModel.Items[0].IsUnread.Should().BeFalse();

			// act
			_email.IsUnread = true;
			EmailItemChangedEvent.Publish(new EmailItemChangedArgs(_email));
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].IsUnread.Should().BeTrue();
		}

		[Fact]
		public async Task should_bind_any_child_unread_conversation_items_to_folder_view_model()
		{
			var secondEmail = Create.EmailItem()
									.WithIsUnread(true)
									.WithCreationTime(new DateTime(2013, 1, 11))
									.Build();
			_conversation.AddEmail(secondEmail);

			var answer = Create.Comment()
							   .WithId(Guid.NewGuid())
							   .WithOriginalEmail(secondEmail)
							   .Build();
			_conversation.Comments[0].AddAnswer(answer);

			ViewModel.GroupBy = GroupBy.Folder;
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].IsUnread.Should().BeTrue();
		}

		[Fact]
		public async Task should_bind_unread_conversation_items_to_comment_view_model()
		{
			// arrange
			ViewModel.GroupBy = GroupBy.None;
			await ViewModel.BindData();

			ViewModel.Items[0].IsUnread.Should().BeFalse();

			// act
			_email.IsUnread = true;
			EmailItemChangedEvent.Publish(new EmailItemChangedArgs(_email));
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].IsUnread.Should().BeTrue();
		}
	}
}