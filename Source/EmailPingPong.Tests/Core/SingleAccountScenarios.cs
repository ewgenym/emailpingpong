using System.Linq;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Services.Implementation;
using EmailPingPong.Tests.Stubs;
using NUnit.Framework;

namespace EmailPingPong.Tests.Core
{
	[TestFixture]
	public class SingleAccountScenarios : TestBase
	{
		[Test]
		public void should_extract_new_comment()
		{
			//var conversationService = new ConversationService(new MemoryCommentRepository());

			//// Account 1. Compose question
			//var mail = Create.EmailItem()
			//    .WithItemId("1")
			//    .Build();

			//var comment = Create.Comment()
			//    .WithId(1)
			//    .WithAuthor("Test author")
			//    .WithBody("Test body")
			//    .Build();

			//// Account 1. Send question
			//var result = conversationService.ExtractConversation(mail, new[] {comment});

			//// assert
			//Assert.IsNotEmpty(result);
			//Assert.That(result, Has.Count.EqualTo(1));
			//Assert.Contains(comment, result.ToList());
		}

		[Test]
		public void should_extract_simple_question_answer_conversation()
		{
			//var conversationService = new ConversationService(new MemoryCommentRepository());

			//// Account 1. Compose question
			//var questionEmail = Create.EmailItem()
			//    .WithItemId("1")
			//    .Build();

			//var question = Create.Comment()
			//    .WithId(1)
			//    .WithAuthor("PO")
			//    .WithBody("Question 1?")
			//    .Build();

			//// Account 1. Send question e-mail
			//conversationService.ExtractConversation(questionEmail, new[] { question });

			//// Account 2. Compose an answer
			//var answerEmail = Create.EmailItem()
			//    .WithItemId("2")
			//    .Build();
			
			//var answer = Create.Comment()
			//    .WithId(2)
			//    .WithAuthor("Dev")
			//    .WithBody("Answer 1")
			//    .Build();

			//question.AddAnswer(answer);

			//// Account 1. Receive answers
			//var conversation = conversationService.ExtractConversation(answerEmail, new[] { question });
			
			//// assert
			//Assert.That(conversation.Contains(question));
			//Assert.That(question.Answers.Contains(answer));

			//Assert.That(question.Emails.Count, Is.EqualTo(2));
			//Assert.That(answer.Emails.Count, Is.EqualTo(1));
		}

		[Test]
		public void should_merge_existing_comments_in_conversation()
		{
			//var conversationService = new ConversationService(new MemoryCommentRepository());

			//// Account 1. Compose question
			//var questionEmail = Create.EmailItem()
			//    .WithItemId("1")
			//    .Build();

			//var question = Create.Comment()
			//    .WithId(1)
			//    .WithAuthor("PO")
			//    .WithBody("Question 1?")
			//    .Build();

			//// Account 1. Send question e-mail
			//conversationService.ExtractConversation(questionEmail, new[] { question });

			//// Account 2. Compose an answer
			//var answerEmail = Create.EmailItem()
			//    .WithItemId("2")
			//    .Build();

			//var answer = Create.Comment()
			//    .WithId(2)
			//    .WithAuthor("Dev")
			//    .WithBody("Answer 1")
			//    .Build();

			////Account 2. Change the question text
			//question.Body = "Question 1? With some remarks...";
			//question.AddAnswer(answer);

			//// Account 1. Receive answers
			//var conversation = conversationService.ExtractConversation(answerEmail, new[] { question });

			//// assert
			//Assert.That(question.Body, Is.EqualTo("Question 1? With some remarks..."));

			//Assert.That(conversation.Contains(question));
			//Assert.That(question.Answers.Contains(answer));

			//Assert.That(question.Emails.Count, Is.EqualTo(2));
			//Assert.That(answer.Emails.Count, Is.EqualTo(1));
		}
	}
}
