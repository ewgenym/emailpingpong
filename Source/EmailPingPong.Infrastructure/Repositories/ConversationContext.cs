using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Infrastructure.Repositories
{
	public class ConversationContext : DbContext
	{
		public ConversationContext(IConnectionStringProvider connectionStringProvider)
			: base(connectionStringProvider.ConnectionString)
		{
			Configuration.LazyLoadingEnabled = false;
		}

		public DbSet<Comment> Comments { get; set; }

		public DbSet<EmailItem> EmailItems { get; set; }

		public DbSet<Conversation> Conversations { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Conversation>()
						.HasKey(c => c.Id);

			modelBuilder.Entity<Conversation>()
						.Property(c => c.Id)
						.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			modelBuilder.Entity<Comment>()
						.HasKey(c => c.Id);

			modelBuilder.Entity<Comment>()
						.Property(c => c.Id)
						.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			modelBuilder.Entity<EmailItem>()
						.HasKey(m => m.Id);
			modelBuilder.Entity<EmailItem>()
						.Property(c => c.Id)
						.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			modelBuilder.Entity<Conversation>()
						.HasMany(c => c.Comments)
						.WithOptional()
						.WillCascadeOnDelete(true);

			modelBuilder.Entity<Conversation>()
						.HasMany(c => c.Emails)
						.WithOptional()
						.WillCascadeOnDelete(true);

			modelBuilder.Entity<Comment>()
						.HasMany(c => c.Answers)
						.WithOptional(c => c.Parent)
						.Map(c => c.MapKey("ParentId"));

			modelBuilder.Entity<Comment>()
			            .HasOptional(c => c.OriginalEmail);
		}
	}
}