// Type: Microsoft.Office.Interop.Outlook._NameSpace
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.NameSpace"/>.
	/// </summary>
	[TypeLibType(4160)]
	[Guid("00063002-0000-0000-C000-000000000046")]
	[ComImport]
	public interface _NameSpace
	{
		/// <summary>
		/// Creates a <see cref="T:Microsoft.Office.Interop.Outlook.Recipient"/>  object.
		/// </summary>
		/// 
		/// <returns>
		/// A Recipient object that represents the new recipient.
		/// </returns>
		/// <param name="RecipientName">The name of the recipient; it can be a string representing the display name, the alias, or the full SMTP e-mail address of the recipient.</param>
		[DispId(8458)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Recipient CreateRecipient([MarshalAs(UnmanagedType.BStr), In] string RecipientName);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>  object that represents the default folder of the requested type for the current profile, for example, obtains the default Calendar folder for the user who is currently logged on.
		/// </summary>
		/// 
		/// <returns>
		/// A Folder object that represents the default folder of the requested type for the current profile. If the default folder of the requested type does not exist, for example, because olFolderManagedEmail is specified as the <paramref name="FolderType"/> but the Managed Folders group has not been deployed, then Microsoft Outlook raises an error.
		/// </returns>
		/// <param name="FolderType">The type of default folder to return.</param>
		[DispId(8459)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder GetDefaultFolder([In] OlDefaultFolders FolderType);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>  object identified by the specified entry ID (if valid).
		/// </summary>
		/// 
		/// <returns>
		/// AFolder object that represents the specified folder.
		/// </returns>
		/// <param name="EntryIDFolder">The <see cref="P:Microsoft.Office.Interop.Outlook.MAPIFolder.EntryID"/>  of the folder.</param><param name="EntryIDStore">The <see cref="P:Microsoft.Office.Interop.Outlook.MAPIFolder.StoreID"/>  for the folder.</param>
		[DispId(8456)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder GetFolderFromID([MarshalAs(UnmanagedType.BStr), In] string EntryIDFolder, [MarshalAs(UnmanagedType.Struct), In, Optional] object EntryIDStore);

		/// <summary>
		/// Returns a Microsoft Outlook item identified by the specified entry ID (if valid).
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the specified Outlook item.
		/// </returns>
		/// <param name="EntryIDItem">The <see cref="P:Microsoft.Office.Interop.Outlook.MAPIFolder.EntryID"/>  of the item.</param><param name="EntryIDStore">The <see cref="P:Microsoft.Office.Interop.Outlook.MAPIFolder.StoreID"/>  for the folder. <paramref name="EntryIDStore"/> usually must be provided when retrieving an item based on its MAPI IDs.</param>
		[DispId(8457)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object GetItemFromID([MarshalAs(UnmanagedType.BStr), In] string EntryIDItem, [MarshalAs(UnmanagedType.Struct), In, Optional] object EntryIDStore);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Recipient"/>  object identified by the specified entry ID (if valid).
		/// </summary>
		/// 
		/// <returns>
		/// A Recipient object that represents the specified recipient.
		/// </returns>
		/// <param name="EntryID">The <see cref="P:Microsoft.Office.Interop.Outlook.Recipient.EntryID"/>  of the recipient.</param>
		[DispId(8455)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Recipient GetRecipientFromID([MarshalAs(UnmanagedType.BStr), In] string EntryID);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>  object that represents the specified default folder for the specified user.
		/// </summary>
		/// 
		/// <returns>
		/// A Folder object that represents the specified default folder for the specified user.
		/// </returns>
		/// <param name="Recipient">The owner of the folder. Note that the Recipient object must be resolved.</param><param name="FolderType">The type of folder.</param>
		[DispId(8460)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder GetSharedDefaultFolder([MarshalAs(UnmanagedType.Interface), In] Recipient Recipient, [In] OlDefaultFolders FolderType);

		/// <summary>
		/// Logs the user off from the current MAPI session.
		/// </summary>
		[DispId(8454)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Logoff();

		/// <summary>
		/// Logs the user on to MAPI, obtaining a MAPI session.
		/// </summary>
		/// <param name="Profile">The MAPI profile name, as a String (string in C#), to use for the session. Specify an empty string to use the default profile for the current session.</param><param name="Password">The password (if any), as a String (string in C#), associated with the profile.  This parameter exists only for  backwards compatibility and for security reasons, it is not recommended for use.  Microsoft Oultook will prompt the user to specify a password in most system configurations.  This is your logon password and  should not be confused with PST passwords.</param><param name="ShowDialog">True to display the MAPI logon dialog box to allow the user to select a MAPI profile.</param><param name="NewSession">True to create a new Outlook session. Since multiple sessions cannot be created in Outlook, this parameter should be specified as True only if a session does not already exist.</param>
		[DispId(8453)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Logon([MarshalAs(UnmanagedType.Struct), In, Optional] object Profile, [MarshalAs(UnmanagedType.Struct), In, Optional] object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowDialog, [MarshalAs(UnmanagedType.Struct), In, Optional] object NewSession);

		/// <summary>
		/// Displays the Pick Folder dialog box.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object  that represents the folder that the user selects  in the dialog box, or Nothing if the dialog box is canceled by the user.
		/// </returns>
		[DispId(8462)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder PickFolder();

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[TypeLibFunc(64)]
		[DispId(8471)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RefreshRemoteHeaders();

		/// <summary>
		/// Adds a Personal Folders (.pst) file to the current profile.
		/// </summary>
		/// <param name="Store">The path of the .pst file to be added to the profile. If the .pst file does not exist, Microsoft Outlook creates it.</param>
		[DispId(8473)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddStore([MarshalAs(UnmanagedType.Struct), In] object Store);

		/// <summary>
		/// Removes a Personal Folders file (.pst) from the current MAPI profile or session.
		/// </summary>
		/// <param name="Folder">The Personal Folders file (.pst) to be deleted from the list.</param>
		[DispId(8474)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveStore([MarshalAs(UnmanagedType.Interface), In] MAPIFolder Folder);

		/// <summary>
		/// Displays the New Call dialog box that allows users to dial the primary phone number of a specified contact.
		/// </summary>
		/// <param name="ContactItem">The <see cref="T:Microsoft.Office.Interop.Outlook.ContactItem"/> object of the contact you want to dial.</param>
		[DispId(64013)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Dial([MarshalAs(UnmanagedType.Struct), In, Optional] object ContactItem);

		/// <summary>
		/// Adds a Personal Folders file (.pst) in the specified format to the current profile.
		/// </summary>
		/// <param name="Store">The path of the .pst file to be added to the profile. If the .pst file does not exist, Microsoft Outlook creates it.</param><param name="Type">The format in which the data file should be created.</param>
		[DispId(64197)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddStoreEx([MarshalAs(UnmanagedType.Struct), In] object Store, [In] OlStoreType Type);

		/// <summary>
		/// Obtains a <see cref="T:Microsoft.Office.Interop.Outlook.SelectNamesDialog"/> object for the current session.
		/// </summary>
		/// 
		/// <returns>
		/// A  SelectNamesDialog object for the current session. The SelectNamesDialog object supports displaying the Select Names dialog box for the user to select entries from one or more address lists in the current session.
		/// </returns>
		[DispId(64225)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SelectNamesDialog GetSelectNamesDialog();

		/// <summary>
		/// Initiates immediate delivery of all undelivered messages submitted in the current session, and  immediate receipt of  mail for  all accounts in the current profile.
		/// </summary>
		/// <param name="showProgressDialog">Indicates whether the Outlook Send/Receive Progress dialog box should be displayed, regardless of user settings.</param>
		[DispId(64215)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SendAndReceive([In] bool showProgressDialog);

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.AddressEntry"/> object that represents the address entry  specified by <paramref name="ID"/>.
		/// </summary>
		/// 
		/// <returns>
		/// An AddressEntry that has the <see cref="P:Microsoft.Office.Interop.Outlook.AddressEntry.ID"/> property matching the specified <paramref name="ID"/>.
		/// </returns>
		/// <param name="ID">A string identifier for an address entry maintained for the session.</param>
		[DispId(64260)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		AddressEntry GetAddressEntryFromID([MarshalAs(UnmanagedType.BStr), In] string ID);

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.AddressList"/> object that represents the Exchange Global Address List.
		/// </summary>
		/// 
		/// <returns>
		/// An AddressList that represents the Global Address List.
		/// </returns>
		[DispId(64261)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		AddressList GetGlobalAddressList();

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Store"/> object that represents the store specified by <paramref name="ID"/>.
		/// </summary>
		/// 
		/// <returns>
		/// A Store object that has the <see cref="P:Microsoft.Office.Interop.Outlook._Store.StoreID"/> property matching <paramref name="ID"/>.
		/// </returns>
		/// <param name="ID">A string value identifying a store.</param>
		[DispId(64262)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Store GetStoreFromID([MarshalAs(UnmanagedType.BStr), In] string ID);

		/// <summary>
		/// Opens a shared folder referenced through a URL or file name.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object that represents the shared folder.
		/// </returns>
		/// <param name="Path">The URL or local file name of the shared folder to be opened.</param><param name="Name">The name of the Really Simple Syndication (RSS) feed or Webcal calendar. This parameter is ignored for other shared folder types.</param><param name="DownloadAttachments">Indicates whether to download enclosures (for RSS feeds) or attachments (for Webcal calendars.) This parameter is ignored for other shared folder types.</param><param name="UseTTL">Indicates whether the Time To Live (TTL) setting in an RSS feed or WebCal calendar should be used. This parameter is ignored for other shared folder types.</param>
		[DispId(64502)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MAPIFolder OpenSharedFolder([MarshalAs(UnmanagedType.BStr), In] string Path, [MarshalAs(UnmanagedType.Struct), In, Optional] object Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object DownloadAttachments, [MarshalAs(UnmanagedType.Struct), In, Optional] object UseTTL);

		/// <summary>
		/// Opens a shared item from a specified path or URL.
		/// </summary>
		/// 
		/// <returns>
		/// An Object representing the appropriate Outlook item for the shared item.
		/// </returns>
		/// <param name="Path">The path or URL of the shared item to be opened.</param>
		[DispId(64503)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object OpenSharedItem([MarshalAs(UnmanagedType.BStr), In] string Path);

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Office.Interop.Outlook.SharingItem"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// A SharingItem object that represents a sharing message for the specified context.
		/// </returns>
		/// <param name="Context">Either a String (string in C#) value or a <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/> object representing the sharing context to be used.</param><param name="Provider">An <see cref="T:Microsoft.Office.Interop.Outlook.OlSharingProvider"/>  value representing the sharing provider to be used.</param>
		[DispId(64484)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SharingItem CreateSharingItem([MarshalAs(UnmanagedType.Struct), In] object Context, [MarshalAs(UnmanagedType.Struct), In, Optional] object Provider);

		/// <summary>
		/// Returns a Boolean value (bool in C#) that indicates if two entry ID values refer to the same Outlook item.
		/// </summary>
		/// 
		/// <returns>
		/// True if the entry ID values refer to the same Outlook item; otherwise, False.
		/// </returns>
		/// <param name="FirstEntryID">The first entry ID to be compared.</param><param name="SecondEntryID">The second entry ID to be compared.</param>
		[DispId(64508)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CompareEntryIDs([MarshalAs(UnmanagedType.BStr), In] string FirstEntryID, [MarshalAs(UnmanagedType.BStr), In] string SecondEntryID);

		/// <summary>
		/// Creates an instance of a <see cref="T:Microsoft.Office.Core.ContactCard"/> object for the contact that is specified by the <paramref name="AddressEntry"/> parameter.
		/// </summary>
		/// 
		/// <returns>
		/// Returns a ContactCard object that is created for the specified user.
		/// </returns>
		/// <param name="AddressEntry">The <see cref="T:Microsoft.Office.Interop.Outlook.AddressEntry"/> object that represents the user for whom the contact card is to be created.</param>
		[DispId(64645)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		ContactCard CreateContactCard([MarshalAs(UnmanagedType.Interface), In] AddressEntry AddressEntry);

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
		/// Returns the display name of the currently logged-on user as a <see cref="T:Microsoft.Office.Interop.Outlook.Recipient"/>  object. Read-only.
		/// </summary>
		[DispId(8449)]
		Recipient CurrentUser { [DispId(8449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.Folders"/>  collection that represents all the folders contained in the specified <see cref="T:Microsoft.Office.Interop.Outlook.NameSpace"/>. Read-only.
		/// </summary>
		[DispId(8451)]
		Folders Folders { [DispId(8451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) indicating the type of the specified object.  Read-only.
		/// </summary>
		[DispId(8452)]
		string Type { [DispId(8452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.AddressLists"/>  collection representing a collection of the address lists available for this session. Read-only.
		/// </summary>
		[DispId(8461)]
		AddressLists AddressLists { [DispId(8461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.SyncObjects"/>  collection containing all Send\Receive groups. Read-only.
		/// </summary>
		[DispId(8472)]
		SyncObjects SyncObjects { [DispId(8472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) indicating True if Outlook is offline (not connected to an Exchange server), and False if online (connected to an Exchange server).  Read-only.
		/// </summary>
		[DispId(64076)]
		bool Offline { [DispId(64076), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(61696)]
		object MAPIOBJECT { [TypeLibFunc(64), DispId(61696), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlExchangeConnectionMode"/> constant that indicates the current connection mode the user is using. Read-only.
		/// </summary>
		[DispId(64193)]
		OlExchangeConnectionMode ExchangeConnectionMode { [DispId(64193), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Accounts"/> collection object that represents all the <see cref="T:Microsoft.Office.Interop.Outlook.Account"/> objects in the current profile. Read-only.
		/// </summary>
		[DispId(64208)]
		Accounts Accounts { [DispId(64208), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the name of the current profile. Read-only.
		/// </summary>
		[DispId(64213)]
		string CurrentProfileName { [DispId(64213), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Stores"/> collection object that represents all the <see cref="T:Microsoft.Office.Interop.Outlook.Store"/> objects in the current profile. Read-only.
		/// </summary>
		[DispId(64216)]
		Stores Stores { [DispId(64216), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Store"/> object representing the default Store for the profile. Read-only.
		/// </summary>
		[DispId(64236)]
		Store DefaultStore { [DispId(64236), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Outlook.Categories"/> object that represents the set of <see cref="T:Microsoft.Office.Interop.Outlook.Category"/> objects available to the namespace. Read/write.
		/// </summary>
		[DispId(64421)]
		Categories Categories { [DispId(64421), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) value that represents the name of the Exchange server on which the active mailbox is hosted. Read-only.
		/// </summary>
		[DispId(64517)]
		string ExchangeMailboxServerName { [DispId(64517), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) value that represents the full version of the Exchange server on which the active mailbox is hosted. Read-only.
		/// </summary>
		[DispId(64516)]
		string ExchangeMailboxServerVersion { [DispId(64516), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) that represents information in XML retrieved from the auto-discovery service of an Exchange server. Read-only.
		/// </summary>
		[DispId(64515)]
		string AutoDiscoverXml { [DispId(64515), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlAutoDiscoverConnectionMode"/> constant that specifies the type of connection to the Exchange server for auto-discovery service. Read-only.
		/// </summary>
		[DispId(64558)]
		OlAutoDiscoverConnectionMode AutoDiscoverConnectionMode { [DispId(64558), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
