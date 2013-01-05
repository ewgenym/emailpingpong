namespace EmailPingPong.Core.Model
{
	public class ModelEntityWithLongId
	{
		public long Id { get; set; }

		public override int GetHashCode()
		{
			if (!IsPersisted())
			{
				return base.GetHashCode();
			}

			unchecked
			{
				int result = GetType().GetHashCode();
				result = 42 * result + Id.GetHashCode();
				return result;
			}
		}

		public override bool Equals(object other)
		{
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			if ((other == null) || !(other is ModelEntityWithLongId))
			{
				return false;
			}

			var thisType = GetType();
			var otherType = other.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			if (Id.Equals(default(long)) && (other as ModelEntityWithLongId).Id.Equals(default(long)))
			{
				return base.Equals(other);
			}

			return Id == (other as ModelEntityWithLongId).Id;
		}

		public virtual bool IsPersisted()
		{
			return Id > 0;
		}

		public static bool operator ==(ModelEntityWithLongId entity1, ModelEntityWithLongId entity2)
		{
			var obj1 = (object)entity1;
			if (obj1 == null && ((object)entity2) == null)
			{
				return true;
			}

			return obj1 != null && entity1.Equals(entity2);
		}

		public static bool operator !=(ModelEntityWithLongId entity1, ModelEntityWithLongId entity2)
		{
			return !(entity1 == entity2);
		}
	}
}