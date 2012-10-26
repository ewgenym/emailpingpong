using System;
using System.Collections.Generic;

namespace EmailPingPong.Core.Model
{
	public class Comment : ModelEntityWithLongId
	{
		public Comment()
		{
			Answers = new List<Comment>();
		}

		public string Author { get; set; }

		public string Body { get; set; }

		public DateTime CreatedOn { get; set; }

		//TODO: Use sortable timestamp for index
		public int ConversationIndex { get; set; }

		public Comment Parent { get; set; }

		public IList<Comment> Answers { get; set; }

		public void AddAnswer(Comment answer)
		{
			answer.Parent = this;
			Answers.Add(answer);
		}
	}
}