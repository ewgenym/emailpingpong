using System;
using Castle.Windsor;
using EmailPingPong.Core.Events;

namespace EmailPingPong.Infrastructure
{
	public class EventPublisher : IEventPublisher
	{
		private readonly IWindsorContainer _container;

		public EventPublisher(IWindsorContainer container)
		{
			if (container == null)
			{
				throw new ArgumentNullException("container");
			}

			_container = container;
		}

		public void Publish<T>(T @event) where T : IDomainEvent
		{
			if (@event == null)
			{
				throw new ArgumentNullException("event");
			}

			var handlers = _container.ResolveAll<IEventHandler<T>>();
			foreach (var handler in handlers)
			{
				handler.Handle(@event);
			}
		}
	}
}