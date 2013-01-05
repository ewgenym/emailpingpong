using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EmailPingPong.Infrastructure.Repositories;

namespace EmailPingPong.Outlook.Common.Configuration
{
	public class EntityFrameworkConfigurator
	{
		public void ConfigureEntityFramework()
		{
			Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ConversationContext>());
		}
	}
}