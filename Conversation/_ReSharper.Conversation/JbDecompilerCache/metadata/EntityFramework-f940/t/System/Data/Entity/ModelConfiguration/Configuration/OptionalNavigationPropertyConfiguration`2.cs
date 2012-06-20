// Type: System.Data.Entity.ModelConfiguration.Configuration.OptionalNavigationPropertyConfiguration`2
// Assembly: EntityFramework, Version=4.3.1.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Projects\Conversation\packages\EntityFramework.4.3.1\lib\net40\EntityFramework.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	/// <summary>
	/// Configures an optional relationship from an entity type.
	/// 
	/// </summary>
	/// <typeparam name="TEntityType">The entity type that the relationship originates from.</typeparam><typeparam name="TTargetEntityType">The entity type that the relationship targets.</typeparam>
	public class OptionalNavigationPropertyConfiguration<TEntityType, TTargetEntityType> where TEntityType : class where TTargetEntityType : class
	{
		/// <summary>
		/// Configures the relationship to be optional:many with a navigation property on the other side of the relationship.
		/// 
		/// </summary>
		/// <param name="navigationPropertyExpression">An lambda expression representing the navigation property on the other end of the relationship.
		///                 C#: t =&gt; t.MyProperty
		///                 VB.Net: Function(t) t.MyProperty
		///             </param>
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
		public DependentNavigationPropertyConfiguration<TEntityType> WithMany(Expression<Func<TTargetEntityType, ICollection<TEntityType>>> navigationPropertyExpression);

		/// <summary>
		/// Configures the relationship to be optional:many without a navigation property on the other side of the relationship.
		/// 
		/// </summary>
		/// 
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		public DependentNavigationPropertyConfiguration<TEntityType> WithMany();

		/// <summary>
		/// Configures the relationship to be optional:required with a navigation property on the other side of the relationship.
		/// 
		/// </summary>
		/// <param name="navigationPropertyExpression">An lambda expression representing the navigation property on the other end of the relationship.
		///                 C#: t =&gt; t.MyProperty
		///                 VB.Net: Function(t) t.MyProperty
		///             </param>
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
		[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
		public ForeignKeyNavigationPropertyConfiguration WithRequired(Expression<Func<TTargetEntityType, TEntityType>> navigationPropertyExpression);

		/// <summary>
		/// Configures the relationship to be optional:required without a navigation property on the other side of the relationship.
		/// 
		/// </summary>
		/// 
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		public ForeignKeyNavigationPropertyConfiguration WithRequired();

		/// <summary>
		/// Configures the relationship to be optional:optional with a navigation property on the other side of the relationship.
		///                 The entity type being configured will be the dependent and contain a foreign key to the principal.
		///                 The entity type that the relationship targets will be the principal in the relationship.
		/// 
		/// </summary>
		/// <param name="navigationPropertyExpression">An lambda expression representing the navigation property on the other end of the relationship.
		///                 C#: t =&gt; t.MyProperty
		///                 VB.Net: Function(t) t.MyProperty
		///             </param>
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
		public ForeignKeyNavigationPropertyConfiguration WithOptionalDependent(Expression<Func<TTargetEntityType, TEntityType>> navigationPropertyExpression);

		/// <summary>
		/// Configures the relationship to be optional:optional without a navigation property on the other side of the relationship.
		///                 The entity type being configured will be the dependent and contain a foreign key to the principal.
		///                 The entity type that the relationship targets will be the principal in the relationship.
		/// 
		/// </summary>
		/// 
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		public ForeignKeyNavigationPropertyConfiguration WithOptionalDependent();

		/// <summary>
		/// Configures the relationship to be optional:optional with a navigation property on the other side of the relationship.
		///                 The entity type being configured will be the principal in the relationship.
		///                 The entity type that the relationship targets will be the dependent and contain a foreign key to the principal.
		/// 
		/// </summary>
		/// <param name="navigationPropertyExpression">A lambda expression representing the navigation property on the other end of the relationship.
		///             </param>
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
		public ForeignKeyNavigationPropertyConfiguration WithOptionalPrincipal(Expression<Func<TTargetEntityType, TEntityType>> navigationPropertyExpression);

		/// <summary>
		/// Configures the relationship to be optional:optional without a navigation property on the other side of the relationship.
		///                 The entity type being configured will be the principal in the relationship.
		///                 The entity type that the relationship targets will be the dependent and contain a foreign key to the principal.
		/// 
		/// </summary>
		/// 
		/// <returns>
		/// A configuration object that can be used to further configure the relationship.
		/// </returns>
		public ForeignKeyNavigationPropertyConfiguration WithOptionalPrincipal();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Type GetType();
	}
}
