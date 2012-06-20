using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conversation.Core.Domain;

namespace Conversation.Infrastructure.Repositories
{
	public interface ICommentRepository
	{
		void SaveChanges();
		void AddOrUpdate(IEnumerable<Question> questions);
		void Delete(IEnumerable<Question> questions);
		IEnumerable<Question> Questions { get; }
		IEnumerable<Comment> Comments { get; }
	}
}
