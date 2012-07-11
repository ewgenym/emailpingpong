using System.Collections.Generic;
using EmailPingPong.Core.Domain;

namespace EmailPingPong.Infrastructure.Repositories
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
