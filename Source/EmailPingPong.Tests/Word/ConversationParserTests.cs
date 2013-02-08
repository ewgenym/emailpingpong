using System;
using System.Collections.Generic;
using System.Linq;
using EmailPingPong.Outlook.Common.Word;
using EmailPingPong.Tests.Builders;
using FluentAssertions;
using Microsoft.Office.Interop.Word;
using Xunit;
using Comment = EmailPingPong.Core.Model.Comment;

namespace EmailPingPong.Tests.Word
{
	public class ConversationParserTests
	{
		private readonly ConversationParser _parser;

		public ConversationParserTests()
		{
			_parser = new ConversationParser();
		}

		[Fact]
		public void should_return_empty_collection_for_empty_document()
		{
			// arrange
			var document = Create.Document().Build();

			// act
			var comments = _parser.Parse(document);

			// assert
			comments.Should().BeEmpty();
		}

		[Fact]
		public void should_parse_single_question()
		{
			// arrange
			const string expectedAuthor = "Author 1";
			const string expectedBody = "Hi, there!";
			var document = Create.Document()
								 .WithSelectedText(expectedBody)
								 .WithPing(expectedAuthor)
								 .Build();

			// act
			var comments = Parse(document);

			// assert
			comments.Should().HaveCount(1);
			AssertComment(comments.First(), expectedAuthor, expectedBody);
		}

		[Fact]
		public void shoul_parse_several_questions()
		{
			// arrange
			var document = Create.Document()
								 .WithSelectedText("question1")
								 .WithPing("author1")
								 .WithParagraph()
								 .WithSelectedText("question2")
								 .WithPing("author1")
								 .WithParagraph()
								 .WithSelectedText("question3")
								 .WithPing("author1")
								 .Build();

			// act
			var comments = Parse(document);

			// assert
			comments.Should().HaveCount(3);
		}

		[Fact]
		public void should_parse_question_with_answer()
		{
			// arrange
			const string question = "Question?";
			const string author1 = "Author1";
			const string author2 = "Author2";
			const string answer = "Answer!!";

			var document = Create.Document()
								 .WithSelectedText(question)
								 .WithPing(author1)
								 .WithPong(author2)
								 .WithText(answer)
								 .Build();

			// act
			var comments = Parse(document);

			// assert
			comments.Should().HaveCount(1);
			AssertComment(comments.First(), author1, question);

			comments.First().Answers.Should().HaveCount(1);
			AssertComment(comments.First().Answers.First(), author2, answer);
		}

		[Fact]
		public void sould_parse_question_with_several_answers()
		{
			// arrange
			var document = Create.Document()
								 .WithSelectedText("question")
								 .WithPing("author1")
								 .WithPong("author2")
								 .WithText("answer1")
								 .WithPong("author3")
								 .WithText("answer2")
								 .WithPong("author4")
								 .WithText("answer3")
								 .Build();

			// act
			var comments = Parse(document);

			// assert
			comments.Should().HaveCount(1);
			comments[0].Answers.Should().HaveCount(3);
		}

		[Fact]
		public void should_skip_content_controls_other_than_pingpong()
		{
			// arrange
			var document = Create.Document()
								 .Build();

			document.ContentControls.Add(WdContentControlType.wdContentControlRichText, document.Application.Selection.Range);

			// act
			var comments = Parse(document);

			// assert
			comments.Should().BeEmpty();
		}

		[Fact]
		public void should_parse_question_without_author()
		{
			// arrange
			var document = Create.Document()
			                     .WithSelectedText("question")
			                     .WithPing(null)
								 .Build();

			// act
			var comments = Parse(document);

			// assert
			comments.Should().HaveCount(1);
			comments[0].Author.Should().BeNull();
		}

		[Fact]
		public void should_parser_answer_without_answer()
		{
			// arrange
			var document = Create.Document()
								 .WithSelectedText("question")
								 .WithPing("author1")
								 .WithPong(null)
								 .Build();

			// act
			var comments = Parse(document);

			// assert
			comments.Should().HaveCount(1);
			comments[0].Answers.Should().HaveCount(1);
			comments[0].Answers[0].Author.Should().BeNull();
		}

		private IList<Comment> Parse(Document document)
		{
			return _parser.Parse(document).ToList();
		}

		private static void AssertComment(Comment comment, string expectedAuthor, string expectedBody)
		{
			comment.Author.Should().Be(expectedAuthor);
			comment.Body.Should().Be(expectedBody);
		}
	}
}