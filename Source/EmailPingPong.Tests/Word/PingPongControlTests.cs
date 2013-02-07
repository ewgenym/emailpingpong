using System;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Word.Controls;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Word
{
	public class PingPongControlTests
	{
		[Fact]
		public void should_undo_ping()
		{
			// arrange
			const string expected = "question1";
			var document = Create.Document()
			                     .WithSelectedText(expected)
			                     .WithPing("author1")
			                     .Build();

			var pingContentControl = document.Application.Selection.Range.ParentContentControl;

			// act
			var pingControl = new PingControl(document);
			pingControl.Undo(pingContentControl);

			// assert
			document.ContentControls.Count.Should().Be(0);
			document.Application.Selection.Text.Should().Be(expected);
		}

		[Fact]
		public void should_undo_pong()
		{
			// arrange
			const string expected = "answer";
			var document = Create.Document()
								 .WithSelectedText("question")
								 .WithPing("author1")
								 .WithPong("author2")
								 .WithText(expected)
								 .Build();

			var pongContentControl = document.Application.Selection.Range.ParentContentControl;

			// act
			var pongControl = new PongControl(document);
			pongControl.Undo(pongContentControl);

			// assert
			document.Application.Selection.Text.Should().Be(expected);
			document.Application.Selection.Range.ParentContentControl.Should().BeNull();
		}
	}
}