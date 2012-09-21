using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Infrastructure.Repositories
{
	public class DbRepository<T> : IRepository<T>
		where T : ModelEntityWithLongId
	{
		public T GetById(long id)
		{
			throw new System.NotImplementedException();
		}

		public void Add(T entity)
		{
			throw new System.NotImplementedException();
		}

		public void Remove(T entity)
		{
			throw new System.NotImplementedException();
		}
	}
}