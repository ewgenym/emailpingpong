using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using EmailPingPong.Outlook.Common.Word.Utils;
using Microsoft.Office.Interop.Word;
using Comment = EmailPingPong.Core.Model.Comment;

namespace EmailPingPong.Outlook.Common.Word
{
	public class ConversationParser : IConversationParser
	{
		public IEnumerable<Comment> Parse(Document document)
		{
			var questions = new List<Comment>();
			Comment lastQuestion = null;

			int i = 0;
			foreach (ContentControl control in document.ContentControls)
			{
				if (control.IsPingPong())
				{
					Comment comment = null;

					if (control.IsPing())
					{
						var question = new Comment
						               	{
											Guid = control.CommentId(),
						               		Body = control.Range.Text,
											CreatedOn = control.CreationDate(),
						               	};

						questions.Add(question);
						lastQuestion = question;
						comment = question;
					}


					if (control.IsPong())
					{
						comment = new Comment
						          	{
										Guid = control.CommentId(),
						          		Body = control.Range.Text,
										CreatedOn = control.CreationDate(),
						          	};

						if (lastQuestion != null)
						{
							lastQuestion.AddAnswer(comment);
						}
					}

					if (comment != null)
					{
						var text = control.Range.Text;
						var regexp = new Regex(@"^\[(.*)\]:\s?");
						var match = regexp.Match(text);
						if (match.Groups.Count == 2)
						{
							comment.Author = match.Groups[1].Value;
							Console.Out.WriteLine("comment.Author = {0}", comment.Author);
						}
						comment.Body = regexp.Replace(text, string.Empty, 1);
						comment.Index = i;
					}
				}
				i++;
			}

			return questions;
		}
	}

	public interface IConversationParser
	{
		IEnumerable<Comment> Parse(Document document);
	}
}