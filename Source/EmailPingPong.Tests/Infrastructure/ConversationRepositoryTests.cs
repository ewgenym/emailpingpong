using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Repositories;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Infrastructure
{
	public class ConversationRepositoryTests
	{
		private readonly IConnectionStringProvider _connectionStringProvider;
		private readonly IConversationRepository _repository;
		private readonly ConversationContext _context;
		private readonly DateTime _now = new DateTime(2012, 12, 28, 16, 15, 0);

		public ConversationRepositoryTests()
		{
			_connectionStringProvider = new TestConnectionStringProvider();

			Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
			Database.SetInitializer(new DropCreateDatabaseAlways<ConversationContext>());

			_context = new ConversationContext(_connectionStringProvider);

			_context.Database.Delete();
			_context.Database.Create();

			_repository = new ConversationRepository(_context);
		}

		[Fact]
		public void should_add_simple_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("1")
									 .WithTopic("Topic1")
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_add_conversation_with_email()
		{
			// arrange
			var conversation = Create.Conversation()
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
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_add_conversation_with_comment()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("3")
									 .WithTopic("Topic3")
									 .WithComment(Create.Comment()
														.WithAuthor("Author1")
														.WithBody("Body1")
														.WithOrder(1)
														.Build())
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_add_conversation_with_comment_and_answer()
		{
			// arrange
			var conversation = Create.Conversation()
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
											   .WithAuthor("Author1")
											   .WithBody("Body1")
											   .WithOrder(1)
											   .WithAnswer(
												   Create.Comment()
														 .WithAuthor("Author2")
														 .WithBody("Body2")
														 .WithOrder(2)
														 .Build()
											 ).Build())
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_add_conversation_with_email_and_comment_and_answer()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("5")
									 .WithTopic("Topic5")
									 .WithComment(
										 Create.Comment()
											   .WithAuthor("Author1")
											   .WithBody("Body1")
											   .WithOrder(1)
											   .WithAnswer(
												   Create.Comment()
														 .WithAuthor("Author2")
														 .WithBody("Body2")
														 .WithOrder(2)
														 .Build()
											 ).Build())
									 .Build();

			// act
			AddConversation(conversation);

			// assert
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_delete_conversation_with_email()
		{
			// arrange
			var conversation = Create.Conversation()
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

			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().NotBeNull();

			// act
			RemoveConversation(conversation);

			// assert
			actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeNull();
		}

		[Fact]
		public void should_delete_conversation_with_comment()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("5")
									 .WithTopic("Topic5")
									 .WithComment(
										 Create.Comment()
											   .WithAuthor("Author1")
											   .WithBody("Body1")
											   .WithOrder(1)
											   .Build())
									 .Build();

			AddConversation(conversation);

			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().NotBeNull();

			// act
			RemoveConversation(conversation);

			// assert
			actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeNull();
		}

		[Fact]
		public void should_delete_conversation_with_comment_with_answers()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("5")
									 .WithTopic("Topic5")
									 .WithComment(
										 Create.Comment()
											   .WithAuthor("Author1")
											   .WithBody("Body1")
											   .WithOrder(1)
											   .WithAnswer(
												   Create.Comment()
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

			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().NotBeNull();

			// act
			RemoveConversation(conversation);

			// assert
			actual = _repository.GetByConversationId(conversation.ConversationId);
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
									 .Build();

			AddConversation(conversation);

			// act
			conversation.Topic = "New topic";
			_repository.SaveChanges();

			// assert
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_update_email_in_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
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
			conversation.NewestEmail.Subject = "New subject";
			_repository.SaveChanges();

			// assert
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_update_comment_in_conversation()
		{
			// arrange
			var conversation = Create.Conversation()
									 .WithConversationId("6")
									 .WithTopic("Topic6")
									 .WithComment(Create.Comment()
														.WithAuthor("Author1")
														.WithBody("Body1")
														.WithOrder(1)
														.Build())
									 .Build();

			AddConversation(conversation);

			// act
			conversation.Comments[0].Body = "New body";
			_repository.SaveChanges();

			// assert
			var actual = _repository.GetByConversationId(conversation.ConversationId);
			actual.Should().BeSameAs(conversation);
		}

		[Fact]
		public void should_persist_conversation_correctly_after_merge_with_detached_conversation()
		{
			// arrange
			var target = Create.Conversation()
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
												  .WithId(1)
												  .WithAuthor("Author1")
												  .WithOrder(1)
												  .WithBody("Body 2")
												  .Build())
							   .Build();

			//act
			target.Merge(source);
			_repository.SaveChanges();

			//assert
			var actual = _repository.GetByConversationId(target.ConversationId);
			actual.Comments.Should().HaveCount(1);
			actual.Comments[0].Id.Should().Be(1);
			actual.Comments[0].Body.Should().Be("Body 2");
		}

		private void AddConversation(Conversation conversation)
		{
			_repository.Add(conversation);
			_repository.SaveChanges();
		}

		private void RemoveConversation(Conversation conversation)
		{
			_repository.Remove(conversation);
			_repository.SaveChanges();
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