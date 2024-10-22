﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using EmailPingPong.Core.CommandHandlers;
using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Services;
using EmailPingPong.Core.Services.Implementation;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Repositories;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

namespace EmailPingPong.Tests.Infrastructure
{
	public class ConversationRepositoryTests
	{
		private readonly IConnectionStringProvider _connectionStringProvider;
		private readonly IConversationRepository _conversationRepository;
		private readonly ConversationContext _context;
		private readonly DateTime _now = new DateTime(2012, 12, 28, 16, 15, 0);
		private readonly IRepository<Comment> _commentsRepository;
		private readonly IRepository<EmailItem> _emailsRepository;
		private readonly IMergeConversationService _mergeConversationService;
		private readonly ConversationCommandHandlers _conversationCommandHandlers;

		public ConversationRepositoryTests()
		{
			_connectionStringProvider = new TestConnectionStringProvider();

			Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
			Database.SetInitializer(new DropCreateDatabaseAlways<ConversationContext>());

			_context = new ConversationContext(_connectionStringProvider);

			_context.Database.Delete();
			_context.Database.Create();

			_conversationRepository = new ConversationRepository(_context);
			_commentsRepository = new DbRepository<Comment>(_context);
			_emailsRepository = new DbRepository<EmailItem>(_context);
			_mergeConversationService = new MergeConversationService(_emailsRepository, _commentsRepository);
			_conversationCommandHandlers = new ConversationCommandHandlers(_mergeConversationService, _conversationRepository);
		}

		[Fact]
		public void should_add_simple_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
			                         .WithConversationId("1")
			                         .WithTopic("Topic1")
									 .WithAccountId("1")
			                         .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_add_conversation_with_email()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithAccountId("Account1")
									 .WithConversationId("2")
									 .WithTopic("Topic2")
									 .WithEmail(
										 Create.EmailItem()
											   .WithAccountId("Account1")
											   .WithItemId("Item1")
											   .WithSubject("Subj1")
											   .WithCreationTime(_now)
											   .WithFolder("1", "1", "Test folder1")
											   .Build())
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_add_conversation_with_comment()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("3")
									 .WithTopic("Topic3")
									 .WithAccountId("1")
									 .WithComment(Create.Comment()
														.WithAuthor("Author1")
														.WithBody("Body1")
														.WithOrder(1)
														.Build())
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_save_comment_id()
		{
			// arrange
			var commentId = Guid.NewGuid();
			var conversation = Create.Conversation()
			                         .WithConversationId("33")
			                         .WithTopic("Topic33")
			                         .WithAccountId("1")
			                         .WithComment(Create.Comment()
			                                            .WithId(commentId)
			                                            .WithAuthor("Author1")
			                                            .WithBody("Body1")
			                                            .WithOrder(1)
			                                            .Build())
			                         .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Comments[0].Guid.Should().Be(commentId);
		}

