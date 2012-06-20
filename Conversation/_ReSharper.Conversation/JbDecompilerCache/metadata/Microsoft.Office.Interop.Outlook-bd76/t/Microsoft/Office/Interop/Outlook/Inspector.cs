// Type: Microsoft.Office.Interop.Outlook.Inspector
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// Represents the window in which an Outlook item is displayed.
	/// </summary>
	[Guid("00063005-0000-0000-C000-000000000046")]
	[CoClass(typeof (InspectorClass))]
	[ComImport]
	public interface Inspector : _Inspector, InspectorEvents_10_Event
	{
	}
}
