using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.Infrastructure.Repositories
{
	public class DbRepository<T> : IRepository<T>
		where T : ModelEntityWithLongId
	{
		private readonly DbContext _dbContext;

		public DbRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public virtual T GetById(long id)
		{
			return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
		}

		public virtual IEnumerable<T> GetAll()
		{
			return _dbContext.Set<T>();
		}

		public virtual void Add(T entity)
		{
			_dbContext.Set<T>().Add(entity);
		}

		public virtual void Remove(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
		}
	}
}