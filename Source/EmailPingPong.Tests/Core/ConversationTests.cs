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
	}
}