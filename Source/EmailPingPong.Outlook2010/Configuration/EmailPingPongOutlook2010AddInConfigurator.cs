using Castle.MicroKernel.Registration;
using Castle.Windsor;
using EmailPingPong.Infrastructure;
using EmailPingPong.Outlook.Common.Configuration;
using EmailPingPong.Outlook.Common.Controllers;
using EmailPingPong.Outlook.Common.Conversation;
using EmailPingPong.Outlook.Common.Word;
using EmailPingPong.Outlook2010.Controllers;
using EmailPingPong.Outlook2010.Services;

namespace EmailPingPong.Outlook2010.Configuration
{
	public class EmailPingPongOutlook2010AddInConfigurator : EmailPingPongOutlookAddInConfigurator
	{
		public EmailPingPongOutlook2010AddInConfigurator(IWindsorContainer container)
			: base(container)
		{
		}

		protected override void ConfigureConversationTreeStarter()
		{
			Container.Register(Component.For<IConversationTreeStarter>().ImplementedBy<Outlook2010ConversationTreeStarter>());
		}

		protected override void ConfigureConversationMonitor()
		{
			Container.Register(Component.For<IOutlookConversationMonitor>().ImplementedBy<Outlook2010ConversationMonitor>());
		}

		protected override void ConfigureBinders()
		{
			base.ConfigureBinders();

			Container.Register(Component.For<IFolderBinder>().ImplementedBy<FolderBinder>());
			Container.Register(Component.For<IEmailItemBinder>().ImplementedBy<EmailItemBinder>());
			Container.Register(Component.For<IConversationBinder>().ImplementedBy<ConversationBinder>());
			Container.Register(Component.For<IConversationMetadataTracker>().ImplementedBy<ConversationMetadataTracker>());
		}
		protected override void ConfigureConnectionStringProvider()
		{
			Container.Register(Component.For<IConnectionStringProvider>().ImplementedBy<OutlookConnectionStringProvider>());
		}

		protected override void ConfigureControllers()
		{
			base.ConfigureControllers();

			Container.Register(Component.For<IInspectorController>().ImplementedBy<InspectorController>());
		}
	}
}