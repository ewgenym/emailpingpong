using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using EmailPingPong.Infrastructure;
using EmailPingPong.Outlook.Common.Configuration;
using EmailPingPong.Outlook.Common.Conversation;

namespace EmailPingPong.Outlook.Common
{
	public class OutlookAddInBootstrapper : IAddInBootstrapper
	{
		private WindsorContainer _container;
		private IOutlookConversationMonitor _conversationMonitor;

		public void Startup()
		{
			_container = new WindsorContainer(new XmlInterpreter());
			_container.Register(Component.For<IWindsorContainer>().Instance(_container));
			ServiceLocator.Container = _container;
			var addInConfigurator = _container.Resolve<IOutlookAddInConfigurator>();
			addInConfigurator.Configure();

			StartConversationTree();
			StartConversationMonitor();
			StartKeyInterceptor();
		}

		public void Shutdown()
		{
			StopKeyInterceptor();
			StopConversationMonitor();

			_container.Dispose();
			_container = null;
		}

		private void StartKeyInterceptor()
		{
			_container.Resolve<IKeyInterceptorStarter>().Start();
		}

		private void StartConversationTree()
		{
			_container.Resolve<IConversationTreeStarter>().Start();
		}

		private void StartConversationMonitor()
		{
			_conversationMonitor = _container.Resolve<IOutlookConversationMonitor>();
			_conversationMonitor.StartWatch();
		}

		private void StopConversationMonitor()
		{
			_conversationMonitor.StopWatch();
		}

		private void StopKeyInterceptor()
		{
			_container.Resolve<IKeyInterceptorStarter>().Stop();
		}
	}

	public interface IAddInBootstrapper
	{
		void Startup();
		void Shutdown();
	}
}