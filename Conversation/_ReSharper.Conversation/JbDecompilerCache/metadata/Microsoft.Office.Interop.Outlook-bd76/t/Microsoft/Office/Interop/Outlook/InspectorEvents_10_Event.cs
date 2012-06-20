// Type: Microsoft.Office.Interop.Outlook.InspectorEvents_10_Event
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
	public interface InspectorEvents_10_Event
	{
		/// <summary>
		/// Occurs when an inspector becomes the active window, either as a result of user action or through program code.
		/// </summary>
		event InspectorEvents_10_ActivateEventHandler Activate;

		/// <summary>
		/// Occurs when an inspector stops being the active window, either as a result of user action or through program code.
		/// </summary>
		event InspectorEvents_10_DeactivateEventHandler Deactivate;

		/// <summary>
		/// Occurs when the inspector associated with a Microsoft Outlook item is being closed.
		/// </summary>
		event InspectorEvents_10_CloseEventHandler Close;

		/// <summary>
		/// Occurs when an inspector is maximized by the user.
		/// </summary>
		event InspectorEvents_10_BeforeMaximizeEventHandler BeforeMaximize;

		/// <summary>
		/// Occurs when the active inspector is minimized by the user.
		/// </summary>
		event InspectorEvents_10_BeforeMinimizeEventHandler BeforeMinimize;

		/// <summary>
		/// Occurs when the <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/> is moved by the user.
		/// </summary>
		event InspectorEvents_10_BeforeMoveEventHandler BeforeMove;

		/// <summary>
		/// Occurs when the user sizes the current <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/>.
		/// </summary>
		event InspectorEvents_10_BeforeSizeEventHandler BeforeSize;

		/// <summary>
		/// Occurs when the active form page changes, either programmatically or by user action, on an <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/> object.
		/// </summary>
		event InspectorEvents_10_PageChangeEventHandler PageChange;

		/// <summary>
		/// Occurs when the user selects a different or additional attachment of an item in the active inspector programmatically or by interacting with the user interface.
		/// </summary>
		event InspectorEvents_10_AttachmentSelectionChangeEventHandler AttachmentSelectionChange;
	}
}