		[Fact]
		public void should_add_conversation_with_comment_and_answer()
		{
			// arrange
			var guid1 = Guid.NewGuid();
			var guid2 = Guid.NewGuid();

			var conversation = Create.Conversation()
									 .WithAccountId("Account1")
									 .WithConversationId("4")
									 .WithTopic("Topic4")
									 .WithEmail(
										 Create.EmailItem()
											   .WithAccountId("Account1")
											   .WithItemId("Item1")
											   .WithSubject("Subj1")
											   .WithCreationTime(_now)
											   .WithFolder("93227D09-E639-42FA-B79B-33CFD4246F39",
														   "207658ee-3095-43d2-b6ff-a1965808be63", "Test folder1")
											   .Build())
									 .WithComment(
										 Create.Comment()
											   .WithId(guid1)
											   .WithAuthor("Author1")
											   .WithBody("Body1")
											   .WithOrder(1)
											   .WithAnswer(
												   Create.Comment()
														 .WithId(guid2)
														 .WithAuthor("Author2")
														 .WithBody("Body2")
														 .WithOrder(2)
														 .Build()
											 ).Build())
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_add_conversation_with_email_and_comment_and_answer()
		{
			// arrange
			var guid1 = Guid.NewGuid();
			var guid2 = Guid.NewGuid();
			var conversation = Create.Conversation()
			                         .WithConversationId("5")
			                         .WithTopic("Topic5")
									 .WithAccountId("1")
			                         .WithComment(
				                         Create.Comment()
				                               .WithId(guid1)
				                               .WithAuthor("Author1")
				                               .WithBody("Body1")
				                               .WithOrder(1)
				                               .WithAnswer(
					                               Create.Comment()
					                                     .WithId(guid2)
					                                     .WithAuthor("Author2")
					                                     .WithBody("Body2")
					                                     .WithOrder(2)
					                                     .Build()
					                         ).Build())
			                         .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_delete_conversation_with_email()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithAccountId("1")
									 .WithConversationId("5")
									 .WithTopic("Topic5")
									 .WithEmail(Create.EmailItem()
													  .WithAccountId("1")
													  .WithCreationTime(_now)
													  .WithItemId("1")
													  .WithSubject("Subj")
													  .WithFolder("93227D09-E639-42FA-B79B-33CFD4246F39",
																  "207658ee-3095-43d2-b6ff-a1965808be63", "Test folder1").Build())
									 .Build();

			AddConversation(conversation);

			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().NotBeNull();

			// act
			RemoveConversation(conversation);

			// assert
			actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeNull();
		}

		[Fact]
		public void should_delete_conversation_with_comment()
		{
			// arrange
			var conversation = Create.Conversation()
			                         .WithConversationId("5")
			                         .WithTopic("Topic5")
									 .WithAccountId("1")
			                         .WithComment(
				                         Create.Comment()
				                               .WithAuthor("Author1")
				                               .WithBody("Body1")
				                               .WithOrder(1)
				                               .Build())
			                         .Build();

			AddConversation(conversation);

			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().NotBeNull();

			// act
			RemoveConversation(conversation);

			// assert
			actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeNull();
		}

		[Fact]
		public void should_delete_conversation_with_comment_with_answers()
		{
			// arrange
			var guid1 = Guid.NewGuid();
			var guid2 = Guid.NewGuid();
			var conversation = Create.Conversation()
			                         .WithConversationId("5")
			                         .WithTopic("Topic5")
									 .WithAccountId("1")
			                         .WithComment(
				                         Create.Comment()
				                               .WithId(guid1)
				                               .WithAuthor("Author1")
				                               .WithBody("Body1")
				                               .WithOrder(1)
				                               .WithAnswer(
					                               Create.Comment()
					                                     .WithId(guid2)
					                                     .WithAuthor("Author2")
					                                     .WithBody("Body2")
					                                     .WithOrder(2)
					                                     .WithAnswer(Create.Comment()
					                                                       .WithAuthor("Author1")
					                                                       .WithBody("Body3")
					                                                       .WithOrder(3)
					                                                       .Build())
					                                     .Build())
				                               .Build())
			                         .Build();

			AddConversation(conversation);

			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().NotBeNull();

			// act
			RemoveConversation(conversation);

			// assert
			actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeNull();
			_context.EmailItems.ToList().Should().BeEmpty();
			_context.Comments.ToList().Should().BeEmpty();
		}

		[Fact]
		public void should_update_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("6")
									 .WithTopic("Topic6")
									 .WithAccountId("1")
									 .Build();

			AddConversation(conversation);

			// act
			conversation.Topic = "New topic";
			_context.SaveChanges();

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_update_email_in_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithAccountId("1")
									 .WithConversationId("6")
									 .WithTopic("Topic6")
									 .WithEmail(Create.EmailItem()
													  .WithAccountId("1")
													  .WithItemId("1")
													  .WithCreationTime(_now)
													  .WithSubject("Subj1")
													  .WithFolder("1", "2", "3")
													  .Build())
									 .Build();

			AddConversation(conversation);

			// act
			conversation.LatestEmail.Subject = "New subject";
			_context.SaveChanges();

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_update_comment_in_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("6")
									 .WithTopic("Topic6")
									 .WithAccountId("1")
									 .WithComment(Create.Comment()
														.WithAuthor("Author1")
														.WithBody("Body1")
														.WithOrder(1)
														.Build())
									 .Build();

			AddConversation(conversation);

			// act
			conversation.Comments[0].Body = "New body";
			_context.SaveChanges();

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Theory, AutoData]
		public void should_persist_conversation_correctly_after_merge_with_detached_conversation(Guid commentGuid)
		{
			// arrange
			var target = Create.Conversation()
							   .WithAccountId("1")
							   .WithConversationId("1")
							   .WithTopic("Topic1")
							   .WithComment(Create.Comment()
												  .WithAuthor("Author1")
												  .WithOrder(1)
												  .WithBody("Body 1")
												  .Build())
							   .WithEmail(Create.EmailItem()
												.WithAccountId("1")
												.WithItemId("1")
												.WithFolder("1", "2", "3")
												.WithCreationTime(new DateTime(2012, 12, 11))
												.WithSubject("Subject 1")
												.Build())
							   .Build();

			AddConversation(target);

			var source = Create.Conversation()
							   .WithConversationId("1")
							   .WithEmail(Create.EmailItem()
												.WithAccountId("1")
												.WithItemId("1")
												.WithFolder("1", "2", "3")
												.WithCreationTime(new DateTime(2012, 12, 12))
												.WithSubject("Subject 1")
												.Build())
							   .WithComment(Create.Comment()
												  .WithId(commentGuid)
												  .WithAuthor("Author1")
												  .WithOrder(1)
												  .WithBody("Body 2")
												  .Build())
							   .Build();

			//act
			MergeConversation(target, source);

			//assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(target.AccountId, target.ConversationId);
			actual.Comments.Should().HaveCount(1);
			actual.Comments[0].Guid.Should().Be(commentGuid);
			actual.Comments[0].Body.Should().Be("Body 2");
		}

