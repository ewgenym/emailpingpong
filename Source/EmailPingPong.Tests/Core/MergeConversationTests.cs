using System;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Services;
using EmailPingPong.Core.Services.Implementation;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace EmailPingPong.Tests.Core
{
	public class MergeConversationTests
	{
		private readonly IRepository<Comment> _commentsRepository;
		private readonly IRepository<EmailItem> _emailsRepository;
		private readonly IMergeConversationService _mergeConversationService;

		public MergeConversationTests()
		{
			_commentsRepository = Substitute.For<IRepository<Comment>>();
			_emailsRepository = Substitute.For<IRepository<EmailItem>>();
			_mergeConversationService = new MergeConversationService(_emailsRepository, _commentsRepository);
		}

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
			MergeConversation(target, source);

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
			Action action = () => MergeConversation(target, source);

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
			MergeConversation(target, source);

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
			MergeConversation(target, source);

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
			MergeConversation(target, source);

			//assert
			target.Comments.Should().HaveCount(1);
			target.Comments[0].Id.Should().Be(1);
			target.Comments[0].Body.Should().Be("Body 2");
		}

		[Fact]
		public void should_save_newest_email_for_conversation()
		{
			// arrange
			var originalEmail = Create.EmailItem()
									  .WithCreationTime(new DateTime(2013, 1, 12))
									  .Build();
			var originalConversation = Create.Conversation()
											 .WithConversationId("1")
											 .WithEmail(originalEmail)
											 .Build();

			var targetEmail = Create.EmailItem()
									.WithCreationTime(new DateTime(2013, 1, 13))
									.Build();

			var targetConversation = Create.Conversation()
				.WithConversationId("1")
				.WithEmail(targetEmail)
				.Build();

			// act
			MergeConversation(originalConversation, targetConversation);

			// assert
			originalConversation.Emails.Should().HaveCount(2);
			originalConversation.NewestEmail.Should().BeSameAs(targetEmail);
		}
		
		[Fact]
		public void should_save_original_emails_for_comments()
		{
			// arrange
			var originalEmail = Create.EmailItem()
			                          .WithCreationTime(new DateTime(2013, 1, 12))
			                          .Build();
			var originalComment = Create.Comment()
			                            .WithId(1)
			                            .Build();

			var originalConversation = Create.Conversation()
			                                 .WithConversationId("1")
			                                 .WithEmail(originalEmail)
			                                 .WithComment(originalComment)
			                                 .Build();

			var targetEmail = Create.EmailItem()
			                        .WithCreationTime(new DateTime(2013, 1, 13))
			                        .Build();

			var targetComment = Create.Comment()
			                          .WithId(1)
			                          .Build();

			var targetAnswer = Create.Comment()
			                         .WithId(2)
			                         .Build();

			var targetConversation = Create.Conversation()
				.WithConversationId("1")
				.WithEmail(targetEmail)
				.WithComment(targetComment)
				.Build();

			targetComment.AddAnswer(targetAnswer);

			// act
			MergeConversation(originalConversation, targetConversation);

			// assert
			originalConversation.Comments.Should().HaveCount(1);
			originalConversation.Comments[0].OriginalEmail.Should().BeSameAs(originalEmail);

			originalConversation.Comments[0].Answers.Should().HaveCount(1);
			originalConversation.Comments[0].Answers[0].OriginalEmail.Should().BeSameAs(targetEmail);
		}

		private void MergeConversation(Conversation target, Conversation source)
		{
			_mergeConversationService.Merge(target, source);
		}
	}
}