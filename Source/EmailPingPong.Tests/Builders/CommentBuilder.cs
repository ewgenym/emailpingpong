using System;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Tests.Builders
{
	public class CommentBuilder : EntityBuilderBase<Comment>
	{
		protected override void InitWithValidValues()
		{
			if (EntityToBuild.CreatedOn == default (DateTime))
			{
				EntityToBuild.CreatedOn = DateTime.Now;
			}
		}

		public CommentBuilder WithId(Guid guid)
		{
			EntityToBuild.Guid = guid;
			return this;
		}

		public CommentBuilder WithAuthor(string author)
		{
			EntityToBuild.Author = author;
			return this;
		}

		public CommentBuilder WithBody(string body)
		{
			EntityToBuild.Body = body;
			return this;
		}

		public CommentBuilder WithOrder(int order)
		{
			EntityToBuild.Index = order;
			return this;
		}

		public CommentBuilder WithAnswer(Comment answer)
		{
			EntityToBuild.AddAnswer(answer);
			return this;
		}

		public CommentBuilder WithOriginalEmail(EmailItem email)
		{
			EntityToBuild.OriginalEmail = email;
			return this;
		}
	}
}