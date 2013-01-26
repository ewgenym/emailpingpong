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
	public class ConversationEmailsTests
	{
		private readonly IRepository<Comment> _commentsRepository;
		private readonly IRepository<EmailItem> _emailsRepository;
		private readonly IMergeConversationService _mergeConversationService;

		public ConversationEmailsTests()
		{
			_commentsRepository = Substitute.For<IRepository<Comment>>();
			_emailsRepository = Substitute.For<IRepository<EmailItem>>();
			_mergeConversationService = new MergeConversationService(_emailsRepository, _commentsRepository);
		}
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
														.WithId(Guid.NewGuid())
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
				.WithId(Guid.NewGuid())
				.Build();

			var answer = Create.Comment()
			                   .WithId(Guid.NewGuid())
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

		[Fact]
		public void should_assign_original_email_for_conversation_answers_on_merge()
		{
			// arrange
			var guid1 = Guid.NewGuid();
			var guid2 = Guid.NewGuid();
			var originalConversation = Create.Conversation()
			                                 .WithConversationId("1")
			                                 .WithEmail(Create.EmailItem()
			                                                  .WithItemId("1")
			                                                  .WithCreationTime(new DateTime(2013, 1, 12))
			                                                  .Build())
			                                 .WithComment(Create.Comment()
																.WithId(guid1).Build())
			                                 .Build();

			var comment = Create.Comment()
								.WithId(guid1)
			                    .WithAnswer(Create.Comment()
												  .WithId(guid2)
			                                      .Build())
			                    .Build();
			var targetConversation = Create.Conversation()
			                               .WithConversationId("1")
			                               .WithEmail(Create.EmailItem()
			                                                .WithItemId("1")
			                                                .WithCreationTime(new DateTime(2013, 1, 12))
			                                                .Build())
			                               .WithEmail(Create.EmailItem()
			                                                .WithItemId("2")
			                                                .WithCreationTime(new DateTime(2013, 2, 12))
			                                                .Build())
			                               .WithComment(comment)
			                               .Build();

			// act
			MergeConversation(originalConversation, targetConversation);

			// assert
			comment.OriginalEmail.Should().BeSameAs(originalConversation.Emails[0]);
			comment.Answers[0].OriginalEmail.Should().BeSameAs(originalConversation.Emails[1]);
		}

		[Fact]
		public void should_not_add_modified_email_when_merge()
		{
			// arrange
			var guid1 = Guid.NewGuid();
			var original = Create.Conversation()
								 .WithConversationId("1")
								 .WithEmail(Create.EmailItem()
												  .WithAccountId("1")
												  .WithItemId("1")
												  .WithFolder("1", "1", "1")
												  .WithCreationTime(new DateTime(2013, 1, 12))
												  .Build())
								 .WithComment(Create.Comment()
													.WithBody("Body1")
													.WithId(guid1)
													.Build())
								 .Build();

			var proposed = Create.Conversation()
								 .WithConversationId("1")
								 .WithEmail(Create.EmailItem()
												  .WithAccountId("1")
												  .WithItemId("1")
												  .WithFolder("1", "1", "1")
												  .WithCreationTime(new DateTime(2013, 1, 13))
												  .Build())
								 .WithComment(Create.Comment()
													.WithId(guid1)
													.WithBody("Body2")
													.Build())
								 .Build();

			// act
			MergeConversation(original, proposed);

			// assert
			original.Emails.Should().HaveCount(1);
		}

		[Fact]
		public void should_modify_emails_with_the_same_creation_time_when_merge()
		{
			// arrange
			var original = Create.Conversation()
								 .WithConversationId("1")
								 .WithEmail(Create.EmailItem()
												  .WithAccountId("1")
												  .WithItemId("1")
												  .WithFolder("1", "1", "1")
												  .WithCreationTime(new DateTime(2013, 1, 12))
												  .WithIsUnread(true)
												  .Build())
								 .Build();

			var proposed = Create.Conversation()
								 .WithConversationId("1")
								 .WithEmail(Create.EmailItem()
												  .WithAccountId("1")
												  .WithItemId("1")
												  .WithFolder("1", "1", "1")
												  .WithCreationTime(new DateTime(2013, 1, 12))
												  .WithIsUnread(false)
												  .Build())
								 .Build();

			// act
			MergeConversation(original, proposed);

			// assert
			original.NewestEmail.IsUnread.Should().BeFalse();
		}

		[Fact]
		public void should_save_origin_email_and_add_newest_email()
		{
			// arrange
			var guid1 = Guid.NewGuid();
			var guid2 = Guid.NewGuid();

			var original = Create.Conversation()
			                     .WithConversationId("1")
			                     .WithEmail(Create.EmailItem()
			                                      .WithAccountId("1")
			                                      .WithItemId("1")
			                                      .WithFolder("1", "1", "1")
			                                      .WithCreationTime(new DateTime(2013, 1, 12))
			                                      .WithIsUnread(true)
			                                      .Build())
								 .WithComment(Create.Comment().WithId(guid1).Build())
			                     .Build();

			var proposed = Create.Conversation()
			                     .WithConversationId("1")
			                     .WithEmail(Create.EmailItem()
			                                      .WithAccountId("1")
			                                      .WithItemId("2")
			                                      .WithFolder("1", "1", "1")
			                                      .WithCreationTime(new DateTime(2013, 1, 13))
			                                      .WithIsUnread(false)
			                                      .Build())
								 .WithComment(Create.Comment().WithId(guid1).Build())
								 .WithComment(Create.Comment().WithId(guid2).Build())
			                     .Build();

			// act
			MergeConversation(original, proposed);

			// assert
			original.Comments.Should().HaveCount(2);
			original.Comments[0].OriginalEmail.ItemId.Should().Be("1");
			original.Comments[1].OriginalEmail.ItemId.Should().Be("2");
		}

		private void MergeConversation(Conversation target, Conversation source)
		{
			_mergeConversationService.Merge(target, source);
		}
	}
}