// Type: Microsoft.Office.Interop.Outlook._Application
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.Application"/>.
	/// </summary>
	[TypeLibType(4160)]
	[Guid("00063001-0000-0000-C000-000000000046")]
	[ComImport]
	public interface _Application
	{
		/// <summary>
		/// Returns the topmost <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/>  object on the desktop.
		/// </summary>
		/// 
		/// <returns>
		/// An Explorer that represents the topmost explorer on the desktop. Returns Nothing if no explorer is active.
		/// </returns>
		[DispId(273)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Explorer ActiveExplorer();

		/// <summary>
		/// Returns the topmost <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/>  object on the desktop.
		/// </summary>
		/// 
		/// <returns>
		/// An Inspector that represents the topmost inspector on the desktop.
		/// </returns>
		[DispId(274)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Inspector ActiveInspector();

		/// <summary>
		/// Creates and returns a new Microsoft Outlook item.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the new Outlook item.
		/// </returns>
		/// <param name="ItemType">The Outlook item type for the new item.</param>
		[DispId(266)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateItem([In] OlItemType ItemType);

		/// <summary>
		/// Creates a new Microsoft Outlook item from an Outlook template (.oft) and returns the new item.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the new Microsoft Outlook item.
		/// </returns>
		/// <param name="TemplatePath">The path and file name of the Outlook template for the new item.</param><param name="InFolder">The folder in which the item is to be created. If this argument is omitted, the default folder for the item type will be used.</param>
		[DispId(267)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateItemFromTemplate([MarshalAs(UnmanagedType.BStr), In] string TemplatePath, [MarshalAs(UnmanagedType.Struct), In, Optional] object InFolder);

		/// <summary>
		/// Creates an Automation object of the specified class.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the new Automation object instance. If the application is already running, CreateObject will create a new instance.
		/// </returns>
		/// <param name="ObjectName">The class name of the object to create. For information about valid class names, see OLE Programmatic Identifiers.</param>
		[DispId(277)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateObject([MarshalAs(UnmanagedType.BStr), In] string ObjectName);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.NameSpace"/>  object of the specified type.
		/// </summary>
		/// 
		/// <returns>
		/// A NameSpace object that represents the specified namespace.
		/// </returns>
		/// <param name="Type">The type of name space to return.</param>
		[DispId(272)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		NameSpace GetNamespace([MarshalAs(UnmanagedType.BStr), In] string Type);

		/// <summary>
		/// Closes all currently open windows.
		/// </summary>
		[DispId(275)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Quit();

		/// <summary>
		/// Returns an object representing the topmost Microsoft Outlook window on the desktop, either an <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/>  or an <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/>  object.
		/// </summary>
		/// 
		/// <returns>
		/// An Object that represents the topmost Microsoft Outlook window on the desktop. Returns Nothing if no Outlook explorer or inspector is open.
		/// </returns>
		[DispId(287)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object ActiveWindow();

		/// <summary>
		/// Copies a file from a specified location into a Microsoft Outlook store.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the copied file.
		/// </returns>
		/// <param name="FilePath">The path name of the object you want to copy.</param><param name="DestFolderPath">The location you want to copy the file to.</param>
		[DispId(64098)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CopyFile([MarshalAs(UnmanagedType.BStr), In] string FilePath, [MarshalAs(UnmanagedType.BStr), In] string DestFolderPath);

		/// <summary>
		/// Performs a search based on a specified DAV Searching and Locating (DASL) search string.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.Search"/> object that represents the results of the search.
		/// </returns>
		/// <param name="Scope">The scope of the search. For example, the folder path of a folder. It is recommended that the folder path  is enclosed within single quotes. Otherwise, the search might not return correct results if the folder path contains special characters including Unicode characters. To specify multiple folder paths, enclose each folder path in single quotes and separate the single quoted folder paths with a comma.</param><param name="Filter">The DASL search filter that defines the parameters of the search.</param><param name="SearchSubFolders">Determines if the search will include any of the folder's subfolders.</param><param name="Tag">The name given as an identifier for the search.</param>
		[DispId(64101)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Search AdvancedSearch([MarshalAs(UnmanagedType.BStr), In] string Scope, [MarshalAs(UnmanagedType.Struct), In, Optional] object Filter, [MarshalAs(UnmanagedType.Struct), In, Optional] object SearchSubFolders, [MarshalAs(UnmanagedType.Struct), In, Optional] object Tag);

		/// <summary>
		/// Returns a Boolean (bool in C#) indicating if a search will be synchronous or asynchronous.
		/// </summary>
		/// 
		/// <returns>
		/// True if the search is synchronous; otherwise, False.
		/// </returns>
		/// <param name="LookInFolders">The path name of the folders that the search will search through. You must enclose the folder path  with single quotes.</param>
		[DispId(64108)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsSearchSynchronous([MarshalAs(UnmanagedType.BStr), In] string LookInFolders);

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		/// <param name="pvar"/>
		[TypeLibFunc(64)]
		[DispId(64072)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetNewNickNames([MarshalAs(UnmanagedType.Struct), In] ref object pvar);

		/// <summary>
		/// Creates a strong or weak object reference for a specified Outlook object.
		/// </summary>
		/// 
		/// <returns>
		/// An Object that represents a strong or weak object reference for the specified object.
		/// </returns>
		/// <param name="Item">The object from which to obtain a strong or weak object reference.</param><param name="ReferenceType">The type of object reference.</param>
		[DispId(64470)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object GetObjectReference([MarshalAs(UnmanagedType.IDispatch), In] object Item, [In] OlReferenceType ReferenceType);

		/// <summary>
		/// Refreshes the cache by obtaining the current definition from the Windows registry for one or all of the form regions that are defined for the local machine and the current user.
		/// </summary>
		/// <param name="RegionName">The internal name of the form region whose definition you want to refresh in the cache. To refresh all form region definitions, specify an empty string.</param>
		[DispId(64639)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RefreshFormRegionDefinition([MarshalAs(UnmanagedType.BStr), In] string RegionName);

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
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(276)]
		Assistant Assistant { [DispId(276), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) value that represents the display name for the object. Read-only.
		/// </summary>
		[DispId(12289)]
		string Name { [DispId(12289), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a String (string in C#) indicating the number of the version. Read-only.
		/// </summary>
		[DispId(278)]
		string Version { [DispId(278), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a COMAddIns collection that represents all the Component Object Model (COM) add-ins currently loaded in Microsoft Outlook.
		/// </summary>
		[DispId(280)]
		COMAddIns COMAddIns { [DispId(280), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Explorers"/>  collection object that contains the <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/>  objects representing all open explorers. Read-only.
		/// </summary>
		[DispId(281)]
		Explorers Explorers { [DispId(281), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Inspectors"/>  collection object that contains the <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/>  objects representing all open inspectors. Read-only.
		/// </summary>
		[DispId(282)]
		Inspectors Inspectors { [DispId(282), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a LanguageSettings object for the application that contains the language-specific attributes of Outlook. Read-only.
		/// </summary>
		[DispId(283)]
		LanguageSettings LanguageSettings { [DispId(283), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) specifying the Microsoft Outlook globally unique identifier (GUID). Read-only.
		/// </summary>
		[DispId(284)]
		string ProductCode { [DispId(284), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(285)]
		AnswerWizard AnswerWizard { [DispId(285), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(286)]
		MsoFeatureInstall FeatureInstall { [TypeLibFunc(64), DispId(286), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(286), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Reminders"/> collection that represents all current reminders. Read-only.
		/// </summary>
		[DispId(64153)]
		Reminders Reminders { [DispId(64153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the name of the default profile name. Read-only.
		/// </summary>
		[DispId(64214)]
		string DefaultProfileName { [DispId(64214), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) to indicate if an add-in or external caller is considered trusted by Outlook. Read-only
		/// </summary>
		[DispId(64499)]
		bool IsTrusted { [DispId(64499), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an IAssistance object used to invoke help. Read-only.
		/// </summary>
		[DispId(64520)]
		IAssistance Assistance { [DispId(64520), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.TimeZones"/> collection that represents the set of time zones supported by Outlook. Read-only.
		/// </summary>
		[DispId(64553)]
		TimeZones TimeZones { [DispId(64553), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.PickerDialog"/> object that provides the functionality to select people or data in a dialog box. Read-only.
		/// </summary>
		[DispId(64613)]
		PickerDialog PickerDialog { [DispId(64613), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