		[Fact]
		public void should_return_all_conversations_with_childs()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithAccountId("1")
									 .WithConversationId("10")
									 .WithTopic("Topic10")
									 .WithComment(Create.Comment()
														.WithAuthor("Author1")
														.WithOrder(1)
														.WithBody("Body 1")
														.Build())
									 .WithEmail(Create.EmailItem()
													  .WithAccountId("1")
													  .WithItemId("1")
													  .WithFolder("1", "2", "3")
													  .WithCreationTime(new DateTime(2012, 12, 11))
													  .WithSubject("Subject 1")
													  .Build())
									 .Build();

			AddConversation(conversation);

			// act
			var conversations = _conversationRepository.GetAll().ToList();

			// assert
			conversations.Should().HaveCount(1);
			var actual = conversations.ElementAt(0);
			actual.Should().BeSameAs(conversation);
			Console.Out.WriteLine("actual = {0}", actual.Comments.Count);
		}

		[Fact]
		public void should_save_original_email_for_comment()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithAccountId("1")
									 .WithConversationId("123")
									 .WithTopic("Topic10")
									 .WithEmail(Create.EmailItem()
													  .WithAccountId("1")
													  .WithItemId("1")
													  .WithFolder("1", "2", "3")
													  .WithCreationTime(new DateTime(2012, 12, 11))
													  .WithSubject("Subject 1")
													  .Build())
									 .WithComment(Create.Comment()
														.WithAuthor("Author1")
														.WithOrder(1)
														.WithBody("Body 1")
														.Build())
									 .Build();

			AddConversation(conversation);

			// act
			var actual = _conversationRepository.GetByAccountIdAndConversationId("1", "123");

