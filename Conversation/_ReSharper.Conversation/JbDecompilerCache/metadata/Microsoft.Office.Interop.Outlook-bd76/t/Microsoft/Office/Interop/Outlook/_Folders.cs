// Type: Microsoft.Office.Interop.Outlook._Folders
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/>.
	/// </summary>
	[Guid("00063040-0000-0000-C000-000000000046")]
	[TypeLibType(4160)]
	[ComImport]
	public interface _Folders : IEnumerable
	{
		/// <summary>
		/// Creates a new folder in the <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/> collection.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object that represents  the new folder.
		/// </returns>
		/// <param name="Name">The display name for the new folder.</param><param name="Type">The Outlook folder type for the new folder. If the folder type is not specified, the new folder will default to the same type as the folder in which it is created. Can be one of the following <see cref="T:Microsoft.Office.Interop.Outlook.OlDefaultFolders"/> constants: olFolderCalendar, olFolderContacts, olFolderDrafts, olFolderInbox, olFolderJournal, olFolderNotes,  or olFolderTasks. The constants olFolderConflicts, olFolderDeletedItems, olFolderJunk, olFolderLocalFailures, olFolderManagedEmail, olFolderOutbox, olFolderRssSubscriptions, olFolderSentMail, olFolderServerFailures, olFolderSyncIssues, olFolderToDo, and olPublicFoldersAllPublicFolders cannot be specified for this argument.</param>
		[DispId(95)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder Add([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

		/// <summary>
		/// Returns the first object in the <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/> collection.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object that represents the first object contained by the collection.
		/// </returns>
		[DispId(86)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder GetFirst();

		/// <summary>
		/// Returns the last object in the <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/> collection.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object that represents the last object contained by the collection.
		/// </returns>
		[DispId(88)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder GetLast();

		/// <summary>
		/// Returns the next object in the <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/> collection.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object that represents the next object contained by the collection.
		/// </returns>
		[DispId(87)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder GetNext();

		/// <summary>
		/// Returns the previous object in the <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/> collection.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object that represents the previous object contained by the collection.
		/// </returns>
		[DispId(89)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder GetPrevious();

		/// <summary>
		/// Removes an object from the collection.
		/// </summary>
		/// <param name="Index">The 1-based index value of the object within the collection.</param>
		[DispId(84)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Remove([In] int Index);

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
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object from the collection.
		/// </summary>
		/// 
		/// <returns>
		/// A Folder object that represents the specified object.
		/// </returns>
		/// <param name="Index">Either the index number of the object, or a value used to match the default property of an object in the collection.</param>
		[DispId(0)]
		MAPIFolder this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(90)]
		object RawTable { [TypeLibFunc(64), DispId(90), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
