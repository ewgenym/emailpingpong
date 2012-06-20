// Type: System.Data.EntityClient.EntityConnectionStringBuilder
// Assembly: System.Data.Entity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.Entity.dll

using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime;

namespace System.Data.EntityClient
{
	/// <summary>
	/// Provides a simple way to create and manage the contents of connection strings used by the EntityClient.
	/// </summary>
	public sealed class EntityConnectionStringBuilder : DbConnectionStringBuilder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> class.
		/// </summary>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public EntityConnectionStringBuilder();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> class using the supplied connection string.
		/// </summary>
		/// <param name="connectionString">A provider-specific connection string to the underlying data source.</param>
		public EntityConnectionStringBuilder(string connectionString);

		/// <summary>
		/// Clears the contents of the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> instance.
		/// </summary>
		public override void Clear();

		/// <summary>
		/// Determines whether the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> contains a specific key.
		/// </summary>
		/// 
		/// <returns>
		/// Returns true if the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> contains an element that has the specified key; otherwise, false.
		/// </returns>
		/// <param name="keyword">The key to locate in the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/>.</param>
		public override bool ContainsKey(string keyword);

		/// <summary>
		/// Retrieves a value corresponding to the supplied key from this <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/>.
		/// </summary>
		/// 
		/// <returns>
		/// Returns true if <paramref name="keyword"/> was found in the connection string; otherwise, false.
		/// </returns>
		/// <param name="keyword">The key of the item to retrieve.</param><param name="value">The value corresponding to <paramref name="keyword."/></param><exception cref="T:System.ArgumentNullException"><paramref name="keyword"/> contains a null value (Nothing in Visual Basic).</exception>
		public override bool TryGetValue(string keyword, out object value);

		/// <summary>
		/// Removes the entry with the specified key from the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> instance.
		/// </summary>
		/// 
		/// <returns>
		/// Returns true if the key existed in the connection string and was removed; false if the key did not exist.
		/// </returns>
		/// <param name="keyword">The key of the keyword/value pair to be removed from the connection string in this <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="keyword"/> is null (Nothing in Visual Basic)</exception>
		public override bool Remove(string keyword);

		/// <summary>
		/// Gets or sets the name of a section as defined in a configuration file.
		/// </summary>
		/// 
		/// <returns>
		/// The name of a section in a configuration file.
		/// </returns>
		[RefreshProperties(RefreshProperties.All)]
		[DisplayName("Name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the name of the underlying .NET Framework data provider in the connection string.
		/// </summary>
		/// 
		/// <returns>
		/// The invariant name of the underlying .NET Framework data provider.
		/// </returns>
		[RefreshProperties(RefreshProperties.All)]
		[DisplayName("Provider")]
		public string Provider { get; set; }

		/// <summary>
		/// Gets or sets the metadata locations in the connection string.
		/// </summary>
		/// 
		/// <returns>
		/// Gets or sets the metadata locations in the connection string.
		/// </returns>
		[RefreshProperties(RefreshProperties.All)]
		[DisplayName("Metadata")]
		public string Metadata { get; set; }

		/// <summary>
		/// Gets or sets the inner, provider-specific connection string.
		/// </summary>
		/// 
		/// <returns>
		/// The inner, provider-specific connection string.
		/// </returns>
		[DisplayName("Provider Connection String")]
		[RefreshProperties(RefreshProperties.All)]
		public string ProviderConnectionString { get; set; }

		/// <summary>
		/// Gets a value that indicates whether the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> has a fixed size.
		/// </summary>
		/// 
		/// <returns>
		/// Returns true in every case, because the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/> supplies a fixed-size collection of keyword/value pairs.
		/// </returns>
		public override bool IsFixedSize { get; }

		/// <summary>
		/// Gets an <see cref="T:System.Collections.ICollection"/> that contains the keys in the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/>.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Collections.ICollection"/> that contains the keys in the <see cref="T:System.Data.EntityClient.EntityConnectionStringBuilder"/>.
		/// </returns>
		public override ICollection Keys { get; }

		/// <summary>
		/// Gets or sets the value associated with the specified key. In C#, this property is the indexer.
		/// </summary>
		/// 
		/// <returns>
		/// The value associated with the specified key.
		/// </returns>
		/// <param name="keyword">The key of the item to get or set.</param><exception cref="T:System.ArgumentNullException"><paramref name="keyword"/> is a null reference (Nothing in Visual Basic).</exception><exception cref="T:System.Collections.Generic.KeyNotFoundException">Tried to add a key that does not exist in the available keys.</exception><exception cref="T:System.FormatException">Invalid value in the connection string (specifically, a Boolean or numeric value was expected but not supplied).</exception>
		public override object this[string keyword] { get; set; }
	}
}
