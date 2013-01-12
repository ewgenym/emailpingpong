using System;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Core
{
	public class ConversationEmailsTests
	{
		[Fact]
		public void should_assign_original_email_for_conversation_comments()
		{
			// arrange 
			var originalEmail = Create.EmailItem()
			                          .WithCreationTime(new DateTime(2013, 1, 12))
			                          .Build();
			// act
			var conversation = Create.Conversation()
									 .WithEmail(originalEmail)
									 .WithComment(Create.Comment()
														.WithId(1)
														.Build())
									 .Build();

			// assert
			conversation.Comments.Should().HaveCount(1);
			conversation.Comments[0].OriginalEmail.Should().BeSameAs(originalEmail);
		}

		[Fact]
		public void should_assign_original_email_for_conversation_answer()
		{
			// arrange 
			var originalEmail = Create.EmailItem()
									  .WithCreationTime(new DateTime(2013, 1, 12))
									  .Build();

			var comment = Create.Comment()
				.WithId(1)
				.Build();

			var answer = Create.Comment()
			                   .WithId(2)
			                   .Build();

			var conversation = Create.Conversation()
			                         .WithEmail(originalEmail)
			                         .WithComment(comment)
			                         .Build();

			// act
			comment.AddAnswer(answer);

			// assert
			conversation.Comments.Should().HaveCount(1);
			conversation.Comments[0].Answers.Should().HaveCount(1);
			conversation.Comments[0].Answers[0].OriginalEmail.Should().BeSameAs(originalEmail);
		}
	}
}