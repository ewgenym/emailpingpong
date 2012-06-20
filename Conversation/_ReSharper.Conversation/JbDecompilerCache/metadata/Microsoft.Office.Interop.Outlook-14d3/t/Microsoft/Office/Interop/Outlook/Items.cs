// Type: Microsoft.Office.Interop.Outlook.Items
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 11.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// Contains a collection of Outlook item objects in a folder.
	/// </summary>
	[Guid("00063041-0000-0000-C000-000000000046")]
	[CoClass(typeof (ItemsClass))]
	[ComImport]
	public interface Items : _Items, ItemsEvents_Event
	{
	}
}
