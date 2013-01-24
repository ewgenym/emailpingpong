using System;
using Castle.Windsor;
using EmailPingPong.Core.Commands;

namespace EmailPingPong.Infrastructure
{
	public class CommandDispatcher : ICommandDispatcher
	{
		private readonly IWindsorContainer _container;

		public CommandDispatcher(IWindsorContainer container)
		{
			if (container == null)
			{
				throw new ArgumentNullException("container");
			}

			_container = container;
		}

		public void Dispatch<T>(T command) 
			where T : class, ICommand
		{
			if (command == null)
			{
				throw new ArgumentNullException("command");
			}

			var handler = _container.Resolve<ICommandHandler<T>>();
			if (handler == null)
			{
				throw new NoHandlerForCommandException(string.Format("Handler for the {0} command is not found.", typeof(T).Name));
			}

			handler.Handle(command);
		}
	}
}