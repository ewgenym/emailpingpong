using System.Collections.Generic;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Repositories
{
	public interface ICommentRepository : IRepository<Comment>
	{
		IEnumerable<Comment> GetByTrackingId(string trackingId);
	}
}