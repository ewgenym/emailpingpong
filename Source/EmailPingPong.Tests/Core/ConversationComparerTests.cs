using EmailPingPong.Core.Comparers;
using EmailPingPong.Core.Model;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Core
{
	public class ConversationComparerTests
	{
		[Fact]
		public void conversations_with_the_same_conversation_ids_should_be_equal()
		{
			// arrange
			const string conversationId = "1";
			var conversation1 = new Conversation {Id = 1, ConversationId = conversationId};
			var conversation2 = new Conversation {Id = 2, ConversationId = conversationId};

			var conversationComparer = new ConversationComparer();
			// act
			var result = conversationComparer.Equals(conversation1, conversation2);

			// assert
			result.Should().BeTrue();
		}
	}
}