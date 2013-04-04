using EmailPingPong.Core.Model;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Core
{
	public class ConversationTests
	{
		[Fact]
		public void should_close_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
					 .WithConversationId("1")
					 .Build();

			// act
			conversation.Close();

			// assert
			conversation.IsClosed.Should().BeTrue();
		}

		[Fact]
		public void should_reopen_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
					 .WithConversationId("1")
					 .WithIsClosed()
					 .Build();

			// act
			conversation.Reopen();

			// assert
			conversation.IsClosed.Should().BeFalse();
		}

		[Fact]
		public void conversations_with_the_same_conversation_ids_should_be_equal()
		{
			// arrange
			const string conversationId = "1";
			var conversation1 = new Conversation {Id = 1, ConversationId = conversationId};
			var conversation2 = new Conversation {Id = 2, ConversationId = conversationId};

			// act
			var result = conversation1 == conversation2;

			// assert
			result.Should().BeTrue();
		}
	}
}