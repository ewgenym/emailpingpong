namespace EmailPingPong.Core.Events
{
	public interface IEventHandler<T>
		where T : IDomainEvent
	{
		 void Handle(T @event);
	}
}