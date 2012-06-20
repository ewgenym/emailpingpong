// Type: Microsoft.Office.Interop.Outlook._Explorer
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/>.
	/// </summary>
	[TypeLibType(4160)]
	[Guid("00063003-0000-0000-C000-000000000046")]
	[ComImport]
	public interface _Explorer
	{
		/// <summary>
		/// Closes the  <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/> object.
		/// </summary>
		[DispId(8451)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Close();

		/// <summary>
		/// Displays a new <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/> object for the folder.
		/// </summary>
		[DispId(8452)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Display();

		/// <summary>
		/// Activates an explorer window by bringing it to the foreground and setting keyboard focus.
		/// </summary>
		[DispId(8467)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Activate();

		/// <summary>
		/// Returns a Boolean (bool in C#) indicating  whether a specific explorer pane is visible.
		/// </summary>
		/// 
		/// <returns>
		/// True if the specified pane is displayed in the explorer; otherwise, False.
		/// </returns>
		/// <param name="Pane">The pane to check.</param>
		[DispId(8707)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsPaneVisible([In] OlPane Pane);

		/// <summary>
		/// Displays or hides a specific pane in the explorer.
		/// </summary>
		/// <param name="Pane">The pane to display.</param><param name="Visible">True to make the pane visible, False to hide the pane.</param>
		[DispId(8708)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ShowPane([In] OlPane Pane, [In] bool Visible);

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		/// <param name="Folder"/>
		[TypeLibFunc(64)]
		[DispId(64177)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SelectFolder([MarshalAs(UnmanagedType.Interface), In] MAPIFolder Folder);

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		/// <param name="Folder"/>
		[DispId(64178)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DeselectFolder([MarshalAs(UnmanagedType.Interface), In] MAPIFolder Folder);

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		/// <param name="Folder"/>
		[DispId(64179)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsFolderSelected([MarshalAs(UnmanagedType.Interface), In] MAPIFolder Folder);

		/// <summary>
		/// Clears results from a Microsoft Instant Search in an <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/> if results are displayed in the Explorer.
		/// </summary>
		[DispId(64461)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ClearSearch();

		/// <summary>
		/// Performs a Microsoft Instant Search on the current folder displayed in the Explorer using the given <paramref name="Query"/>.
		/// </summary>
		/// <param name="Query">A search string that can contain any valid keywords supported in Instant Search.</param><param name="SearchScope">Specifies the scope in terms of folders for the search.</param>
		[DispId(64101)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Search([MarshalAs(UnmanagedType.BStr), In] string Query, [In] OlSearchScope SearchScope);

		/// <summary>
		/// Returns a value that indicates whether the specified Microsoft Outlook item can be selected in the current view of the active explorer.
		/// </summary>
		/// 
		/// <returns>
		/// Returns a <see cref="T:System.Boolean"/> (bool for C#) value that indicates whether the specified item can be selected in the current view.
		/// </returns>
		/// <param name="Item">The item that is being considered for selection.</param>
		[DispId(64565)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsItemSelectableInView([MarshalAs(UnmanagedType.IDispatch), In] object Item);

		/// <summary>
		/// Adds the specified Microsoft Outlook item to the selection in the active explorer.
		/// </summary>
		/// <param name="Item">The item to add to the selection in the active explorer.</param>
		[DispId(64566)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddToSelection([MarshalAs(UnmanagedType.IDispatch), In] object Item);

		/// <summary>
		/// Cancels the selection of the specified Microsoft Outlook item in the active explorer.
		/// </summary>
		/// <param name="Item">The item to be removed from the selection.</param>
		[DispId(64567)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveFromSelection([MarshalAs(UnmanagedType.IDispatch), In] object Item);

		/// <summary>
		/// Selects all items that are contained in the current view of the active explorer.
		/// </summary>
		[DispId(64568)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SelectAllItems();

		/// <summary>
		/// Cancels any selection in the active explorer.
		/// </summary>
		[DispId(64569)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ClearSelection();

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
		[DispId(8448)]
		CommandBars CommandBars { [DispId(8448), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>  object that represents the current folder displayed in the explorer. Read/write.
		/// </summary>
		[DispId(8449)]
		MAPIFolder CurrentFolder { [DispId(8449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) representing the title. Read-only.
		/// </summary>
		[DispId(8465)]
		string Caption { [DispId(8465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an Object representing the current view. Read/write.
		/// </summary>
		[DispId(8704)]
		object CurrentView { [DispId(8704), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8704), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value specifying the height (in pixels) of the explorer window. Read/write.
		/// </summary>
		[DispId(8468)]
		int Height { [DispId(8468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value specifying the position (in pixels) of the left vertical edge of an explorer window from the edge of the screen. Read/write.
		/// </summary>
		[DispId(8469)]
		int Left { [DispId(8469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Panes"/>  collection object representing the panes displayed by the specified explorer.
		/// </summary>
		[DispId(8705)]
		Panes Panes { [DispId(8705), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Selection"/> object consisting of one or more items selected in the current view. Read-only.
		/// </summary>
		[DispId(8706)]
		Selection Selection { [DispId(8706), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value indicating the position (in pixels) of the top horizontal edge of an explorer window from the edge of the screen. Read/write.
		/// </summary>
		[DispId(8470)]
		int Top { [DispId(8470), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8470), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value indicating the width (in pixels) of the specified object. Read/write.
		/// </summary>
		[DispId(8471)]
		int Width { [DispId(8471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the property with a constant in the  <see cref="T:Microsoft.Office.Interop.Outlook.OlWindowState"/> enumeration specifying the window state of an explorer or inspector window. Read/write.
		/// </summary>
		[DispId(8466)]
		OlWindowState WindowState { [DispId(8466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(12553)]
		object Views { [TypeLibFunc(64), DispId(12553), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an HTMLDocument object that specifies the HTML object model associated with the HTML document in the current view (assuming one exists). Read-only.
		/// </summary>
		[DispId(64146)]
		object HTMLDocument { [DispId(64146), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.NavigationPane"/> object that represents the Navigation Pane for an <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/> object. Read-only.
		/// </summary>
		[DispId(64435)]
		NavigationPane NavigationPane { [DispId(64435), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.AccountSelector"/> object that represents the Microsoft Office Backstage view for the <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/>object. Read-only.
		/// </summary>
		[DispId(64625)]
		AccountSelector AccountSelector { [DispId(64625), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.AttachmentSelection"/> object consisting of one or more attachments that are selected in the current view of the explorer. Read-only.
		/// </summary>
		[DispId(64632)]
		AttachmentSelection AttachmentSelection { [DispId(64632), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
