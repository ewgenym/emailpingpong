using System.Data.Entity;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EmailPingPong.Core.CommandHandlers;
using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Services;
using EmailPingPong.Core.Services.Implementation;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Repositories;
using EmailPingPong.Infrastructure.Transactions;
using EmailPingPong.Outlook.Common.Word;
using EmailPingPong.UI.Desktop.ViewModels;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Outlook.Common.Configuration
{
	public abstract class EmailPingPongOutlookAddInConfigurator : IOutlookAddInConfigurator
	{
		private readonly IWindsorContainer _container;

		public EmailPingPongOutlookAddInConfigurator(IWindsorContainer container)
		{
			_container = container;
		}

		protected IWindsorContainer Container
		{
			get { return _container; }
		}

		public void Configure()
		{
			ConfigureEntityFramework();
			ConfigureRepositories();
			ConfigureServices();
			ConfigureConsumerUnitOfWorkInterceptor();
			ConfigureCommandHandlers();
			ConfigureEventHandlers();
			ConfigureEventAggregator();
			ConfigureBinders();
			ConfigureConversationTree();
			ConfigureConversationTreeStarter();
			ConfigureConversationMonitor();
			ConfigureKeyInterceptorStarter();
			ConfigureControllers();
		}

		private void ConfigureServices()
		{
			_container.Register(Component.For<IMergeConversationService>().ImplementedBy<MergeConversationService>());
		}

		private void ConfigureKeyInterceptorStarter()
		{
			_container.Register(Component.For<IKeyInterceptorStarter>().ImplementedBy<KeyInterceptorStarter>());
		}

		protected virtual void ConfigureControllers()
		{
		}

		protected abstract void ConfigureConversationMonitor();

		private void ConfigureEventAggregator()
		{
			_container.Register(Component.For<IEventAggregator>().ImplementedBy<EventAggregator>());
		}

		private void ConfigureConsumerUnitOfWorkInterceptor()
		{
			Container.Kernel.ProxyFactory.AddInterceptorSelector(new ConsumerUnitOfWorkInterceptorSelector());
			Container.Register(Component.For<UnitOfWorkInterceptor>().LifeStyle.Transient);
		}

		private void ConfigureRepositories()
		{
			_container.Register(Component.For<IConnectionStringProvider>().ImplementedBy<SimpleConnectionStringProvider>());
			_container.Register(Component.For<DbContext, ConversationContext>().ImplementedBy<ConversationContext>());
			_container.Register(Component.For<IConversationRepository>().ImplementedBy<ConversationRepository>());

			_container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(DbRepository<>)));
		}

		private void ConfigureCommandHandlers()
		{
			_container.Register(Component.For<ICommandDispatcher>().ImplementedBy<CommandDispatcher>());
			_container.Register(Component.For<ICommandHandler<MergeConversation>, ICommandHandler<UpdateMailItem>, ICommandHandler<RemoveConversation>>()
				.ImplementedBy<ConversationCommandHandlers>());
		}

		private void ConfigureEventHandlers()
		{
		}

		protected virtual void ConfigureBinders()
		{
			Container.Register(Component.For<IConversationParser>().ImplementedBy<ConversationParser>());
		}

		protected virtual void ConfigureEntityFramework()
		{
			var configurator = new EntityFrameworkConfigurator();
			configurator.ConfigureEntityFramework();
		}

		private void ConfigureConversationTree()
		{
			_container.Register(Component.For<IConversationTreeItemsBinder>().ImplementedBy<ConversationTreeItemsBinder>());
			_container.Register(Component.For<ConversationTreeViewModel>().ImplementedBy<ConversationTreeViewModel>());
		}

		protected abstract void ConfigureConversationTreeStarter();
	}

	public class SimpleConnectionStringProvider : IConnectionStringProvider
	{
		public string ConnectionString
		{
			//get { return "Data Source=c:\\Projects\\emailpingpong\\Source\\EmailPingPong.Tests\\emailpingpong.sdf"; }
			get { return "Data Source=c:\\Projects\\emailpingpong\\Source\\emailpingpong.sdf"; }
		}
	}
}