// Type: Microsoft.Office.Interop.Word.Styles
// Assembly: Microsoft.Office.Interop.Word, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Word.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word
{
	/// <summary>
	/// A collection of <see cref="T:Microsoft.Office.Interop.Word.Style"/> objects that represent both the built-in and user-defined styles in a document.
	/// </summary>
	[Guid("0002092D-0000-0000-C000-000000000046")]
	[TypeLibType(4288)]
	[ComImport]
	public interface Styles : IEnumerable
	{
		[DispId(-4)]
		[TypeLibFunc(1024)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		new IEnumerator GetEnumerator();

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Style"/> object that represents a new user-defined style added to the list of styles.
		/// </summary>
		/// <param name="Name">Required String. The string name for the new style.</param><param name="Type">Optional Object. The style type of the new style. Can be one of the following <see cref="T:Microsoft.Office.Interop.Word.WdStyleType"/> constants: wdStyleTypeParagraph, wdStyleTypeCharacter, wdStyleTypeList, or wdStyleTypeTable.</param>
		[DispId(100)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Style Add([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Type);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Application"/> object that represents the Microsoft Word application.
		/// </summary>
		[DispId(1000)]
		Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a 32-bit integer that indicates the application in which the specified object was created. Read-only Integer.
		/// </summary>
		[DispId(1001)]
		int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an object that represents the parent object of the specified object.
		/// </summary>
		[DispId(1002)]
		object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the number of items in the specified collection. Read-only Integer.
		/// </summary>
		[DispId(1)]
		int Count { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		[DispId(0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Style get_Item([MarshalAs(UnmanagedType.Struct), In] ref object Index);
	}
}
