// Type: Microsoft.Office.Interop.Outlook.ExplorerEvents_10_Event
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a .NET interface created when processing a COM coclass that is required by managed code for interoperability with the corresponding COM object. This interface implements all events of earlier interfaces and any additional new events.  Use this interface only when the event you want to use shares the same name as a method of the COM object; in this case, cast to this interface to connect to the event, and cast to the primary interface to call the method. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object.
	/// </summary>
	[TypeLibType(16)]
	[ComVisible(false)]
	[ComEventInterface(X, X)]
	public interface ExplorerEvents_10_Event
	{
		/// <summary>
		/// Occurs when an explorer becomes the active window, either as a result of user action or through program code.
		/// </summary>
		event ExplorerEvents_10_ActivateEventHandler Activate;

		/// <summary>
		/// Occurs when the explorer goes to a new folder, either as a result of user action or through program code.
		/// </summary>
		event ExplorerEvents_10_FolderSwitchEventHandler FolderSwitch;

		/// <summary>
		/// Occurs before the explorer goes to a new folder, either as a result of user action or through program code.
		/// </summary>
		event ExplorerEvents_10_BeforeFolderSwitchEventHandler BeforeFolderSwitch;

		/// <summary>
		/// Occurs when the view in the explorer changes, either as a result of user action or through program code.
		/// </summary>
		event ExplorerEvents_10_ViewSwitchEventHandler ViewSwitch;

		/// <summary>
		/// Occurs before the explorer changes to a new view, either as a result of user action or through program code.
		/// </summary>
		event ExplorerEvents_10_BeforeViewSwitchEventHandler BeforeViewSwitch;

		/// <summary>
		/// Occurs when an explorer stops being the active window, either as a result of user action or through program code.
		/// </summary>
		event ExplorerEvents_10_DeactivateEventHandler Deactivate;

		/// <summary>
		/// Occurs when the user switches to a different item in a folder using the user interface (UI) or programmatically.
		/// </summary>
		event ExplorerEvents_10_SelectionChangeEventHandler SelectionChange;

		/// <summary>
		/// Occurs when an explorer is being closed.
		/// </summary>
		event ExplorerEvents_10_CloseEventHandler Close;

		/// <summary>
		/// Occurs when an explorer is maximized by the user.
		/// </summary>
		event ExplorerEvents_10_BeforeMaximizeEventHandler BeforeMaximize;

		/// <summary>
		/// Occurs when the active explorer is minimized by the user.
		/// </summary>
		event ExplorerEvents_10_BeforeMinimizeEventHandler BeforeMinimize;

		/// <summary>
		/// Occurs when the  <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/> is moved by the user.
		/// </summary>
		event ExplorerEvents_10_BeforeMoveEventHandler BeforeMove;

		/// <summary>
		/// Occurs when the user sizes the current <see cref="T:Microsoft.Office.Interop.Outlook.Explorer"/>.
		/// </summary>
		event ExplorerEvents_10_BeforeSizeEventHandler BeforeSize;

		/// <summary>
		/// Occurs when an Outlook item is copied.
		/// </summary>
		event ExplorerEvents_10_BeforeItemCopyEventHandler BeforeItemCopy;

		/// <summary>
		/// Occurs when an Outlook item is cut from a folder.
		/// </summary>
		event ExplorerEvents_10_BeforeItemCutEventHandler BeforeItemCut;

		/// <summary>
		/// Occurs when an Outlook item is pasted.
		/// </summary>
		event ExplorerEvents_10_BeforeItemPasteEventHandler BeforeItemPaste;

		/// <summary>
		/// Occurs when the user selects a different or additional attachment in the active explorer programmatically or by interacting with the user interface.
		/// </summary>
		event ExplorerEvents_10_AttachmentSelectionChangeEventHandler AttachmentSelectionChange;
	}
}