			// assert
			actual.Comments.Should().HaveCount(1);
			actual.Comments[0].OriginalEmail.Should().NotBeNull();
		}

		[Fact]
		public void should_save_conversation_after_save_and_merge_in_different_contexts()
		{
			// arrange
			var guid1 = Guid.NewGuid();
			var guid2 = Guid.NewGuid();
			var original = Create.Conversation()
								 .WithAccountId("1")
								 .WithConversationId("1")
								 .WithTopic("Topic1")
								 .WithEmail(Create.EmailItem()
												  .WithAccountId("1")
												  .WithItemId("1")
												  .WithFolder("1", "2", "3")
												  .WithCreationTime(new DateTime(2012, 12, 11))
												  .WithSubject("Subject 1")
												  .Build())
								 .WithComment(Create.Comment()
													.WithId(guid1)
													.WithAuthor("Author1")
													.WithOrder(1)
													.WithBody("Body 1")
													.Build())
								 .Build();

			AddConversation(original);

			var target = Create.Conversation()
							   .WithAccountId("1")
							   .WithConversationId("1")
							   .WithTopic("Topic1")
							   .WithEmail(Create.EmailItem()
												.WithAccountId("1")
												.WithItemId("1")
												.WithFolder("1", "2", "3")
												.WithCreationTime(new DateTime(2012, 12, 11))
												.WithSubject("Subject 1")
												.Build())
							   .WithEmail(Create.EmailItem()
												.WithAccountId("1")
												.WithItemId("2")
												.WithFolder("1", "2", "3")
												.WithCreationTime(new DateTime(2012, 12, 12))
												.WithSubject("Subject 1")
												.Build())
							   .WithComment(Create.Comment()
												  .WithId(guid1)
												  .WithAuthor("Author1")
												  .WithOrder(1)
												  .WithBody("Body 1")
												  .WithAnswer(Create.Comment()
																	.WithId(guid2)
																	.WithAuthor("Author2")
																	.WithOrder(2)
																	.WithBody("Body 2")
																	.Build()
												)
												  .Build()
				)
							   .Build();

			// act
			original = _conversationRepository.GetByAccountIdAndConversationId("1", "1");

			var mergeService = new MergeConversationService(new DbRepository<EmailItem>(_context),
															new DbRepository<Comment>(_context));
			mergeService.Merge(original, target);
			_context.SaveChanges();

			// assert
			var anotherRepository = new ConversationRepository(new ConversationContext(_connectionStringProvider));
			var actual = anotherRepository.GetByAccountIdAndConversationId("1", "1");
			actual.Emails.Should().HaveCount(2);
			actual.Comments.Should().HaveCount(1);
			actual.Comments[0].Answers.Should().HaveCount(1);
		}

		[Fact]
		public void should_map_parent_conversation_for_comments()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("3")
									 .WithTopic("Topic3")
									 .WithAccountId("1")
									 .WithComment(Create.Comment()
														.WithAuthor("Author1")
														.WithBody("Body1")
														.WithOrder(1)
														.Build())
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
			actual.Comments[0].Conversation.Should().BeSameAs(conversation);
		}

		[Fact]
		public void conversation_happy_flow()
		{
			// 1. ema sends to yma (merge on send)
			var conversation1 = Create.Conversation()
			                          .WithAccountId("ema@scalepoint.com")
			                          .WithConversationId("9deecb111d36479b8ddb6a22a7596a0e")
			                          .WithTopic("gg")
			                          .WithEmail(Create.EmailItem()
													   .WithAccountId("ema@scalepoint.com")
			                                           .WithCreationTime(new DateTime(2013, 4, 8, 21, 06, 0))
			                                           .WithSubject("gg")
			                                           .WithItemId("2fd")
			                                           .WithFolder("1", "1", "Sent Items")
			                                           .Build())
			                          .WithComment(Create.Comment()
			                                             .WithAuthor("Evgeniy Maksak")
			                                             .WithId(new Guid("{95CEA027-A50F-4530-95CC-672BE7B2CDC8}"))
			                                             .WithBody("gg")
			                                             .WithOrder(0)
			                                             .Build()
				)
			                          .Build();

			HandleMergeConversationCommand(conversation1);
			HandleUpdateEmailCommand(conversation1);
			HandleUpdateEmailCommand(conversation1);

			// 2. yma receives (merge on receive)
			var conversation2 = Create.Conversation()
									  .WithAccountId("yma@ciklum.com")
									  .WithConversationId("9deecb111d36479b8ddb6a22a7596a0e")
									  .WithTopic("gg")
									  .WithEmail(Create.EmailItem()
													   .WithAccountId("yma@ciklum.com")
													   .WithCreationTime(new DateTime(2013, 4, 8, 21, 06, 59))
													   .WithSubject("gg")
													   .WithItemId("b50")
													   .WithFolder("b50", "b5042", "Inbox")
													   .Build())
									  .WithComment(Create.Comment()
														 .WithAuthor("Evgeniy Maksak")
														 .WithId(new Guid("{95CEA027-A50F-4530-95CC-672BE7B2CDC8}"))
														 .WithBody("gg")
														 .WithOrder(0)
														 .Build()
				)
									  .Build();
			HandleMergeConversationCommand(conversation2);
			
			//3. UpdateMaiilItem
			var conversation3 = Create.Conversation()
			                          .WithAccountId("yma@ciklum.com")
			                          .WithConversationId("9deecb111d36479b8ddb6a22a7596a0e")
			                          .WithTopic("gg")
			                          .WithEmail(Create.EmailItem()
			                                           .WithAccountId("yma@ciklum.com")
			                                           .WithCreationTime(new DateTime(2013, 4, 8, 21, 06, 59))
			                                           .WithSubject("gg")
			                                           .WithItemId("b50")
			                                           .WithFolder("b50", "b5042", "Inbox")
			                                           .Build())
			                          .WithComment(Create.Comment()
			                                             .WithAuthor("Evgeniy Maksak")
			                                             .WithId(new Guid("{95CEA027-A50F-4530-95CC-672BE7B2CDC8}"))
			                                             .WithBody("gg")
			                                             .WithOrder(0)
			                                             .Build()
				)
			                          .Build();

			HandleUpdateEmailCommand(conversation3);
			

			//4. MergeConversation
			var conversation4 = Create.Conversation()
			                          .WithAccountId("yma@ciklum.com")
			                          .WithConversationId("9deecb111d36479b8ddb6a22a7596a0e")
			                          .WithTopic("gg")
			                          .WithEmail(Create.EmailItem()
			                                           .WithAccountId("yma@ciklum.com")
			                                           .WithCreationTime(new DateTime(2013, 4, 8, 21, 00, 00))
			                                           .WithSubject("RE: gg")
			                                           .WithItemId("b50")
			                                           .WithFolder("121212", "b50421212", "Sent Items")
			                                           .Build())
			                          .WithComment(Create.Comment()
			                                             .WithAuthor("Evgeniy Maksak")
			                                             .WithId(new Guid("{95CEA027-A50F-4530-95CC-672BE7B2CDC8}"))
			                                             .WithBody("gg")
			                                             .WithOrder(0)
			                                             .WithAnswer(Create.Comment()
			                                                               .WithAuthor("Yma")
			                                                               .WithId(
				                                                               new Guid("{DA3E09BA-3032-41B4-8A8E-EFB5BD56D0AD}"))
			                                                               .WithOrder(1)
			                                                               .Build()
				                                       )
			                                             .Build()
				)
			                          .Build();

			HandleMergeConversationCommand(conversation4);
		}

		private Conversation _binding;
		private void HandleMergeConversationCommand(Conversation conversation)
		{
			using (new UnitOfWork(_context))
			{
				_conversationCommandHandlers.Handle(new MergeConversation(conversation));
			}
			_binding = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
		}

		private void HandleUpdateEmailCommand(Conversation conversation)
		{
			using (new UnitOfWork(_context))
			{
				_conversationCommandHandlers.Handle(new UpdateMailItem(conversation));
			}
			_binding = _conversationRepository.GetByAccountIdAndConversationId(conversation.AccountId, conversation.ConversationId);
		}

		private void AddConversation(Conversation conversation)
		{
			_conversationRepository.Add(conversation);
			var emailRepo = new DbRepository<EmailItem>(_context);

			foreach (var emailItem in conversation.Emails)
			{
				emailRepo.Add(emailItem);
			}

			var commentsRepo = new DbRepository<Comment>(_context);
			foreach (var comment in conversation.Comments)
			{
				commentsRepo.Add(comment);
			}

			_context.SaveChanges();
		}

		private void RemoveConversation(Conversation conversation)
		{
			_conversationRepository.Remove(conversation);
			_context.SaveChanges();
		}

		private void MergeConversation(Conversation target, Conversation source)
		{
			_mergeConversationService.Merge(target, source);
			_context.SaveChanges();
		}
	}

	public class TestConnectionStringProvider : IConnectionStringProvider
	{
		public string ConnectionString
		{
			get { return "Data Source=c:\\Projects\\emailpingpong\\Source\\EmailPingPong.Tests\\emailpingpong.sdf"; }
		}
	}
}