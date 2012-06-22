using System;
using System.Collections.Generic;
using EmailPingPong.Core.Domain;
using EmailPingPong.UI.Word.Utils;
using Microsoft.Office.Interop.Word;
using Comment = EmailPingPong.Core.Domain.Comment;

namespace EmailPingPong.UI.Word
{
	public class PingPongParser
	{
		public IList<Question> Parse(Document document, string itemId, string storeId, string folder)
		{
			var questions = new List<Question>();
			Question lastQuestion = null;

			int i = 0;
			foreach (ContentControl control in document.ContentControls)
			{
				if (control.IsPingPong())
				{
					Comment comment = null;

					var creationDate = DateTime.Now;
					var metadata = control.Tag.Split(';');
					if (metadata.Length > 1)
					{
						creationDate = DateTime.Parse(metadata[1]).ToLocalTime();
					}

					if (control.IsPing())
					{
						var question = new Question
						               	{
						               		Id = long.Parse(control.ID),
						               		Body = control.Range.Text,
						               		Created = creationDate,
						               		ItemId = itemId,
											StoreId = storeId,
											FolderId = folder,
						               	};

						questions.Add(question);
						lastQuestion = question;
						comment = question;
					}


					if (control.IsPong())
					{
						comment = new Comment
						          	{
						          		Id = long.Parse(control.ID),
						          		Body = control.Range.Text,
										Created = creationDate,
						          		ItemId = itemId,
										StoreId = storeId,
										FolderId = folder,
						          	};

						if (lastQuestion != null)
						{
							lastQuestion.Comments.Add(comment);
						}
					}

					if (comment != null)
					{
						foreach (ContentControl nestedControl in control.Range.ContentControls)
						{
							if (nestedControl.IsAuthor())
							{
								comment.Author = nestedControl.Range.Text.Trim('[', ']', ' ', ':');
								var authorLessRange = document.Range(nestedControl.Range.End, control.Range.End);
								comment.Body = authorLessRange.Text;
							}
						}

						comment.Order = i;
					}
				}
				i++;
			}
			return questions;
		}
	}
}