using System.Data.Entity;
using EmailPingPong.Core.Domain;

namespace EmailPingPong.Infrastructure.Repositories
{
	public class ConversationContext : DbContext
	{
		public ConversationContext(IConnectionStringProvider connectionStringProvider)
			: base(connectionStringProvider.ConnectionString)
		{
		}

		public DbSet<Comment> Comments { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Comment>()
				.HasOptional(c => c.Parent)
				.WithMany(c => c.Comments)
				.HasForeignKey(c => c.ParentId);
		}
	}
}