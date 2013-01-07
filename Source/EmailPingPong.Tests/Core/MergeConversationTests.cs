﻿using System;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Core
{
	public class MergeConversationTests
	{
		[Fact]
		public void should_merge_comments_from_the_same_conversations()
		{
			// arrange
			// first email
			var email1 = Create.EmailItem()
			                   .WithCreationTime(new DateTime(2012, 12, 11))
			                   .Build();

			var comment1 = Create.Comment()
			                     .WithId(1)
			                     .Build();

			var target = Create.Conversation()
			                   .WithConversationId("1")
			                   .WithComment(comment1)
			                   .WithEmail(email1)
			                   .Build();
			//second email
			var email2 = Create.EmailItem()
			                   .WithCreationTime(new DateTime(2012, 12, 12))
			                   .Build();

			var comment2 = Create.Comment()
			                     .WithId(2)
			                     .Build();

			var source = Create.Conversation()
			                   .WithConversationId("1")
			                   .WithComment(comment1)
			                   .WithComment(comment2)
			                   .WithEmail(email2)
			                   .Build();

			// act
			target.Merge(source);

			// assert
			target.Comments.Should().HaveCount(2);
			target.Comments.Should().Contain(comment1);
			target.Comments.Should().Contain(comment2);
		}

		[Fact]
		public void should_not_merge_comments_from_different_conversations()
		{
			//setup
			var target = Create.Conversation()
							   .WithConversationId("Conversation 1")
							   .Build();

			var source = Create.Conversation()
							   .WithConversationId("Another Conversation")
							   .Build();

			//act
			Action action = () => target.Merge(source);

			//assert
			action.ShouldThrow<InvalidOperationException>().WithMessage("Can't merge conversations with different id's");
		}

		[Fact]
		public void should_not_merge_comments_from_old_conversations()
		{
			//setup
			//first email
			var email1 = Create.EmailItem()
							   .WithCreationTime(new DateTime(2012, 12, 12))
							   .Build();

			var comment1 = Create.Comment()
								 .WithId(1)
								 .Build();

			var target = Create.Conversation()
							   .WithConversationId("1")
							   .WithComment(comment1)
							   .WithEmail(email1)
							   .Build();
			//second email
			var email2 = Create.EmailItem()
							   .WithCreationTime(new DateTime(2012, 12, 11))
							   .Build();

			var comment2 = Create.Comment()
								 .WithId(2)
								 .Build();

			var source = Create.Conversation()
							   .WithConversationId("1")
							   .WithComment(comment2)
							   .WithEmail(email2)
							   .Build();

			//act
			target.Merge(source);

			//assert
			target.Comments.Should().HaveCount(1);
			target.Comments[0].Id.Should().Be(1);
		}

		[Fact]
		public void should_remove_old_comments_from_conversatgion()
		{
			//setup
			//first email
			var email1 = Create.EmailItem()
							   .WithCreationTime(new DateTime(2012, 12, 11))
							   .Build();

			var comment1 = Create.Comment()
								 .WithId(1)
								 .Build();

			var target = Create.Conversation()
							   .WithConversationId("1")
							   .WithComment(comment1)
							   .WithEmail(email1)
							   .Build();
			//second email
			var email2 = Create.EmailItem()
							   .WithCreationTime(new DateTime(2012, 12, 12))
							   .Build();

			var source = Create.Conversation()
							   .WithConversationId("1")
							   .WithEmail(email2)
							   .Build();

			//act
			target.Merge(source);

			//assert
			target.Comments.Should().BeEmpty();
		}

		[Fact]
		public void should_update_existing_comments_in_conversation()
		{
			//setup
			//first email
			var email1 = Create.EmailItem()
							   .WithCreationTime(new DateTime(2012, 12, 11))
							   .Build();

			var comment1 = Create.Comment()
								 .WithId(1)
								 .WithBody("Body 1")
								 .Build();

			var target = Create.Conversation()
							   .WithConversationId("1")
							   .WithComment(comment1)
							   .WithEmail(email1)
							   .Build();
			//second email
			var email2 = Create.EmailItem()
							   .WithCreationTime(new DateTime(2012, 12, 12))
							   .Build();
			var comment2 = Create.Comment()
					 .WithId(1)
					 .WithBody("Body 2")
					 .Build();

			var source = Create.Conversation()
							   .WithConversationId("1")
							   .WithEmail(email2)
							   .WithComment(comment2)
							   .Build();

			//act
			target.Merge(source);

			//assert
			target.Comments.Should().HaveCount(1);
			target.Comments[0].Id.Should().Be(1);
			target.Comments[0].Body.Should().Be("Body 2");
		}
	}
}