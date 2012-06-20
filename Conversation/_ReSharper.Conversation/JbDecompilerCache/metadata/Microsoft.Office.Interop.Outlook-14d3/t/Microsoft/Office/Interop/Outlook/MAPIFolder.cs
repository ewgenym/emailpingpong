// Type: Microsoft.Office.Interop.Outlook.MAPIFolder
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 11.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using stdole;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This interface is deprecated; do not use this interface. Instead use the interface <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> to access all method, property, and event members of the COM object Folder. Refer to this topic for information about the method and property members of the COM object. For information about the event members of the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.MAPIFolderEvents_12_Event"/>.
	/// </summary>
	[TypeLibType(4160)]
	[Guid("00063006-0000-0000-C000-000000000046")]
	[ComImport]
	public interface MAPIFolder
	{
		/// <summary>
		/// Copies the current folder in its entirety to the destination folder.
		/// </summary>
		/// 
		/// <returns>
		/// A Folder object that represents the new copy of the current folder.
		/// </returns>
		/// <param name="DestinationFolder">Required Folder object  that represents the destination folder.</param>
		[DispId(61490)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder CopyTo([MarshalAs(UnmanagedType.Interface), In] MAPIFolder DestinationFolder);

		/// <summary>
		/// Deletes an object from the collection.
		/// </summary>
		[DispId(61509)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Delete();

		/// <summary>
		/// Displays a new <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/> object for the folder.
		/// </summary>
		[DispId(12548)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Display();

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/>  object that represents a new, inactive Explorer object initialized with the specified folder as the current folder.
		/// </summary>
		/// 
		/// <returns>
		/// An Explorer object that represents a new, inactive Explorer initialized with the specified folder as the current folder.
		/// </returns>
		/// <param name="DisplayMode">The display mode of the folder. Can be one of the constants in the <see cref="T:Microsoft.Office.Interop.Outlook.OlFolderDisplayMode"/> enumeration.</param>
		[DispId(12545)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Explorer GetExplorer([MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayMode);

		/// <summary>
		/// Moves a folder to the specified destination folder.
		/// </summary>
		/// <param name="DestinationFolder">The destination Folder for the Folder that is being moved.</param>
		[DispId(61492)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void MoveTo([MarshalAs(UnmanagedType.Interface), In] MAPIFolder DestinationFolder);

		/// <summary>
		/// Adds a Microsoft Exchange public folder to the public folder's Favorites folder.
		/// </summary>
		[DispId(12565)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddToPFFavorites();

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(64097)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddToFavorites([MarshalAs(UnmanagedType.Struct), In, Optional] object fNoUI, [MarshalAs(UnmanagedType.Struct), In, Optional] object Name);

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Outlook.StorageItem"/> object on the parent <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> to store data for an Outlook solution.
		/// </summary>
		/// 
		/// <returns>
		/// A StorageItem object that is used to store data for a solution.
		/// </returns>
		/// <param name="StorageIdentifier">An identifier for the StorageItem object; depending on the identifier type, the value can represent an Entry ID, a message class, or a subject.</param><param name="StorageIdentifierType">Specifies the type of identifier for the StorageItem object.</param>
		[DispId(64264)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		StorageItem GetStorage([MarshalAs(UnmanagedType.BStr), In] string StorageIdentifier, [In] OlStorageIdentifierType StorageIdentifierType);

		/// <summary>
		/// Obtains a <see cref="T:Microsoft.Office.Interop.Outlook.Table"/> object that contains items filtered by <paramref name="Filter"/>.
		/// </summary>
		/// 
		/// <returns>
		/// A Table that contains items in the parent <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> that meet the criteria in <paramref name="Filter"/>. By default, <paramref name="TableContents"/> is olUserItems and the returned Table contains only the filtered items that are not hidden.
		/// </returns>
		/// <param name="Filter">A filter in Microsoft Jet or DAV Searching and Locating (DASL) syntax that specifies the criteria for items in the parent Folder.</param><param name="TableContents">Specifies the type of items in the folder that GetTable returns. The default is olUserItems.</param>
		[DispId(64285)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Table GetTable([MarshalAs(UnmanagedType.Struct), In, Optional] object Filter, [MarshalAs(UnmanagedType.Struct), In, Optional] object TableContents);

		/// <summary>
		/// Creates a <see cref="T:Microsoft.Office.Interop.Outlook.CalendarSharing"/> object for the specified <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>.
		/// </summary>
		/// 
		/// <returns>
		/// A CalendarSharing object for the specified folder.
		/// </returns>
		[DispId(64418)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		CalendarSharing GetCalendarExporter();

		/// <summary>
		/// Returns an <see cref="T:stdole.StdPicture"/> object that represents the custom icon for the folder.
		/// </summary>
		/// 
		/// <returns>
		/// Returns an StdPicture object that represents a custom icon for the folder.
		/// </returns>
		[DispId(64572)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		StdPicture GetCustomIcon();

		/// <summary>
		/// Sets a custom icon that is specified by <paramref name="Picture"/> for the folder.
		/// </summary>
		/// <param name="Picture">Specifies the custom icon for the folder.</param>
		[DispId(64573)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCustomIcon([MarshalAs(UnmanagedType.Interface), In] StdPicture Picture);

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
		/// Returns a constant from the <see cref="T:Microsoft.Office.Interop.Outlook.OlItemType"/> enumeration indicating the default Outlook item type contained in the folder. Read-only.
		/// </summary>
		[DispId(12550)]
		OlItemType DefaultItemType { [DispId(12550), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the default message class for items in the folder. Read-only.
		/// </summary>
		[DispId(12551)]
		string DefaultMessageClass { [DispId(12551), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the description of the folder.  Read/write.
		/// </summary>
		[DispId(12292)]
		string Description { [DispId(12292), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(12292), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) representing the unique Entry ID of the object.  Read-only.
		/// </summary>
		[DispId(61470)]
		string EntryID { [DispId(61470), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/>  collection that represents all the folders contained in the specified <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>. Read-only.
		/// </summary>
		[DispId(8451)]
		Folders Folders { [DispId(8451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Items"/>  collection object as a collection of Outlook items in the specified folder. Read-only.
		/// </summary>
		[DispId(12544)]
		Items Items { [DispId(12544), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a String (string in C#) value that represents the display name for the object. Read/write.
		/// </summary>
		[DispId(12289)]
		string Name { [DispId(12289), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(12289), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) indicating the store ID for the folder. Read-only.
		/// </summary>
		[DispId(12552)]
		string StoreID { [DispId(12552), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Integer (int in C#) value indicating the number of unread items in the folder. Read-only.
		/// </summary>
		[DispId(13827)]
		int UnReadItemCount { [DispId(13827), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(12561)]
		object UserPermissions { [TypeLibFunc(64), DispId(12561), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) indicating the Web view state for a folder.  Read/write.
		/// </summary>
		[DispId(12562)]
		bool WebViewOn { [DispId(12562), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(12562), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) indicating the URL of the Web page that is assigned to a folder. Read/write.
		/// </summary>
		[DispId(12563)]
		string WebViewURL { [DispId(12563), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(12563), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(12564)]
		bool WebViewAllowNavigation { [TypeLibFunc(64), DispId(12564), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(12564), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) that indicates the Address Book name for the <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>  object representing a Contacts folder. Read/write.
		/// </summary>
		[DispId(64110)]
		string AddressBookName { [DispId(64110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that specifies whether the contact items folder will be displayed as an address list in the Outlook Address Book. Read/write.
		/// </summary>
		[DispId(64111)]
		bool ShowAsOutlookAB { [DispId(64111), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64111), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) that indicates the path of the current folder. Read-only.
		/// </summary>
		[DispId(64120)]
		string FolderPath { [DispId(64120), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) that determines if the specified folder will be synchronized with the e-mail server. Read/write.
		/// </summary>
		[DispId(64075)]
		bool InAppFolderSyncObject { [DispId(64075), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64075), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.View"/> object representing the current view. Read-only.
		/// </summary>
		[DispId(8704)]
		View CurrentView { [DispId(8704), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) that determines which views are displayed on the View menu for a given folder. Read/write.
		/// </summary>
		[DispId(64070)]
		bool CustomViewsOnly { [DispId(64070), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64070), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.Views"/> collection of the <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object. Read-only.
		/// </summary>
		[DispId(12553)]
		Views Views { [DispId(12553), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(61696)]
		object MAPIOBJECT { [TypeLibFunc(64), DispId(61696), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(64145)]
		string FullFolderPath { [TypeLibFunc(64), DispId(64145), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) that determines if the folder is a Microsoft SharePoint Foundation folder. Read-only.
		/// </summary>
		[DispId(64182)]
		bool IsSharePointFolder { [DispId(64182), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Sets or returns a constant in the <see cref="T:Microsoft.Office.Interop.Outlook.OlShowItemCount"/> enumeration that indicates whether to display the number of unread messages in the folder or the total number of items in the folder in the Navigation Pane. Read/write.
		/// </summary>
		[DispId(64194)]
		OlShowItemCount ShowItemCount { [DispId(64194), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64194), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Store"/> object representing the store that contains the <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object. Read-only.
		/// </summary>
		[DispId(64217)]
		Store Store { [DispId(64217), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.PropertyAccessor"/> object that supports creating, getting, setting, and deleting properties of the parent <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object. Read-only.
		/// </summary>
		[DispId(64253)]
		PropertyAccessor PropertyAccessor { [DispId(64253), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.UserDefinedProperties"/> object that represents the user-defined custom properties for the <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object. Read-only.
		/// </summary>
		[DispId(63510)]
		UserDefinedProperties UserDefinedProperties { [DispId(63510), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
