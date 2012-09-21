using System.Collections.Generic;
using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Tests.Stubs
{
	public class MemoryRepository<T> : IRepository<T>
		where T : ModelEntityWithLongId
	{
		protected readonly List<T> _repository = new List<T>();

		public T GetById(long id)
		{
			return _repository.SingleOrDefault(e => e.Id == id);
		}

		public void Add(T entity)
		{
			_repository.Add(entity);
		}

		public void Remove(T entity)
		{
			_repository.Remove(entity);
		}
	}
}