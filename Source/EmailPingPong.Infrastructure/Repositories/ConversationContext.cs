using System.Data.Entity;
using EmailPingPong.Core.Model;
using Comment = EmailPingPong.Core.Domain.Comment;

namespace EmailPingPong.Infrastructure.Repositories
{
	public class ConversationContext : DbContext
	{
		public ConversationContext(IConnectionStringProvider connectionStringProvider)
			: base(connectionStringProvider.ConnectionString)
		{
		}

		public DbSet<Comment> Comments { get; set; }

		public DbSet<Conversation> Conversations { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Comment>()
				.HasOptional(c => c.Parent)
				.WithMany(c => c.Comments)
				.HasForeignKey(c => c.ParentId);
		}
	}
}