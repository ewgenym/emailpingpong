// Type: Microsoft.Office.Interop.Outlook._Items
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 11.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.Items"/>.
	/// </summary>
	[TypeLibType(4160)]
	[Guid("00063041-0000-0000-C000-000000000046")]
	[ComImport]
	public interface _Items : IEnumerable
	{
		/// <summary>
		/// Creates a new Outlook item in the <see cref="T:Microsoft.Office.Interop.Outlook.Items"/> collection for the folder.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the new Outlook item.
		/// </returns>
		/// <param name="Type">The Outlook item type for the new item. Specifies a <see cref="P:Microsoft.Office.Interop.Outlook._MailItem.MessageClass"/> to create custom forms. Can be one of the following OlItemType constants: olAppointmentItem, olContactItem, olJournalItem, olMailItem, olNoteItem, olPostItem, or olTaskItem,, or any valid message class. </param>
		[DispId(95)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object Add([MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

		/// <summary>
		/// Locates and returns an Outlook item object that satisfies the given <paramref name="Filter"/>.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents an Outlook item if the call succeeds; returns Nothing (null in C#)  if it fails.
		/// </returns>
		/// <param name="Filter">A string that specifies the criteria that the returned object must satisfy.</param>
		[DispId(98)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object Find([MarshalAs(UnmanagedType.BStr), In] string Filter);

		/// <summary>
		/// After the <see cref="M:Microsoft.Office.Interop.Outlook._Items.Find(System.String)"/>  method runs, this method finds and returns the next Outlook item in the specified collection.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the next Outlook item found in the collection.
		/// </returns>
		[DispId(99)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object FindNext();

		/// <summary>
		/// Returns the first object in the collection.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the first object contained by the collection.
		/// </returns>
		[DispId(86)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object GetFirst();

		/// <summary>
		/// Returns the last object in the collection.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the last object contained by the collection.
		/// </returns>
		[DispId(88)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object GetLast();

		/// <summary>
		/// Returns the next object in the collection.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the next object contained by the collection.
		/// </returns>
		[DispId(87)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object GetNext();

		/// <summary>
		/// Returns the previous object in the collection.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the previous object contained by the collection.
		/// </returns>
		[DispId(89)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object GetPrevious();

		/// <summary>
		/// Removes an object from the collection.
		/// </summary>
		/// <param name="Index">The 1-based index value of the object within the collection.</param>
		[DispId(84)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Remove([In] int Index);

		/// <summary>
		/// Clears the properties that have been cached with the <see cref="M:Microsoft.Office.Interop.Outlook._Items.SetColumns(System.String)"/> method.
		/// </summary>
		[DispId(93)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ResetColumns();

		/// <summary>
		/// Applies a filter to the <see cref="T:Microsoft.Office.Interop.Outlook.Items"/>  collection, returning a new collection containing all of the items from the original that match the filter.
		/// </summary>
		/// 
		/// <returns>
		/// An Items collection that represents the items from the original Items collection which match the filter.
		/// </returns>
		/// <param name="Filter">A filter string expression to be applied. For details, see the <see cref="M:Microsoft.Office.Interop.Outlook._Items.Find(System.String)"/>  method.</param>
		[DispId(100)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Items Restrict([MarshalAs(UnmanagedType.BStr), In] string Filter);

		/// <summary>
		/// Caches certain properties for extremely fast access to those particular properties of an item within the collection.
		/// </summary>
		/// <param name="Columns">A string that contains the names of the properties to cache. The property names are delimited by commas in this string.</param>
		[DispId(92)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetColumns([MarshalAs(UnmanagedType.BStr), In] string Columns);

		/// <summary>
		/// Sorts the collection of items by the specified property. The index for the collection is reset to 1 upon completion of this method.
		/// </summary>
		/// <param name="Property">The name of the property by which to sort, which may be enclosed in brackets, for example, "[CompanyName]". User-defined properties that contain spaces must be enclosed in brackets. May not be a user-defined property of type keywords, and may not be a multi-valued property, such as a category. For user-defined properties, the property must exist in the UserDefinedProperties collection for <see cref="P:Microsoft.Office.Interop.Outlook._Items.Parent"/>, which represents the <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object that contains the items. </param><param name="Descending">True to sort in descending order. The default value is False (ascending).</param>
		[DispId(97)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Sort([MarshalAs(UnmanagedType.BStr), In] string Property, [MarshalAs(UnmanagedType.Struct), In, Optional] object Descending);

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Application"/>  object that represents the parent Outlook application for the  object. Read-only.
		/// </summary>
		[DispId(61440)]
		Application Application { [DispId(61440), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlObjectClass"/> constant indicating the object's class. Read-only.
		/// </summary>
		[DispId(61450)]
		OlObjectClass Class { [DispId(61450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.NameSpace"/>  object for the current session. Read-only.
		/// </summary>
		[DispId(61451)]
		NameSpace Session { [DispId(61451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the parent Object of the specified object. Read-only.
		/// </summary>
		[DispId(61441)]
		object Parent { [DispId(61441), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Integer (int in C#) value indicating the count of objects in the specified collection. Read-only.
		/// </summary>
		[DispId(80)]
		int Count { [DispId(80), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Outlook item from a collection.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the specified object.
		/// </returns>
		/// <param name="Index">Either the index number of the object, or a value used to match the default property of an object in the collection.</param>
		[DispId(0)]
		object this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(90)]
		object RawTable { [DispId(90), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) that indicates True if the <see cref="T:Microsoft.Office.Interop.Outlook.Items"/>  collection should include recurrence patterns.  Read/write.
		/// </summary>
		[DispId(206)]
		bool IncludeRecurrences { [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }
	}
}
