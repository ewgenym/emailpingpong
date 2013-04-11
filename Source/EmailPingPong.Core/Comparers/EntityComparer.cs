using System.Collections.Generic;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Comparers
{
	public class EntityComparer<T> : IEqualityComparer<T>
		where T : ModelEntityWithLongId
	{
		public int GetHashCode(T entity)
		{
			unchecked
			{
				int result = GetType().GetHashCode();
				result = 42 * result + GetEntityHashCode(entity);
				return result;
			}
		}

		protected virtual int GetEntityHashCode(T entity)
		{
			return entity.Id.GetHashCode();
		}

		public bool Equals(T x, T y)
		{
			if (ReferenceEquals(x, y))
			{
				return true;
			}

			if (x == null || y == null)
			{
				return false;
			}

			var thisType = x.GetType();
			var otherType = y.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			return EntitiesEqual(x, y);
		}

		protected virtual bool EntitiesEqual(T x, T y)
		{
			return x.Id == y.Id;
		}
	}
}