using EmailPingPong.Core.Model;
using EmailPingPong.UI.Desktop.ViewModels;
using Xunit;
using FluentAssertions;

namespace EmailPingPong.Tests.ViewModel
{
	public class ConversationViewTests
	{
		[Fact]
		public void conversation_view_models_should_equal_with_the_same_underlying_conversations()
		{
			// arrange
			const string conversationId = "1";
			var conversation1 = new Conversation
				{
					Id = 1,
					ConversationId = conversationId
				};

			var viewModel1 = new ConversationViewModel(null, conversation1);

			var conversation2 = new Conversation
				{
					Id = 2,
					ConversationId = conversationId
				};
			var viewModel2 = new ConversationViewModel(null, conversation2);

			// act
			var result = viewModel1 == viewModel2;

			// assert
			result.Should().BeTrue();
		}
	}
}