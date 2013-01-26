using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmailPingPong.Core.Model
{
	public class Comment : ModelEntityWithLongId
	{
		public Comment()
		{
			Answers = new List<Comment>();
		}

		[Required]
		public Guid Guid { get; set; }

		[Required]
		public string Author { get; set; }

		[Required]
		public string Body { get; set; }

		[Required]
		public DateTime CreatedOn { get; set; }

		//TODO: Use sortable timestamp for index
		[Required]
		public int Index { get; set; }

		public Comment Parent { get; set; }

		public IList<Comment> Answers { get; set; }

		public EmailItem OriginalEmail { get; set; }

		public void AddAnswer(Comment answer)
		{
			answer.Parent = this;
			Answers.Add(answer);

			if (answer.OriginalEmail == null)
			{
				answer.OriginalEmail = OriginalEmail;
			}
		}
	}
}