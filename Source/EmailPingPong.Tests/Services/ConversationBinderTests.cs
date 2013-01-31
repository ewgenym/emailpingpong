using System;
using System.Collections.Generic;
using EmailPingPong.Core.Model;
using EmailPingPong.Outlook.Common.Word;
using EmailPingPong.Outlook2010.Services;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using NSubstitute;
using Xunit;
using Comment = EmailPingPong.Core.Model.Comment;

namespace EmailPingPong.Tests.Services
{
	public class ConversationBinderTests
	{
		private readonly IConversationParser _conversationParser;
		private readonly IEmailItemBinder _emailItemBinder;
		private readonly IConversationMetadataTracker _metadataTracker;
		private readonly ConversationBinder _conversationBinder;
		private readonly MailItem _mailItem;
		private readonly PropertyAccessor _propertyAccessor;
		private readonly Inspector _inspector;
		private readonly Document _document;

		public ConversationBinderTests()
		{
			_conversationParser = Substitute.For<IConversationParser>();
			_emailItemBinder = Substitute.For<IEmailItemBinder>();
			_metadataTracker = Substitute.For<IConversationMetadataTracker>();
			_conversationBinder = new ConversationBinder(_conversationParser, _emailItemBinder, _metadataTracker);

			_mailItem = Substitute.For<MailItem>();
			_propertyAccessor = Substitute.For<PropertyAccessor>();
			_mailItem.PropertyAccessor.Returns(_propertyAccessor);
			_inspector = Substitute.For<Inspector>();
			_document = Substitute.For<Document>();
			((Document)_inspector.WordEditor).Returns(_document);
			_mailItem.GetInspector.Returns(_inspector);

			_metadataTracker.TracksConversation(null).ReturnsForAnyArgs(true);

			((object)_propertyAccessor.GetProperty(null)).ReturnsForAnyArgs(null);
			_emailItemBinder.Bind(null).ReturnsForAnyArgs(new EmailItem() { Folder = new EmailFolder("1", "1", "1") });
			_metadataTracker.Read(null).ReturnsForAnyArgs(new ConversationMetadata());
		}

		[Fact]
		public void should_bind_conversation_folder_info()
		{
			// arrange
			const string accountId = "ema@mail.com";
			const string storeId = "123456789";
			const string folderId = "987654321";

			_emailItemBinder.Bind(null).ReturnsForAnyArgs(new EmailItem
				{
					AccountId = accountId,
					Folder = new EmailFolder(storeId, folderId, "Inbox")
				});

			// act
			var conversation = _conversationBinder.Bind(_mailItem);

			// assert
			conversation.AccountId.Should().Be(accountId);
			conversation.StoreId.Should().Be(storeId);
			conversation.FolderId.Should().Be(folderId);
		}

		[Fact]
		public void should_bind_conversation_id()
		{
			// arrange
			const string conversationId = "123456";
			_metadataTracker.Read(_mailItem).Returns(new ConversationMetadata { ConversationId = conversationId });

			// act
			var conversation = _conversationBinder.Bind(_mailItem);

			// assert
			conversation.ConversationId.Should().Be(conversationId);
		}

		[Fact]
		public void should_bind_conversation_topic()
		{
			// arrange
			const string conversationTopic = "Topic1";
			((object)_propertyAccessor.GetProperty(null)).ReturnsForAnyArgs(conversationTopic);

			// act
			var conversation = _conversationBinder.Bind(_mailItem);

			// assert
			conversation.Topic.Should().Be(conversationTopic);
		}

		[Fact]
		public void should_bind_conversation_email()
		{
			// arrange
			var email = Create.EmailItem()
							  .WithAccountId("1")
							  .WithItemId("1")
							  .WithFolder("1", "1", "1")
							  .WithCreationTime(new DateTime(2013, 1, 31))
							  .WithSubject("Subject1")
							  .Build();

			_emailItemBinder.Bind(null).ReturnsForAnyArgs(email);

			// act
			var conversation = _conversationBinder.Bind(_mailItem);

			// assert
			conversation.Emails.Should().HaveCount(1);
			conversation.Emails[0].Should().BeSameAs(email);
		}

		[Fact]
		public void should_bind_conversation_comments()
		{
			// arrange
			var comment = Create.Comment()
								.WithId(Guid.NewGuid())
								.WithAuthor("Author1")
								.WithBody("Body1")
								.WithOrder(0)
								.Build();
			_conversationParser.Parse(null).ReturnsForAnyArgs(new List<Comment> { comment });

			// act
			var conversation = _conversationBinder.Bind(_mailItem);

			// assert
			conversation.Comments.Should().HaveCount(1);
			conversation.Comments[0].Should().BeSameAs(comment);
		}

		[Fact]
		public void should_not_bind_when_does_not_track_conversation()
		{
			// arrange
			_metadataTracker.TracksConversation(null).ReturnsForAnyArgs(false);

			// act
			var conversation = _conversationBinder.Bind(_mailItem);

			// assert
			conversation.Should().BeNull();
		}
	}
}