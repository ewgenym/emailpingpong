// Type: Microsoft.Office.Interop.Word.ContentControls
// Assembly: Microsoft.Office.Interop.Word, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Word.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word
{
	/// <summary>
	/// A collection of <see cref="T:Microsoft.Office.Interop.Word.ContentControl"/> objects.  Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain content such as dates, lists, or paragraphs of formatted text.
	/// </summary>
	[Guid("804CD967-F83B-432D-9446-C61A45CFEFF0")]
	[TypeLibType(4288)]
	[ComImport]
	public interface ContentControls : IEnumerable
	{
		[TypeLibFunc(1024)]
		[DispId(-4)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		new IEnumerator GetEnumerator();

		/// <summary>
		/// Adds a new content control, of the type specified, into the active document and returns a <see cref="T:Microsoft.Office.Interop.Word.ContentControl"/> object that represents the new content control.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControl"/>
		/// </returns>
		/// <param name="Type">Specifies the type of content control  to insert into the active document. If omitted, Microsoft Office Word inserts a rich-text content control.</param><param name="Range">Specifies where in the active document to place the content control. If omitted, Word places the content control at the position of the insertion point or replaces the current selection.</param>
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		ContentControl Add([In] WdContentControlType Type = WdContentControlType.wdContentControlRichText, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word._Application"/> object that represents the Microsoft Word application.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word._Application"/>
		/// </returns>
		[DispId(100)]
		Application Application { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a 32-bit integer that indicates the application in which the add-in was created. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Integer
		/// </returns>
		[DispId(101)]
		int Creator { [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the parent object of the <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(102)]
		object Parent { [DispId(102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the number of items in the <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/> collection. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Integer
		/// </returns>
		[DispId(103)]
		int Count { [DispId(103), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		[DispId(0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		ContentControl get_Item([MarshalAs(UnmanagedType.Struct), In] ref object Index);
	}
}
