// Type: System.Windows.Forms.BindingSource
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

namespace System.Windows.Forms
{
	/// <summary>
	/// Encapsulates the data source for a form.
	/// </summary>
	[DefaultProperty("DataSource")]
	[DefaultEvent("CurrentChanged")]
	[Designer("System.Windows.Forms.Design.BindingSourceDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[ComplexBindingProperties("DataSource", "DataMember")]
	public class BindingSource : Component, IBindingListView, IBindingList, IList, ICollection, IEnumerable, ITypedList, ICancelAddNew, ISupportInitializeNotification, ISupportInitialize, ICurrencyManagerProvider
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingSource"/> class to the default property values.
		/// </summary>
		public BindingSource();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingSource"/> class with the specified data source and data member.
		/// </summary>
		/// <param name="dataSource">The data source for the <see cref="T:System.Windows.Forms.BindingSource"/>.</param><param name="dataMember">The specific column or list name within the data source to bind to.</param>
		public BindingSource(object dataSource, string dataMember);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingSource"/> class and adds the <see cref="T:System.Windows.Forms.BindingSource"/> to the specified container.
		/// </summary>
		/// <param name="container">The <see cref="T:System.ComponentModel.IContainer"/> to add the current <see cref="T:System.Windows.Forms.BindingSource"/> to.</param>
		public BindingSource(IContainer container);

		/// <summary>
		/// Gets the related currency manager for the specified data member.
		/// </summary>
		/// 
		/// <returns>
		/// The related <see cref="T:System.Windows.Forms.CurrencyManager"/> for the specified data member.
		/// </returns>
		/// <param name="dataMember">The name of column or list, within the data source to retrieve the currency manager for.</param>
		public virtual CurrencyManager GetRelatedCurrencyManager(string dataMember);

		/// <summary>
		/// Cancels the current edit operation.
		/// </summary>
		public void CancelEdit();

		/// <summary>
		/// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.BindingSource"/> and optionally releases the managed resources.
		/// </summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing);

		/// <summary>
		/// Applies pending changes to the underlying data source.
		/// </summary>
		public void EndEdit();

		/// <summary>
		/// Returns the index of the item in the list with the specified property name and value.
		/// </summary>
		/// 
		/// <returns>
		/// The zero-based index of the item with the specified property name and value.
		/// </returns>
		/// <param name="propertyName">The name of the property to search for.</param><param name="key">The value of the item with the specified <paramref name="propertyName"/> to find.</param><exception cref="T:System.InvalidOperationException">The underlying list is not a <see cref="T:System.ComponentModel.IBindingList"/> with searching functionality implemented.</exception><exception cref="T:System.ArgumentException"><paramref name="propertyName"/> does not match a property in the list.</exception>
		public int Find(string propertyName, object key);

		/// <summary>
		/// Moves to the first item in the list.
		/// </summary>
		public void MoveFirst();

		/// <summary>
		/// Moves to the last item in the list.
		/// </summary>
		public void MoveLast();

		/// <summary>
		/// Moves to the next item in the list.
		/// </summary>
		public void MoveNext();

		/// <summary>
		/// Moves to the previous item in the list.
		/// </summary>
		public void MovePrevious();

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.AddingNew"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
		protected virtual void OnAddingNew(AddingNewEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.BindingComplete"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.BindingCompleteEventArgs"/>  that contains the event data. </param>
		protected virtual void OnBindingComplete(BindingCompleteEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.CurrentChanged"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
		protected virtual void OnCurrentChanged(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.CurrentItemChanged"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
		protected virtual void OnCurrentItemChanged(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.DataError"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.BindingManagerDataErrorEventArgs"/> that contains the event data. </param>
		protected virtual void OnDataError(BindingManagerDataErrorEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.DataMemberChanged"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
		protected virtual void OnDataMemberChanged(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.DataSourceChanged"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
		protected virtual void OnDataSourceChanged(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.ListChanged"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
		protected virtual void OnListChanged(ListChangedEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.BindingSource.PositionChanged"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs"/> that contains the event data.</param>
		protected virtual void OnPositionChanged(EventArgs e);

		/// <summary>
		/// Removes the current item from the list.
		/// </summary>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Windows.Forms.BindingSource.AllowRemove"/> property is false.-or-<see cref="P:System.Windows.Forms.BindingSource.Position"/> is less than zero or greater than <see cref="P:System.Windows.Forms.BindingSource.Count"/>.</exception><exception cref="T:System.NotSupportedException">The underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property is read-only or has a fixed size.</exception>
		public void RemoveCurrent();

		/// <summary>
		/// Reinitializes the <see cref="P:System.Windows.Forms.BindingSource.AllowNew"/> property.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public virtual void ResetAllowNew();

		/// <summary>
		/// Causes a control bound to the <see cref="T:System.Windows.Forms.BindingSource"/> to reread all the items in the list and refresh their displayed values.
		/// </summary>
		/// <param name="metadataChanged">true if the data schema has changed; false if only values have changed.</param>
		public void ResetBindings(bool metadataChanged);

		/// <summary>
		/// Causes a control bound to the <see cref="T:System.Windows.Forms.BindingSource"/> to reread the currently selected item and refresh its displayed value.
		/// </summary>
		public void ResetCurrentItem();

		/// <summary>
		/// Causes a control bound to the <see cref="T:System.Windows.Forms.BindingSource"/> to reread the item at the specified index, and refresh its displayed value.
		/// </summary>
		/// <param name="itemIndex">The zero-based index of the item that has changed.</param>
		public void ResetItem(int itemIndex);

		/// <summary>
		/// Resumes data binding.
		/// </summary>
		public void ResumeBinding();

		/// <summary>
		/// Suspends data binding to prevent changes from updating the bound data source.
		/// </summary>
		public void SuspendBinding();

		/// <summary>
		/// Signals the <see cref="T:System.Windows.Forms.BindingSource"/> that initialization is starting.
		/// </summary>
		void ISupportInitialize.BeginInit();

		/// <summary>
		/// Signals the <see cref="T:System.Windows.Forms.BindingSource"/> that initialization is complete.
		/// </summary>
		void ISupportInitialize.EndInit();

		/// <summary>
		/// Retrieves an enumerator for the <see cref="P:System.Windows.Forms.BindingSource.List"/>.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator"/> for the <see cref="P:System.Windows.Forms.BindingSource.List"/>.
		/// </returns>
		public virtual IEnumerator GetEnumerator();

		/// <summary>
		/// Copies the contents of the <see cref="P:System.Windows.Forms.BindingSource.List"/> to the specified array, starting at the specified index value.
		/// </summary>
		/// <param name="arr">The destination array.</param><param name="index">The index in the destination array at which to start the copy operation.</param>
		public virtual void CopyTo(Array arr, int index);

		/// <summary>
		/// Adds an existing item to the internal list.
		/// </summary>
		/// 
		/// <returns>
		/// The zero-based index at which <paramref name="value"/> was added to the underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property.
		/// </returns>
		/// <param name="value">An <see cref="T:System.Object"/> to be added to the internal list.</param><exception cref="T:System.InvalidOperationException"><paramref name="value"/> differs in type from the existing items in the underlying list.</exception>
		public virtual int Add(object value);

		/// <summary>
		/// Removes all elements from the list.
		/// </summary>
		public virtual void Clear();

		/// <summary>
		/// Determines whether an object is an item in the list.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <paramref name="value"/> parameter is found in the <see cref="P:System.Windows.Forms.BindingSource.List"/>; otherwise, false.
		/// </returns>
		/// <param name="value">The <see cref="T:System.Object"/> to locate in the underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property. The value can be null. </param>
		public virtual bool Contains(object value);

		/// <summary>
		/// Searches for the specified object and returns the index of the first occurrence within the entire list.
		/// </summary>
		/// 
		/// <returns>
		/// The zero-based index of the first occurrence of the <paramref name="value"/> parameter; otherwise, -1 if <paramref name="value"/> is not in the list.
		/// </returns>
		/// <param name="value">The <see cref="T:System.Object"/> to locate in the underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property. The value can be null. </param>
		public virtual int IndexOf(object value);

		/// <summary>
		/// Inserts an item into the list at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which <paramref name="value"/> should be inserted. </param><param name="value">The <see cref="T:System.Object"/> to insert. The value can be null. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> is less than zero or greater than <see cref="P:System.Windows.Forms.BindingSource.Count"/>.</exception><exception cref="T:System.NotSupportedException">The list is read-only or has a fixed size.</exception>
		public virtual void Insert(int index, object value);

		/// <summary>
		/// Removes the specified item from the list.
		/// </summary>
		/// <param name="value">The item to remove from the underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property.</param><exception cref="T:System.NotSupportedException">The underlying list has a fixed size or is read-only. </exception>
		public virtual void Remove(object value);

		/// <summary>
		/// Removes the item at the specified index in the list.
		/// </summary>
		/// <param name="index">The zero-based index of the item to remove. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> is less than zero or greater than the value of the <see cref="P:System.Windows.Forms.BindingSource.Count"/> property.</exception><exception cref="T:System.NotSupportedException">The underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property is read-only or has a fixed size.</exception>
		public virtual void RemoveAt(int index);

		/// <summary>
		/// Gets the name of the list supplying data for the binding.
		/// </summary>
		/// 
		/// <returns>
		/// The name of the list supplying the data for binding.
		/// </returns>
		/// <param name="listAccessors">An array of <see cref="T:System.ComponentModel.PropertyDescriptor"/> objects to find in the list as bindable.</param>
		public virtual string GetListName(PropertyDescriptor[] listAccessors);

		/// <summary>
		/// Retrieves an array of <see cref="T:System.ComponentModel.PropertyDescriptor"/> objects representing the bindable properties of the data source list type.
		/// </summary>
		/// 
		/// <returns>
		/// An array of <see cref="T:System.ComponentModel.PropertyDescriptor"/> objects that represents the properties on this list type used to bind data.
		/// </returns>
		/// <param name="listAccessors">An array of <see cref="T:System.ComponentModel.PropertyDescriptor"/> objects to find in the list as bindable.</param>
		public virtual PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);

		/// <summary>
		/// Adds a new item to the underlying list.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Object"/> that was created and added to the list.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Windows.Forms.BindingSource.AllowNew"/> property is set to false. -or-A public default constructor could not be found for the current item type.</exception>
		public virtual object AddNew();

		/// <summary>
		/// Adds the <see cref="T:System.ComponentModel.PropertyDescriptor"/> to the indexes used for searching.
		/// </summary>
		/// <param name="property">The <see cref="T:System.ComponentModel.PropertyDescriptor"/> to add to the indexes used for searching. </param><exception cref="T:System.NotSupportedException">The underlying list is not an <see cref="T:System.ComponentModel.IBindingList"/>.</exception>
		void IBindingList.AddIndex(PropertyDescriptor property);

		/// <summary>
		/// Sorts the data source using the specified property descriptor and sort direction.
		/// </summary>
		/// <param name="property">A <see cref="T:System.ComponentModel.PropertyDescriptor"/> that describes the property by which to sort the data source.</param><param name="sort">A <see cref="T:System.ComponentModel.ListSortDirection"/> indicating how the list should be sorted.</param><exception cref="T:System.NotSupportedException">The data source is not an <see cref="T:System.ComponentModel.IBindingList"/>.</exception>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void ApplySort(PropertyDescriptor property, ListSortDirection sort);

		/// <summary>
		/// Searches for the index of the item that has the given property descriptor.
		/// </summary>
		/// 
		/// <returns>
		/// The zero-based index of the item that has the given value for <see cref="T:System.ComponentModel.PropertyDescriptor"/>.
		/// </returns>
		/// <param name="prop">The <see cref="T:System.ComponentModel.PropertyDescriptor"/> to search for. </param><param name="key">The value of <paramref name="prop"/> to match. </param><exception cref="T:System.NotSupportedException">The underlying list is not of type <see cref="T:System.ComponentModel.IBindingList"/>.</exception>
		public virtual int Find(PropertyDescriptor prop, object key);

		/// <summary>
		/// Removes the <see cref="T:System.ComponentModel.PropertyDescriptor"/> from the indexes used for searching.
		/// </summary>
		/// <param name="prop">The <see cref="T:System.ComponentModel.PropertyDescriptor"/> to remove from the indexes used for searching.  </param>
		void IBindingList.RemoveIndex(PropertyDescriptor prop);

		/// <summary>
		/// Removes the sort associated with the <see cref="T:System.Windows.Forms.BindingSource"/>.
		/// </summary>
		/// <exception cref="T:System.NotSupportedException">The underlying list does not support sorting.</exception>
		public virtual void RemoveSort();

		/// <summary>
		/// Sorts the data source with the specified sort descriptions.
		/// </summary>
		/// <param name="sorts">A <see cref="T:System.ComponentModel.ListSortDescriptionCollection"/> containing the sort descriptions to apply to the data source.</param><exception cref="T:System.NotSupportedException">The data source is not an <see cref="T:System.ComponentModel.IBindingListView"/>.</exception>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void ApplySort(ListSortDescriptionCollection sorts);

		/// <summary>
		/// Removes the filter associated with the <see cref="T:System.Windows.Forms.BindingSource"/>.
		/// </summary>
		/// <exception cref="T:System.NotSupportedException">The underlying list does not support filtering.</exception>
		public virtual void RemoveFilter();

		/// <summary>
		/// Discards a pending new item from the collection.
		/// </summary>
		/// <param name="position">The index of the item that was added to the collection. </param>
		void ICancelAddNew.CancelNew(int position);

		/// <summary>
		/// Commits a pending new item to the collection.
		/// </summary>
		/// <param name="position">The index of the item that was added to the collection. </param>
		void ICancelAddNew.EndNew(int position);

		/// <summary>
		/// Gets the currency manager associated with this <see cref="T:System.Windows.Forms.BindingSource"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Windows.Forms.CurrencyManager"/> associated with this <see cref="T:System.Windows.Forms.BindingSource"/>.
		/// </returns>
		[Browsable(false)]
		public virtual CurrencyManager CurrencyManager { get; }

		/// <summary>
		/// Gets the current item in the list.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Object"/> that represents the current item in the underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property, or null if the list has no items.
		/// </returns>
		[Browsable(false)]
		public object Current { get; }

		/// <summary>
		/// Gets or sets the specific list in the data source to which the connector currently binds to.
		/// </summary>
		/// 
		/// <returns>
		/// The name of a list (or row) in the <see cref="P:System.Windows.Forms.BindingSource.DataSource"/>. The default is an empty string ("").
		/// </returns>
		[RefreshProperties(RefreshProperties.Repaint)]
		[Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
		[DefaultValue("")]
		public string DataMember { get; set; }

		/// <summary>
		/// Gets or sets the data source that the connector binds to.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Object"/> that acts as a data source. The default is null.
		/// </returns>
		[DefaultValue(null)]
		[RefreshProperties(RefreshProperties.Repaint)]
		[AttributeProvider(typeof (IListSource))]
		public object DataSource { get; set; }

		/// <summary>
		/// Gets a value indicating whether the list binding is suspended.
		/// </summary>
		/// 
		/// <returns>
		/// true to indicate the binding is suspended; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public bool IsBindingSuspended { get; }

		/// <summary>
		/// Gets the list that the connector is bound to.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Collections.IList"/> that represents the list, or null if there is no underlying list associated with this <see cref="T:System.Windows.Forms.BindingSource"/>.
		/// </returns>
		[Browsable(false)]
		public IList List { get; }

		/// <summary>
		/// Gets or sets the index of the current item in the underlying list.
		/// </summary>
		/// 
		/// <returns>
		/// A zero-based index that specifies the position of the current item in the underlying list.
		/// </returns>
		[DefaultValue(-1)]
		[Browsable(false)]
		public int Position { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether <see cref="E:System.Windows.Forms.BindingSource.ListChanged"/> events should be raised.
		/// </summary>
		/// 
		/// <returns>
		/// true if <see cref="E:System.Windows.Forms.BindingSource.ListChanged"/> events should be raised; otherwise, false. The default is true.
		/// </returns>
		[Browsable(false)]
		[DefaultValue(true)]
		public bool RaiseListChangedEvents { get; set; }

		/// <summary>
		/// Gets or sets the column names used for sorting, and the sort order for viewing the rows in the data source.
		/// </summary>
		/// 
		/// <returns>
		/// A case-sensitive string containing the column name followed by "ASC" (for ascending) or "DESC" (for descending). The default is null.
		/// </returns>
		[DefaultValue(null)]
		public string Sort { get; set; }

		/// <summary>
		/// Gets a value indicating whether the <see cref="T:System.Windows.Forms.BindingSource"/> is initialized.
		/// </summary>
		/// 
		/// <returns>
		/// true to indicate the <see cref="T:System.Windows.Forms.BindingSource"/> is initialized; otherwise, false.
		/// </returns>
		bool ISupportInitializeNotification.IsInitialized { get; }

		/// <summary>
		/// Gets the total number of items in the underlying list.
		/// </summary>
		/// 
		/// <returns>
		/// The total number of items in the underlying list.
		/// </returns>
		[Browsable(false)]
		public virtual int Count { get; }

		/// <summary>
		/// Gets a value indicating whether access to the collection is synchronized (thread safe).
		/// </summary>
		/// 
		/// <returns>
		/// true to indicate the list is synchronized; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool IsSynchronized { get; }

		/// <summary>
		/// Gets an object that can be used to synchronize access to the underlying list.
		/// </summary>
		/// 
		/// <returns>
		/// An object that can be used to synchronize access to the underlying list.
		/// </returns>
		[Browsable(false)]
		public virtual object SyncRoot { get; }

		/// <summary>
		/// Gets or sets the list element at the specified index.
		/// </summary>
		/// 
		/// <returns>
		/// The element at the specified index.
		/// </returns>
		/// <param name="index">The zero-based index of the element to retrieve.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> is less than zero or is equal to or greater than <see cref="P:System.Windows.Forms.BindingSource.Count"/>.</exception>
		[Browsable(false)]
		public virtual object this[int index] { get; set; }

		/// <summary>
		/// Gets a value indicating whether the underlying list has a fixed size.
		/// </summary>
		/// 
		/// <returns>
		/// true if the underlying list has a fixed size; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool IsFixedSize { get; }

		/// <summary>
		/// Gets a value indicating whether the underlying list is read-only.
		/// </summary>
		/// 
		/// <returns>
		/// true if the list is read-only; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool IsReadOnly { get; }

		/// <summary>
		/// Gets a value indicating whether items in the underlying list can be edited.
		/// </summary>
		/// 
		/// <returns>
		/// true to indicate list items can be edited; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool AllowEdit { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the <see cref="M:System.Windows.Forms.BindingSource.AddNew"/> method can be used to add items to the list.
		/// </summary>
		/// 
		/// <returns>
		/// true if <see cref="M:System.Windows.Forms.BindingSource.AddNew"/> can be used to add items to the list; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException">This property is set to true when the underlying list represented by the <see cref="P:System.Windows.Forms.BindingSource.List"/> property has a fixed size or is read-only.</exception><exception cref="T:System.MissingMethodException">The property is set to true and the <see cref="E:System.Windows.Forms.BindingSource.AddingNew"/> event is not handled when the underlying list type does not have a default constructor.</exception>
		public virtual bool AllowNew { get; set; }

		/// <summary>
		/// Gets a value indicating whether items can be removed from the underlying list.
		/// </summary>
		/// 
		/// <returns>
		/// true to indicate list items can be removed from the list; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool AllowRemove { get; }

		/// <summary>
		/// Gets a value indicating whether the data source supports change notification.
		/// </summary>
		/// 
		/// <returns>
		/// true in all cases.
		/// </returns>
		[Browsable(false)]
		public virtual bool SupportsChangeNotification { get; }

		/// <summary>
		/// Gets a value indicating whether the data source supports searching with the <see cref="M:System.Windows.Forms.BindingSource.Find(System.ComponentModel.PropertyDescriptor,System.Object)"/> method.
		/// </summary>
		/// 
		/// <returns>
		/// true if the list is a <see cref="T:System.ComponentModel.IBindingList"/> and supports the searching with the <see cref="Overload:System.Windows.Forms.BindingSource.Find"/> method; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool SupportsSearching { get; }

		/// <summary>
		/// Gets a value indicating whether the data source supports sorting.
		/// </summary>
		/// 
		/// <returns>
		/// true if the data source is an <see cref="T:System.ComponentModel.IBindingList"/> and supports sorting; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool SupportsSorting { get; }

		/// <summary>
		/// Gets a value indicating whether the items in the underlying list are sorted.
		/// </summary>
		/// 
		/// <returns>
		/// true if the list is an <see cref="T:System.ComponentModel.IBindingList"/> and is sorted; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool IsSorted { get; }

		/// <summary>
		/// Gets the <see cref="T:System.ComponentModel.PropertyDescriptor"/> that is being used for sorting the list.
		/// </summary>
		/// 
		/// <returns>
		/// If the list is an <see cref="T:System.ComponentModel.IBindingList"/>, the <see cref="T:System.ComponentModel.PropertyDescriptor"/> that is being used for sorting; otherwise, null.
		/// </returns>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual PropertyDescriptor SortProperty { get; }

		/// <summary>
		/// Gets the direction the items in the list are sorted.
		/// </summary>
		/// 
		/// <returns>
		/// One of the <see cref="T:System.ComponentModel.ListSortDirection"/> values indicating the direction the list is sorted.
		/// </returns>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual ListSortDirection SortDirection { get; }

		/// <summary>
		/// Gets the collection of sort descriptions applied to the data source.
		/// </summary>
		/// 
		/// <returns>
		/// If the data source is an <see cref="T:System.ComponentModel.IBindingListView"/>, a <see cref="T:System.ComponentModel.ListSortDescriptionCollection"/> that contains the sort descriptions applied to the list; otherwise, null.
		/// </returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public virtual ListSortDescriptionCollection SortDescriptions { get; }

		/// <summary>
		/// Gets or sets the expression used to filter which rows are viewed.
		/// </summary>
		/// 
		/// <returns>
		/// A string that specifies how rows are to be filtered. The default is null.
		/// </returns>
		[DefaultValue(null)]
		public virtual string Filter { get; set; }

		/// <summary>
		/// Gets a value indicating whether the data source supports multi-column sorting.
		/// </summary>
		/// 
		/// <returns>
		/// true if the list is an <see cref="T:System.ComponentModel.IBindingListView"/> and supports multi-column sorting; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool SupportsAdvancedSorting { get; }

		/// <summary>
		/// Gets a value indicating whether the data source supports filtering.
		/// </summary>
		/// 
		/// <returns>
		/// true if the list is an <see cref="T:System.ComponentModel.IBindingListView"/> and supports filtering; otherwise, false.
		/// </returns>
		[Browsable(false)]
		public virtual bool SupportsFiltering { get; }

		/// <summary>
		/// Occurs before an item is added to the underlying list.
		/// </summary>
		/// <exception cref="T:System.InvalidOperationException"><see cref="P:System.ComponentModel.AddingNewEventArgs.NewObject"/> is not the same type as the type contained in the list.</exception>
		public event AddingNewEventHandler AddingNew;

		/// <summary>
		/// Occurs when all the clients have been bound to this <see cref="T:System.Windows.Forms.BindingSource"/>.
		/// </summary>
		public event BindingCompleteEventHandler BindingComplete;

		/// <summary>
		/// Occurs when a currency-related exception is silently handled by the <see cref="T:System.Windows.Forms.BindingSource"/>.
		/// </summary>
		public event BindingManagerDataErrorEventHandler DataError;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.BindingSource.DataSource"/> property value has changed.
		/// </summary>
		public event EventHandler DataSourceChanged;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.BindingSource.DataMember"/> property value has changed.
		/// </summary>
		public event EventHandler DataMemberChanged;

		/// <summary>
		/// Occurs when the currently bound item changes.
		/// </summary>
		public event EventHandler CurrentChanged;

		/// <summary>
		/// Occurs when a property value of the <see cref="P:System.Windows.Forms.BindingSource.Current"/> property has changed.
		/// </summary>
		public event EventHandler CurrentItemChanged;

		/// <summary>
		/// Occurs when the underlying list changes or an item in the list changes.
		/// </summary>
		public event ListChangedEventHandler ListChanged;

		/// <summary>
		/// Occurs after the value of the <see cref="P:System.Windows.Forms.BindingSource.Position"/> property has changed.
		/// </summary>
		public event EventHandler PositionChanged;

		/// <summary>
		/// Occurs when the <see cref="T:System.Windows.Forms.BindingSource"/> is initialized.
		/// </summary>
		event EventHandler ISupportInitializeNotification.Initialized;
	}
}
