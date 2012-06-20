// Type: System.Data.Entity.DbSet`1
// Assembly: EntityFramework, Version=4.3.1.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Projects\Conversation\packages\EntityFramework.4.3.1\lib\net40\EntityFramework.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace System.Data.Entity
{
	/// <summary>
	/// A DbSet represents the collection of all entities in the context, or that can be queried from the
	///                 database, of a given type.  DbSet objects are created from a DbContext using the DbContext.Set method.
	/// 
	/// </summary>
	/// 
	/// <remarks>
	/// Note that DbSet does not support MEST (Multiple Entity Sets per Type) meaning that there is always a
	///                 one-to-one correlation between a type and a set.
	/// 
	/// </remarks>
	/// <typeparam name="TEntity">The type that defines the set.</typeparam>
	[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Justification = "Name is intentional")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "Casing is intentional")]
	public class DbSet<TEntity> : DbQuery<TEntity>, IDbSet<TEntity>, IQueryable<TEntity>, IEnumerable<TEntity>, IQueryable, IEnumerable, IInternalSetAdapter where TEntity : class
	{
		/// <summary>
		/// Returns the equivalent non-generic <see cref="T:System.Data.Entity.DbSet"/> object.
		/// 
		/// </summary>
		/// 
		/// <returns>
		/// The non-generic set object.
		/// </returns>
		[SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates", Justification = "Intentionally just implicit to reduce API clutter.")]
		public static implicit operator DbSet(DbSet<TEntity> entry);

		/// <summary>
		/// Finds an entity with the given primary key values.
		///                 If an entity with the given primary key values exists in the context, then it is
		///                 returned immediately without making a request to the store.  Otherwise, a request
		///                 is made to the store for an entity with the given primary key values and this entity,
		///                 if found, is attached to the context and returned.  If no entity is found in the
		///                 context or the store, then null is returned.
		/// 
		/// </summary>
		/// 
		/// <remarks>
		/// The ordering of composite key values is as defined in the EDM, which is in turn as defined in
		///                 the designer, by the Code First fluent API, or by the DataMember attribute.
		/// 
		/// </remarks>
		/// <param name="keyValues">The values of the primary key for the entity to be found.</param>
		/// <returns>
		/// The entity found, or null.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException">Thrown if multiple entities exist in the context with the primary key values given.</exception><exception cref="T:System.InvalidOperationException">Thrown if the type of entity is not part of the data model for this context.</exception><exception cref="T:System.InvalidOperationException">Thrown if the types of the key values do not match the types of the key values for the entity type to be found.</exception><exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
		public TEntity Find(params object[] keyValues);

		/// <summary>
		/// Attaches the given entity to the context underlying the set.  That is, the entity is placed
		///                 into the context in the Unchanged state, just as if it had been read from the database.
		/// 
		/// </summary>
		/// <param name="entity">The entity to attach.</param>
		/// <returns>
		/// The entity.
		/// </returns>
		/// 
		/// <remarks>
		/// Attach is used to repopulate a context with an entity that is known to already exist in the database.
		///                 SaveChanges will therefore not attempt to insert an attached entity into the database because
		///                 it is assumed to already be there.
		///                 Note that entities that are already in the context in some other state will have their state set
		///                 to Unchanged.  Attach is a no-op if the entity is already in the context in the Unchanged state.
		/// 
		/// </remarks>
		public TEntity Attach(TEntity entity);

		/// <summary>
		/// Adds the given entity to the context underlying the set in the Added state such that it will
		///                 be inserted into the database when SaveChanges is called.
		/// 
		/// </summary>
		/// <param name="entity">The entity to add.</param>
		/// <returns>
		/// The entity.
		/// </returns>
		/// 
		/// <remarks>
		/// Note that entities that are already in the context in some other state will have their state set
		///                 to Added.  Add is a no-op if the entity is already in the context in the Added state.
		/// 
		/// </remarks>
		public TEntity Add(TEntity entity);

		/// <summary>
		/// Marks the given entity as Deleted such that it will be deleted from the database when SaveChanges
		///                 is called.  Note that the entity must exist in the context in some other state before this method
		///                 is called.
		/// 
		/// </summary>
		/// <param name="entity">The entity to remove.</param>
		/// <returns>
		/// The entity.
		/// </returns>
		/// 
		/// <remarks>
		/// Note that if the entity exists in the context in the Added state, then this method
		///                 will cause it to be detached from the context.  This is because an Added entity is assumed not to
		///                 exist in the database such that trying to delete it does not make sense.
		/// 
		/// </remarks>
		public TEntity Remove(TEntity entity);

		/// <summary>
		/// Creates a new instance of an entity for the type of this set.
		///                 Note that this instance is NOT added or attached to the set.
		///                 The instance returned will be a proxy if the underlying context is configured to create
		///                 proxies and the entity type meets the requirements for creating a proxy.
		/// 
		/// </summary>
		/// 
		/// <returns>
		/// The entity instance, which may be a proxy.
		/// </returns>
		public TEntity Create();

		/// <summary>
		/// Creates a new instance of an entity for the type of this set or for a type derived
		///                 from the type of this set.
		///                 Note that this instance is NOT added or attached to the set.
		///                 The instance returned will be a proxy if the underlying context is configured to create
		///                 proxies and the entity type meets the requirements for creating a proxy.
		/// 
		/// </summary>
		/// <typeparam name="TDerivedEntity">The type of entity to create.</typeparam>
		/// <returns>
		/// The entity instance, which may be a proxy.
		/// </returns>
		public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, TEntity;

		/// <summary>
		/// Creates a raw SQL query that will return entities in this set.  By default, the
		///                 entities returned are tracked by the context; this can be changed by calling
		///                 AsNoTracking on the <see cref="T:System.Data.Entity.Infrastructure.DbSqlQuery`1"/> returned.
		///                 Note that the entities returned are always of the type for this set and never of
		///                 a derived type.  If the table or tables queried may contain data for other entity
		///                 types, then the SQL query must be written appropriately to ensure that only entities of
		///                 the correct type are returned.
		/// 
		/// </summary>
		/// <param name="sql">The SQL query string.</param><param name="parameters">The parameters to apply to the SQL query string.</param>
		/// <returns>
		/// A <see cref="T:System.Data.Entity.Infrastructure.DbSqlQuery`1"/> object that will execute the query when it is enumerated.
		/// </returns>
		public DbSqlQuery<TEntity> SqlQuery(string sql, params object[] parameters);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Type GetType();

		/// <summary>
		/// Gets an <see cref="T:System.Collections.ObjectModel.ObservableCollection`1"/> that represents a local view of all Added, Unchanged,
		///                 and Modified entities in this set.  This local view will stay in sync as entities are added or
		///                 removed from the context.  Likewise, entities added to or removed from the local view will automatically
		///                 be added to or removed from the context.
		/// 
		/// </summary>
		/// 
		/// <remarks>
		/// This property can be used for data binding by populating the set with data, for example by using the Load
		///                 extension method, and then binding to the local data through this property.  For WPF bind to this property
		///                 directly.  For Windows Forms bind to the result of calling ToBindingList on this property
		/// 
		/// </remarks>
		/// 
		/// <value>
		/// The local view.
		/// </value>
		public ObservableCollection<TEntity> Local { get; }
	}
}
