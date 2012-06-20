// Type: System.Windows.Data.ObjectDataProvider
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\PresentationFramework.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;

namespace System.Windows.Data
{
	/// <summary>
	/// Wraps and creates an object that you can use as a binding source.
	/// </summary>
	[Localizability(LocalizationCategory.NeverLocalize)]
	public class ObjectDataProvider : DataSourceProvider
	{
		/// <summary>
		/// Indicates whether the <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectType"/> property should be persisted.
		/// </summary>
		/// 
		/// <returns>
		/// true if the property value has changed from its default; otherwise, false.
		/// </returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeObjectType();

		/// <summary>
		/// Indicates whether the <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectInstance"/> property should be persisted.
		/// </summary>
		/// 
		/// <returns>
		/// true if the property value has changed from its default; otherwise, false.
		/// </returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeObjectInstance();

		/// <summary>
		/// Indicates whether the <see cref="P:System.Windows.Data.ObjectDataProvider.ConstructorParameters"/> property should be persisted.
		/// </summary>
		/// 
		/// <returns>
		/// true if the property value has changed from its default; otherwise, false.
		/// </returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeConstructorParameters();

		/// <summary>
		/// Indicates whether the <see cref="P:System.Windows.Data.ObjectDataProvider.MethodParameters"/> property should be persisted.
		/// </summary>
		/// 
		/// <returns>
		/// true if the property value has changed from its default; otherwise, false.
		/// </returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShouldSerializeMethodParameters();

		/// <summary>
		/// Starts to create the requested object, either immediately or on a background thread, based on the value of the <see cref="P:System.Windows.Data.ObjectDataProvider.IsAsynchronous"/> property.
		/// </summary>
		protected override void BeginQuery();

		/// <summary>
		/// Gets or sets the type of object to create an instance of.
		/// </summary>
		/// 
		/// <returns>
		/// This property is null when the <see cref="T:System.Windows.Data.ObjectDataProvider"/> is uninitialized or explicitly set to null. If <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectInstance"/> is assigned, <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectType"/> returns the type of the object or null if the object is null. The default value is null.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException"><see cref="T:System.Windows.Data.ObjectDataProvider"/> is assigned both an <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectType"/> and an <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectInstance"/>; only one is allowed.</exception>
		public Type ObjectType { get; set; }

		/// <summary>
		/// Gets or sets the object used as the binding source.
		/// </summary>
		/// 
		/// <returns>
		/// The instance of the object constructed from <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectType"/> and <see cref="P:System.Windows.Data.ObjectDataProvider.ConstructorParameters"/>, or the <see cref="T:System.Windows.Data.DataSourceProvider"/> of which the <see cref="P:System.Windows.Data.DataSourceProvider.Data"/> is used as the <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectInstance"/>.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException"><see cref="T:System.Windows.Data.ObjectDataProvider"/> is assigned both an <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectType"/> and an <see cref="P:System.Windows.Data.ObjectDataProvider.ObjectInstance"/>; only one is allowed.</exception>
		public object ObjectInstance { get; set; }

		/// <summary>
		/// Gets or sets the name of the method to call.
		/// </summary>
		/// 
		/// <returns>
		/// The name of the method to call. The default value is null.
		/// </returns>
		[DefaultValue(null)]
		public string MethodName { get; set; }

		/// <summary>
		/// Gets the list of parameters to pass to the constructor.
		/// </summary>
		/// 
		/// <returns>
		/// The list of parameters to pass to the constructor. The default value is null.
		/// </returns>
		public IList ConstructorParameters { get; }

		/// <summary>
		/// Gets the list of parameters to pass to the method.
		/// </summary>
		/// 
		/// <returns>
		/// The list of parameters to pass to the method. The default is an empty list.
		/// </returns>
		public IList MethodParameters { get; }

		/// <summary>
		/// Gets or sets a value that indicates whether to perform object creation in a worker thread or in the active context.
		/// </summary>
		/// 
		/// <returns>
		/// true to perform object creation in a worker thread; otherwise, false. The default is false.
		/// </returns>
		[DefaultValue(false)]
		public bool IsAsynchronous { get; set; }
	}
}
