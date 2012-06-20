using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;

namespace Conversation.Infrastructure.Configuration.Implementation
{
	public abstract class GenericApplicationConfigurator : IApplicationConfigurator
	{
		private readonly IWindsorContainer _container;

		public GenericApplicationConfigurator(IWindsorContainer container)
		{
			_container = container;
		}

		protected IWindsorContainer Container
		{
			get { return _container; }
		}

		public virtual void Configure()
		{
		}
	}
}