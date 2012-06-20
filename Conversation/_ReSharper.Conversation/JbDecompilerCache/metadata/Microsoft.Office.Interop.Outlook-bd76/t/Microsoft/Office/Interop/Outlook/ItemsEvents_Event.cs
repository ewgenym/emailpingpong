// Type: Microsoft.Office.Interop.Outlook.ItemsEvents_Event
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
	public interface ItemsEvents_Event
	{
		/// <summary>
		/// Occurs when one or more items are added to the specified collection. This event does not run when a large number of items are added to the folder at once.
		/// </summary>
		event ItemsEvents_ItemAddEventHandler ItemAdd;

		/// <summary>
		/// Occurs when an item in the specified collection is changed.
		/// </summary>
		event ItemsEvents_ItemChangeEventHandler ItemChange;

		/// <summary>
		/// Occurs when an item is deleted from the specified collection. This event does not run when the last item in  a Personal Folders file (.pst) is deleted, or if 16 or more items are deleted  at once from a PST file, Microsoft Exchange mailbox, or an Exchange public folder.
		/// </summary>
		event ItemsEvents_ItemRemoveEventHandler ItemRemove;
	}
}
