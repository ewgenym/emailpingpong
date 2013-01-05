using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EmailPingPong.Outlook.Common.Configuration;

namespace EmailPingPong.Outlook.Common
{
	public class OutlookAddInBootstrapper : IAddInBootstrapper
	{
		private WindsorContainer _container;

		public void Startup()
		{
			_container = new WindsorContainer();
			_container.Register(Component.For<IWindsorContainer>().Instance(_container));
			var addInConfigurator = _container.Resolve<IOutlookAddInConfigurator>();
			addInConfigurator.Configure();
		}

		public void Shutdown()
		{
			_container.Dispose();
			_container = null;
		}
	}

	public interface IAddInBootstrapper
	{
		void Startup();
		void Shutdown();
	}
}