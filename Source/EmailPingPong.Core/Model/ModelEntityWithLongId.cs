namespace EmailPingPong.Core.Model
{
	public class ModelEntityWithLongId
	{
		public virtual long Id { get; set; }

		public virtual bool IsPersisted()
		{
			return Id > 0;
		}
	}
}