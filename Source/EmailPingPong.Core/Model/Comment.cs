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
		public virtual Guid Guid { get; set; }

		[Required]
		public virtual string Author { get; set; }

		public virtual string Body { get; set; }

		[Required]
		public virtual DateTime CreatedOn { get; set; }

		//TODO: Use sortable timestamp for index
		[Required]
		public virtual int Index { get; set; }

		public virtual Comment Parent { get; set; }

		public virtual IList<Comment> Answers { get; set; }

		public virtual EmailItem OriginalEmail { get; set; }

		public virtual Conversation Conversation { get; set; }

		public virtual void AddAnswer(Comment answer)
		{
			answer.Parent = this;
			Answers.Add(answer);

			if (answer.OriginalEmail == null)
			{
				answer.OriginalEmail = OriginalEmail;
			}
		}
		protected override int GetEntityHashCode()
		{
			return Guid.GetHashCode();
		}
		protected override bool EntityEquals(ModelEntityWithLongId other)
		{
			return Guid == ((Comment) other).Guid;
		}
	}
}