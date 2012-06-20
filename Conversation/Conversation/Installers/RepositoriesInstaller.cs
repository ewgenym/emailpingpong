using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Conversation.Infrastructure;
using Conversation.Infrastructure.Repositories;
using Conversation.Infrastructure.Repositories.Implementation;

namespace Conversation.Installers
{
	public class RepositoriesInstaller : IWindsorInstaller
	{
		#region Implementation of IWindsorInstaller

		/// <summary>
		/// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer"/>.
		/// </summary>
		/// <param name="container">The container.</param><param name="store">The configuration store.</param>
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Component.For<IConnectionStringProvider>().ImplementedBy<OutlookConnectionStringProvider>());
			container.Register(Component.For<ConversationContext>().ImplementedBy<ConversationContext>().LifestyleSingleton());
			container.Register(Component.For<ICommentRepository>().ImplementedBy<CommentRepository>());
		}

		#endregion
	}
}
