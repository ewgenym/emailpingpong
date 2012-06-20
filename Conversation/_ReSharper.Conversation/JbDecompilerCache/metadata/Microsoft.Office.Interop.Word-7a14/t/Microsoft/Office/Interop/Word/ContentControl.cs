// Type: Microsoft.Office.Interop.Word.ContentControl
// Assembly: Microsoft.Office.Interop.Word, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word
{
	/// <summary>
	/// An  individual content control. Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain contents such as dates, lists, or paragraphs of formatted text. The ContentControl object is a member of the <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/> collection.
	/// </summary>
	[Guid("EE95AFE3-3026-4172-B078-0E79DAB5CC3D")]
	[TypeLibType(4288)]
	[ComImport]
	public interface ContentControl
	{
		/// <summary>
		/// Copies the content control from the active document to the Clipboard.
		/// </summary>
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Copy();

		/// <summary>
		/// Removes the content control from the active document and moves the content control to the Clipboard.
		/// </summary>
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Cut();

		/// <summary>
		/// Deletes the specified content control and the contents of the content control.
		/// </summary>
		/// <param name="DeleteContents">Specifies whether to delete the contents of the content control.  True removes both the content control and its contents. False removes the control but leaves the contents of the content control in the active document. The default value is False.</param>
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Delete([In] bool DeleteContents = false);

		/// <summary>
		/// Sets the placeholder text that displays in the content control until a user enters their own text.
		/// </summary>
		/// <param name="BuildingBlock">Specifies a <see cref="T:Microsoft.Office.Interop.Word.BuildingBlock"/> object that contains the contents of the placeholder text.</param><param name="Range">Specifies a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that contains the contents of the placeholder text.</param><param name="Text">Specifies the contents of the placeholder text.</param>
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetPlaceholderText([MarshalAs(UnmanagedType.Interface), In] BuildingBlock BuildingBlock = null, [MarshalAs(UnmanagedType.Interface), In] Range Range = null, [MarshalAs(UnmanagedType.BStr), In] string Text = "");

		/// <summary>
		/// Removes a group content control from a document so that its child content controls are no  longer nested  and can be freely edited.
		/// </summary>
		[DispId(24)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Ungroup();

		/// <summary>
		/// Sets the symbol used to represent the checked state of a check box content control.
		/// </summary>
		/// <param name="CharacterNumber">The Unicode character number for the specified symbol. This value will always be the sum of 31 (the number of control symbols at the beginning of the font) and the number that corresponds to the position of the symbol in the table of symbols (counting from left to right). For example, to specify a delta character at position 37 in the table of symbols in the Symbol font, set <paramref name="CharacterNumber"/> to 68.</param><param name="Font">The name of the font that contains the symbol.</param>
		[DispId(29)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCheckedSymbol([In] int CharacterNumber, [MarshalAs(UnmanagedType.BStr), In] string Font = "");

		/// <summary>
		/// Sets the symbol used to represent the unchecked state of a check box content control.
		/// </summary>
		/// <param name="CharacterNumber">The Unicode character number for the specified symbol. This value will always be the sum of 31 (the number of control symbols at the beginning of the font) and the number that corresponds to the position of the symbol in the table of symbols (counting from left to right). For example, to specify a delta character at position 37 in the table of symbols in the Symbol font, set <paramref name="CharacterNumber"/> to 68.</param><param name="Font">The name of the font that contains the symbol.</param>
		[DispId(30)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetUncheckedSymbol([In] int CharacterNumber, [MarshalAs(UnmanagedType.BStr), In] string Font = "");

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
		/// Returns an  that represents the parent object of the specified <see cref="T:Microsoft.Office.Interop.Word.ContentControl"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(1002)]
		object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> that represents the contents of the content control in the active document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Returns <see cref="T:Microsoft.Office.Interop.Word.Range"/>.
		/// </returns>
		[DispId(1)]
		Range Range { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether the user can delete a content control from the active document. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(2)]
		bool LockContentControl { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether the user can edit the contents of a content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(3)]
		bool LockContents { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the mapping of a content control to XML data in the data store of a  document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.XMLMapping"/>
		/// </returns>
		[DispId(4)]
		XMLMapping XMLMapping { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the type for a content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdContentControlType"/>
		/// </returns>
		[DispId(5)]
		WdContentControlType Type { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the items in a drop-down list content control or in a  combo box content control. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControlListEntries"/>
		/// </returns>
		[DispId(9)]
		ContentControlListEntries DropdownListEntries { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.BuildingBlock"/> object that represents the placeholder text for a content control. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Returns <see cref="T:Microsoft.Office.Interop.Word.BuildingBlock"/>.
		/// </returns>
		[DispId(10)]
		BuildingBlock PlaceholderText { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the title for a content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(12)]
		string Title { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the format in which dates are displayed. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(13)]
		string DateDisplayFormat { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean that represents whether a text content control allows multiple lines of text. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(15)]
		bool MultiLine { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the parent content control for a content control that is nested inside a rich-text control or group control. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControl"/>
		/// </returns>
		[DispId(16)]
		ContentControl ParentContentControl { [DispId(16), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether to remove a content control from the active document when the user edits the contents of the control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(17)]
		bool Temporary { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the identification for a content control. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(18)]
		string ID { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean that indicates whether the placeholder text for the content control is displayed. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(19)]
		bool ShowingPlaceholderText { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the format for storage and retrieval of dates when a date content control is bound to the XML data store of the active document. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdContentControlDateStorageFormat"/>
		/// </returns>
		[DispId(20)]
		WdContentControlDateStorageFormat DateStorageFormat { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the type of building block for a building block content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdBuildingBlockTypes"/>
		/// </returns>
		[DispId(21)]
		WdBuildingBlockTypes BuildingBlockType { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the category for a building block content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(22)]
		string BuildingBlockCategory { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a the language format for the date displayed in a date content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdLanguageID"/>
		/// </returns>
		[DispId(23)]
		WdLanguageID DateDisplayLocale { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the name of the character style to use to format text in a text content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(25)]
		object DefaultTextStyle { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the calendar type for a calendar content control.  Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdCalendarType"/>
		/// </returns>
		[DispId(26)]
		WdCalendarType DateCalendarType { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a value to identify a content control. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(27)]
		string Tag { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets or sets the current state (checked/unchecked) for a check box.
		/// </summary>
		/// 
		/// <returns>
		/// true if the check box is checked; otherwise; false.
		/// </returns>
		[DispId(28)]
		bool Checked { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }
	}
}
