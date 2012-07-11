// Type: Microsoft.Office.Interop.Outlook.Accounts
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 11.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
  /// <summary>
  /// The Accounts collection object contains a set of <see cref="T:Microsoft.Office.Interop.Outlook.Account"/> objects representing the accounts available for the current profile.
  /// </summary>
  [CoClass(typeof (AccountsClass))]
  [Guid("000630C4-0000-0000-C000-000000000046")]
  [ComImport]
  public interface Accounts : _Accounts, AccountsEvents_Event
  {
  }
}
