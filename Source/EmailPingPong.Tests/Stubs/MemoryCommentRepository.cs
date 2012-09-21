using System;
using System.Collections.Generic;
using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Tests.Stubs
{
	public class MemoryCommentRepository : MemoryRepository<Comment>, ICommentRepository
	{
		public IEnumerable<Comment> GetByTrackingId(string trackingId)
		{
			throw new NotImplementedException();
			//return _repository.Where(c => c.TrackingId == trackingId);
		}
	}
}