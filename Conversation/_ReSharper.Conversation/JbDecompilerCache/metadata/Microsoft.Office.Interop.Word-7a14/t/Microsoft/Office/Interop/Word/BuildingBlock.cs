// Type: Microsoft.Office.Interop.Word.BuildingBlock
// Assembly: Microsoft.Office.Interop.Word, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word
{
	/// <summary>
	/// Represents a building block in a template.  A building block is pre-built content, similar to autotext, that may contain text, images, and formatting.
	/// </summary>
	[Guid("BFD3FC23-F763-4FF8-826E-1AFBF598A4E7")]
	[TypeLibType(4288)]
	[ComImport]
	public interface BuildingBlock
	{
		/// <summary>
		/// Deletes the specified building block.
		/// </summary>
		[DispId(101)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Delete();

		/// <summary>
		/// Inserts the value of a building block into a document and returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that represents the contents of the building block within the document.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.Range"/>
		/// </returns>
		/// <param name="Where">The location of where to place the contents of the building block.</param><param name="RichText">True inserts the building block as rich, formatted text.  False inserts the building block as plain text.</param>
		[DispId(102)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range Insert([MarshalAs(UnmanagedType.Interface), In] Range Where, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RichText);

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word._Application"/> object that represents the Microsoft Word application.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word._Application"/>
		/// </returns>
		[DispId(1000)]
		Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a 32-bit integer that indicates the application in which the add-in was created. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Integer
		/// </returns>
		[DispId(1001)]
		int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the parent object of the specified <see cref="T:Microsoft.Office.Interop.Word.BuildingBlock"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(1002)]
		object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the position of an item in a collection. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Integer
		/// </returns>
		[DispId(1)]
		int Index { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the name of a building block. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(2)]
		string Name { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the type for a building block. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.BuildingBlockType"/>
		/// </returns>
		[DispId(3)]
		BuildingBlockType Type { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the description for a building block. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(4)]
		string Description { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the internal identification number for a building block. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(5)]
		string ID { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the category for a building block. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.Category"/>
		/// </returns>
		[DispId(6)]
		Category Category { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the contents of a building block. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(0)]
		string Value { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer that represents how to insert the contents of a building block into a document. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Integer
		/// </returns>
		[DispId(7)]
		int InsertOptions { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }
	}
}
