// Type: Microsoft.Office.Interop.Outlook.Folders
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// Contains a set of <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>  objects that represent all the available Outlook folders in a specific subset at one level of the folder tree.
	/// </summary>
	[Guid("00063040-0000-0000-C000-000000000046")]
	[CoClass(typeof (FoldersClass))]
	[ComImport]
	public interface Folders : _Folders, FoldersEvents_Event
	{
	}
}
