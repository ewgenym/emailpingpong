using System.Collections.Generic;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Repositories
{
	public interface IRepository<T>
		where T: ModelEntityWithLongId
	{
		T GetById(long id);

		IEnumerable<T> GetAll();

		void Add(T entity);

		void Remove(T entity);
	}
}