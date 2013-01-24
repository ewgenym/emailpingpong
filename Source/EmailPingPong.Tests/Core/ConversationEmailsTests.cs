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

		[Fact]
		public void should_assign_original_email_for_conversation_answers_on_merge()
		{
			// arrange
			var originalConversation = Create.Conversation()
			                                 .WithConversationId("1")
			                                 .WithEmail(Create.EmailItem()
			                                                  .WithItemId("1")
			                                                  .WithCreationTime(new DateTime(2013, 1, 12))
			                                                  .Build())
			                                 .WithComment(Create.Comment()
			                                                    .WithId(1).Build())
			                                 .Build();

			var comment = Create.Comment()
			                    .WithId(1)
			                    .WithAnswer(Create.Comment()
			                                      .WithId(2)
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

		private void MergeConversation(Conversation target, Conversation source)
		{
			_mergeConversationService.Merge(target, source);
		}
	}
}