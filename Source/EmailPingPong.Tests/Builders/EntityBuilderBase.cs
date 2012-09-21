namespace EmailPingPong.Tests.Builders
{
	public abstract class EntityBuilderBase<T>
		where T: class, new()
	{
		private readonly T _entityToBuild;

		protected EntityBuilderBase()
		{
			_entityToBuild = new T();
		}

		protected T EntityToBuild
		{
			get { return _entityToBuild; }
		}

		public T Build()
		{
			CompleteBuilding();

			return _entityToBuild;
		}

		private void CompleteBuilding()
		{
			InitWithValidValues();
		}

		protected abstract void InitWithValidValues();
	}
}