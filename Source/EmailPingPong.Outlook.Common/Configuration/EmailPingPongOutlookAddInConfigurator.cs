using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EmailPingPong.Core.CommandHandlers;
using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Events;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Repositories;

namespace EmailPingPong.Outlook.Common.Configuration
{
	public class EmailPingPongOutlookAddInConfigurator : IOutlookAddInConfigurator
	{
		private readonly IWindsorContainer _container;

		public EmailPingPongOutlookAddInConfigurator(IWindsorContainer container)
		{
			_container = container;
		}

		public void Configure()
		{
			ConfigureEntityFramework();
			ConfigureRepositories();
			ConfigureCommandHandlers();
			ConfigureEventHandlers();
		}

		private void ConfigureRepositories()
		{
			_container.Register(Component.For<IConnectionStringProvider>().ImplementedBy<SimpleConnectionStringProvider>());
			_container.Register(Component.For<ConversationContext>());
			_container.Register(Component.For<IConversationRepository>().ImplementedBy<ConversationRepository>());
		}

		private void ConfigureCommandHandlers()
		{
			_container.Register(Component.For<ICommandHandler<MergeConversation>>().ImplementedBy<ConversationCommandHandlers>());
		}

		private void ConfigureEventHandlers()
		{
			//_container.Register(AllTypes.FromThisAssembly().BasedOn<IEventHandler<ConversationCreated>>());
			//_container.Register(AllTypes.FromThisAssembly().BasedOn<IEventHandler<ConversationMerged>>());
		}

		protected virtual void ConfigureEntityFramework()
		{
			var configurator = new EntityFrameworkConfigurator();
			configurator.ConfigureEntityFramework();
		}
	}

	public class SimpleConnectionStringProvider : IConnectionStringProvider
	{
		public string ConnectionString
		{
			get { return "Data Source=c:\\Projects\\emailpingpong\\Source\\emailpingpong.sdf"; }
		}
	}
}