using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Conversation.Core.Domain;

namespace Conversation.Infrastructure.Repositories
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