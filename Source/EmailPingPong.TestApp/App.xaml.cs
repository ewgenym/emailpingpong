using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EmailPingPong.Infrastructure;
using EmailPingPong.Outlook.Common.Configuration;
using EmailPingPong.UI.Desktop.ViewModels;

namespace EmailPingPong.TestApp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private WindsorContainer _container;

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			_container = new WindsorContainer();
			_container.Register(Component.For<IWindsorContainer>().Instance(_container));
			ServiceLocator.Container = _container;
			_container.Register(Component.For<IOutlookAddInConfigurator>().ImplementedBy<EmailPingPongOutlookAddInConfigurator>());

			var addInConfigurator = _container.Resolve<IOutlookAddInConfigurator>();
			addInConfigurator.Configure();

			_container.Register(Component.For<IConversationTreeItemsBinder>().ImplementedBy<ConversationTreeItemsBinder>());
			_container.Register(Component.For<ConversationTreeViewModel>().ImplementedBy<ConversationTreeViewModel>());
		}
	}
}
