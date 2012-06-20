// Type: Microsoft.Office.Interop.Word.Range
// Assembly: Microsoft.Office.Interop.Word, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word
{
	/// <summary>
	/// Represents a contiguous area in a document.
	/// </summary>
	[TypeLibType(4288)]
	[Guid("0002095E-0000-0000-C000-000000000046")]
	[ComImport]
	public interface Range
	{
		/// <summary>
		/// Selects the specified object.
		/// </summary>
		[DispId(65535)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Select();

		/// <summary>
		/// Sets the starting and ending character positions for the range.
		/// </summary>
		/// <param name="Start">Required Integer. The starting character position of the range or selection.</param><param name="End">Required Integer. The ending character position of the range or selection.</param>
		[DispId(100)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetRange([In] int Start, [In] int End);

		/// <summary>
		/// Collapses a range to the starting or ending position.
		/// </summary>
		/// <param name="Direction">Optional Object. The direction in which to collapse the range or selection. Can be either of the following <see cref="T:Microsoft.Office.Interop.Word.WdCollapseDirection"/> constants: wdCollapseEnd or wdCollapseStart. The default value is wdCollapseStart.</param>
		[DispId(101)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Collapse([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Direction);

		/// <summary>
		/// Inserts the specified text before the specified range.
		/// </summary>
		/// <param name="Text">Required String. The text to be inserted.</param>
		[DispId(102)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertBefore([MarshalAs(UnmanagedType.BStr), In] string Text);

		/// <summary>
		/// Inserts the specified text at the end of a range or selection.
		/// </summary>
		/// <param name="Text">Required String. The text to be inserted.</param>
		[DispId(104)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertAfter([MarshalAs(UnmanagedType.BStr), In] string Text);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that represents the specified unit relative to the specified range.
		/// </summary>
		/// <param name="Unit">Optional Object. The type of units by which to count. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/> constant.</param><param name="Count">Optional Object. The number of units by which you want to move ahead. The default value is one.</param>
		[DispId(105)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range Next([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object relative to the specified selection or range.
		/// </summary>
		/// <param name="Unit">Optional Object. <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/></param><param name="Count">Optional Object. The number of units by which you want to move back. The default value is 1.</param>
		[DispId(106)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range Previous([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves or extends the start position of the specified range or selection to the beginning of the nearest specified text unit.
		/// </summary>
		/// <param name="Unit">Optional <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/>. The unit by which the start position of the specified range or selection is to be moved.</param><param name="Extend">Optional <see cref="T:Microsoft.Office.Interop.Word.WdMovementType"/>.</param>
		[DispId(107)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int StartOf([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

		/// <summary>
		/// Moves or extends the ending character position of a range or selection to the end of the nearest specified text unit.
		/// </summary>
		/// <param name="Unit">Optional Object. The unit by which to move the ending character position. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/> constants.</param><param name="Extend">Optional Object. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdMovementType"/> constants.</param>
		[DispId(108)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int EndOf([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

		/// <summary>
		/// Collapses the specified range or selection to its start or end position and then moves the collapsed object by the specified number of units.
		/// </summary>
		/// <param name="Unit">Optional Object. The unit by which the collapsed range or selection is to be moved. Can be one of the following <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/> constants: wdCharacter, wdWord, wdSentence, wdParagraph, wdSection, wdStory, wdCell, wdColumn, wdRow, or wdTable. If <paramref name="expression"/> returns a <see cref="T:Microsoft.Office.Interop.Word.Selection"/> object, you can also use wdLine. The default value is wdCharacter.</param><param name="Count">Optional Object. The number of units by which the specified range or selection is to be moved. If <paramref name="Count"/> is a positive number, the object is collapsed to its end position and moved backward in the document by the specified number of units. If <paramref name="Count"/> is a negative number, the object is collapsed to its start position and moved forward by the specified number of units. The default value is 1. You can also control the collapse direction by using the <see cref="M:Microsoft.Office.Interop.Word.Range.Collapse(System.Object@)"/> method before using the Move method. If the range or selection is in the middle of a unit or isn't collapsed, moving it to the beginning or end of the unit counts as moving it one full unit.</param>
		[DispId(109)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int Move([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the start position of the specified range.
		/// </summary>
		/// <param name="Unit">Optional <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/>. The unit by which start position of the specified range or selection is to be moved.</param><param name="Count">Optional Object. The maximum number of units by which the specified range or selection is to be moved. If <paramref name="Count"/> is a positive number, the start position of the range or selection is moved forward in the document. If it's a negative number, the start position is moved backward. If the start position is moved forward to a position beyond the end position, the range or selection is collapsed and both the start and end positions are moved together. The default value is 1.</param>
		[DispId(110)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveStart([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the ending character position of a range.
		/// </summary>
		/// <param name="Unit">Optional <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/>. The unit by which to move the ending character position.</param><param name="Count">Optional Object. The number of units to move. If this number is positive, the ending character position is moved forward in the document. If this number is negative, the end is moved backward. If the ending position overtakes the starting position, the range collapses and both character positions move together. The default value is 1.</param>
		[DispId(111)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveEnd([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the specified range while any of the specified characters are found in the document.
		/// </summary>
		/// <param name="Cset">Required Object. One or more characters. This argument is case sensitive.</param><param name="Count">Optional Object. The maximum number of characters by which the specified range or selection is to be moved. Can be a number or either the wdForward or wdBackward constant. If <paramref name="Count"/> is a positive number, the specified range or selection is moved forward in the document, beginning at the end position. If it's a negative number, the range or selection is moved backward, beginning at the start position. The default value is wdForward.</param>
		[DispId(112)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveWhile([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the start position of the specified range while any of the specified characters are found in the document.
		/// </summary>
		/// <param name="Cset">Required Object. One or more characters. This argument is case sensitive.</param><param name="Count">Optional Object. The maximum number of characters by which the specified range or selection is to be moved. Can be a number or either the wdForward or wdBackward constant. If <paramref name="Count"/> is a positive number, the range or selection is moved forward in the document. If it's a negative number, the range or selection is moved backward. The default value is wdForward.</param>
		[DispId(113)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveStartWhile([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the ending character position of a range while any of the specified characters are found in the document.
		/// </summary>
		/// <param name="Cset">Required Object. One or more characters. This argument is case sensitive.</param><param name="Count">Optional Object. The maximum number of characters by which the range or selection is to be moved. Can be a number or either the wdForward or wdBackward constant. If <paramref name="Count"/> is a positive number, the range or selection is moved forward in the document. If it's a negative number, the range or selection is moved backward. The default value is wdForward.</param>
		[DispId(114)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveEndWhile([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the specified range until one of the specified characters is found in the document.
		/// </summary>
		/// <param name="Cset">Required Object. One or more characters. If any character in <paramref name="Cset"/> is found before the <paramref name="Count"/> value expires, the specified range or selection is positioned as an insertion point immediately before that character. This argument is case sensitive.</param><param name="Count">Optional Object. The maximum number of characters by which the specified range or selection is to be moved. Can be a number or either the wdForward or wdBackward constant. If <paramref name="Count"/> is a positive number, the range or selection is moved forward in the document, beginning at the end position. If it's a negative number, the range or selection is moved backward, beginning at the start position. The default value is wdForward.</param>
		[DispId(115)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveUntil([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the start position of the specified range or selection until one of the specified characters is found in the document.
		/// </summary>
		/// <param name="Cset">Required Object. One or more characters. This argument is case sensitive.</param><param name="Count">Optional Object. The maximum number of characters by which the specified range or selection is to be moved. Can be a number or either the wdForward or wdBackward constant. If <paramref name="Count"/> is a positive number, the range or selection is moved forward in the document. If it's a negative number, the range or selection is moved backward. The default value is wdForward.</param>
		[DispId(116)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveStartUntil([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Moves the end position of the specified range or selection until any of the specified characters are found in the document.
		/// </summary>
		/// <param name="Cset">Required Object. One or more characters. This argument is case sensitive.</param><param name="Count">Optional Object. The maximum number of characters by which the specified range or selection is to be moved. Can be a number or either the wdForward or wdBackward constant. If <paramref name="Count"/> is a positive number, the range or selection is moved forward in the document. If it's a negative number, the range or selection is moved backward. The default value is wdForward.</param>
		[DispId(117)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int MoveEndUntil([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Removes the specified object from the document and places it on the Clipboard.
		/// </summary>
		[DispId(119)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Cut();

		/// <summary>
		/// Copies the specified object to the Clipboard.
		/// </summary>
		[DispId(120)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Copy();

		/// <summary>
		/// Inserts the contents of the Clipboard at the specified range.
		/// </summary>
		[DispId(121)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Paste();

		/// <summary>
		/// Inserts a page, column, or section break.
		/// </summary>
		/// <param name="Type">Optional Object. The type of break to be inserted. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdBreakType"/> constants.</param>
		[DispId(122)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertBreak([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Type);

		/// <summary>
		/// Inserts all or part of the specified file.
		/// </summary>
		/// <param name="FileName">Required String. The path and file name of the file to be inserted. If you don't specify a path, Microsoft Word assumes the file is in the current folder.</param><param name="Range">Optional Object. If the specified file is a Word document, this parameter refers to a bookmark. If the file is another type (for example, a Microsoft Excel worksheet), this parameter refers to a named range or a cell range (for example, R1C1:R3C4).</param><param name="ConfirmConversions">Optional Object. True to have Word prompt you to confirm conversion when inserting files in formats other than the Word Document format.</param><param name="Link">Optional Object. True to insert the file by using an INCLUDETEXT field.</param><param name="Attachment">Optional Object. True to insert the file as an attachment to an e-mail message.</param>
		[DispId(123)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertFile([MarshalAs(UnmanagedType.BStr), In] string FileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Link, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Attachment);

		/// <summary>
		/// Determines if the selection or range to which this method is applied is in the same story as the range specified by the <paramref name="Range"/> argument.
		/// </summary>
		/// <param name="Range">Required <see cref="T:Microsoft.Office.Interop.Word.Range"/> object. The Range object whose story is compared with the story that contains <paramref name="expression"/>.</param>
		[DispId(125)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool InStory([MarshalAs(UnmanagedType.Interface), In] Range Range);

		/// <summary>
		/// Determines if the range to which the method is applied is contained in the specified range.
		/// </summary>
		/// <param name="Range">Required Range object. The range to which you want to compare <paramref name="expression"/>.</param>
		[DispId(126)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool InRange([MarshalAs(UnmanagedType.Interface), In] Range Range);

		/// <summary>
		/// Deletes the specified number of characters or words.
		/// </summary>
		/// <param name="Unit">Optional Object. The unit by which the collapsed range or selection is to be deleted. Can be one of the following <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/> constants: wdCharacter (default) or wdWord.</param><param name="Count">Optional Object. The number of units to be deleted. To delete units after the range or selection, collapse the range or selection and use a positive number. To delete units before the range or selection, collapse the range or selection and use a negative number.</param>
		[DispId(127)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int Delete([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

		/// <summary>
		/// Expands a range to include the entire story.
		/// </summary>
		[DispId(128)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void WholeStory();

		/// <summary>
		/// Expands the specified range.
		/// </summary>
		/// <param name="Unit">Optional Object. The unit by which to expand the range. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdUnits"/> constants.</param>
		[DispId(129)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int Expand([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit);

		/// <summary>
		/// Replaces the specified range with a new paragraph.
		/// </summary>
		[DispId(160)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertParagraph();

		/// <summary>
		/// Inserts a paragraph mark after a range.
		/// </summary>
		[DispId(161)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertParagraphAfter();

		/// <param name="Separator"/><param name="NumRows"/><param name="NumColumns"/><param name="InitialColumnWidth"/><param name="Format"/><param name="ApplyBorders"/><param name="ApplyShading"/><param name="ApplyFont"/><param name="ApplyColor"/><param name="ApplyHeadingRows"/><param name="ApplyLastRow"/><param name="ApplyFirstColumn"/><param name="ApplyLastColumn"/><param name="AutoFit"/>
		[DispId(162)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Table ConvertToTableOld([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumColumns, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InitialColumnWidth, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyBorders, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyShading, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFont, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyColor, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyHeadingRows, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastRow, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFirstColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoFit);

		/// <param name="DateTimeFormat"/><param name="InsertAsField"/><param name="InsertAsFullWidth"/>
		[DispId(163)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertDateTimeOld([MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateTimeFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsField, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsFullWidth);

		/// <summary>
		/// Inserts a symbol in place of the specified range.
		/// </summary>
		/// <param name="CharacterNumber">Required Integer. The character number for the specified symbol. This value will always be the sum of 31 and the number that corresponds to the position of the symbol in the table of symbols (counting from left to right). For example, to specify a delta character at position 37 in the table of symbols in the Symbol font, set <paramref name="CharacterNumber"/> to 68.</param><param name="Font">Optional Object. The name of the font that contains the symbol.</param><param name="Unicode">Optional Object. True to insert the Unicode character specified by <paramref name="CharacterNumber"/>; False to insert the ANSI character specified by <paramref name="CharacterNumber"/>. The default value is False.</param><param name="Bias">Optional Object. Sets the font bias for symbols. This argument is useful for setting the correct font bias for East Asian characters. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdFontBias"/> constants: wdFontBiasDefault, wdFontBiasDontCare, or wdFontBiasFareast. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param>
		[DispId(164)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertSymbol([In] int CharacterNumber, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Font, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unicode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Bias);

		/// <param name="ReferenceType"/><param name="ReferenceKind"/><param name="ReferenceItem"/><param name="InsertAsHyperlink"/><param name="IncludePosition"/>
		[DispId(165)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertCrossReference_2002([MarshalAs(UnmanagedType.Struct), In] ref object ReferenceType, [In] WdReferenceKind ReferenceKind, [MarshalAs(UnmanagedType.Struct), In] ref object ReferenceItem, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsHyperlink, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludePosition);

		/// <param name="Label"/><param name="Title"/><param name="TitleAutoText"/><param name="Position"/>
		[DispId(166)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertCaptionXP([MarshalAs(UnmanagedType.Struct), In] ref object Label, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Title, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TitleAutoText, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Position);

		/// <summary>
		/// The CopyAsPicture method works the same way as the <see cref="M:Microsoft.Office.Interop.Word.Range.Copy"/> method.
		/// </summary>
		[DispId(167)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CopyAsPicture();

		/// <param name="ExcludeHeader"/><param name="FieldNumber"/><param name="SortFieldType"/><param name="SortOrder"/><param name="FieldNumber2"/><param name="SortFieldType2"/><param name="SortOrder2"/><param name="FieldNumber3"/><param name="SortFieldType3"/><param name="SortOrder3"/><param name="SortColumn"/><param name="Separator"/><param name="CaseSensitive"/><param name="LanguageID"/>
		[TypeLibFunc(64)]
		[DispId(168)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SortOld([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeHeader, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CaseSensitive, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

		/// <summary>
		/// Sorts paragraphs or table rows in ascending alphanumeric order.
		/// </summary>
		[DispId(169)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SortAscending();

		/// <summary>
		/// Sorts paragraphs or table rows in descending alphanumeric order.
		/// </summary>
		[DispId(170)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SortDescending();

		/// <summary>
		/// Determines if the range to which this method is applied is equal to the range specified by the <paramref name="Range"/> argument.
		/// </summary>
		/// <param name="Range">Required <see cref="T:Microsoft.Office.Interop.Word.Range"/> object. The Range object that's compared with <paramref name="expression"/>.</param>
		[DispId(171)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsEqual([MarshalAs(UnmanagedType.Interface), In] Range Range);

		/// <summary>
		/// Calculates a mathematical expression within a range.
		/// </summary>
		[DispId(172)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		float Calculate();

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that represents the start position of the specified item, such as a page, bookmark, or field.
		/// </summary>
		/// <param name="What">Optional Object. The kind of item to which the range or selection is moved. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdGoToItem"/> constants.</param><param name="Which">Optional Object. The item to which the range or selection is moved. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdGoToDirection"/> constants. </param><param name="Count">Optional Object. The number of the item in the document. The default value is 1.Only positive values are valid. To specify an item that precedes the range or selection, use wdGoToPrevious as the <paramref name="Which"/> argument and specify a <paramref name="Count"/> value. </param><param name="Name">Optional Object. If the <paramref name="What"/> argument is wdGoToBookmark, wdGoToComment, wdGoToField, or wdGoToObject, this argument specifies a name. </param>
		[DispId(173)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range GoTo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object What, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Which, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that refers to the start position of the next item or location specified by the <paramref name="What"/> argument.
		/// </summary>
		/// <param name="What">Required <see cref="T:Microsoft.Office.Interop.Word.WdGoToItem"/>.</param>
		[DispId(174)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range GoToNext([In] WdGoToItem What);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that refers to the start position of the previous item or location specified by the <paramref name="What"/> argument.
		/// </summary>
		/// <param name="What">Required <see cref="T:Microsoft.Office.Interop.Word.WdGoToItem"/>. The item that the specified range or selection is to be moved to. </param>
		[DispId(175)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range GoToPrevious([In] WdGoToItem What);

		/// <summary>
		/// Inserts the contents of the Clipboard.
		/// </summary>
		/// <param name="IconIndex">Optional Object. If <paramref name="DisplayAsIcon"/> is True, this argument is a number that corresponds to the icon you want to use in the program file specified by <paramref name="IconFilename"/>. Icons appear in the Change Icon dialog box (Insert menu, Object command, Create New tab): 0 (zero) corresponds to the first icon, 1 corresponds to the second icon, and so on. If this argument is omitted, the first (default) icon is used.</param><param name="Link">Optional Object. True to create a link to the source file of the Clipboard contents. The default value is False.</param><param name="Placement">Optional Object. Can be either of the following <see cref="T:Microsoft.Office.Interop.Word.WdOLEPlacement"/> constants: wdFloatOverText or wdInLine. The default value is wdInLine.</param><param name="DisplayAsIcon">Optional Object. Optional Object. True to display the link as an icon. The default value is False.</param><param name="DataType">Optional Object. A format for the Clipboard contents when they're inserted into the document. <see cref="T:Microsoft.Office.Interop.Word.WdPasteDataType"/>.</param><param name="IconFileName">Optional Object.If <paramref name="DisplayAsIcon"/> is True, this argument is the path and file name for the file in which the icon to be displayed is stored.</param><param name="IconLabel">Optional Object. If <paramref name="DisplayAsIcon"/> is True, this argument is the text that appears below the icon.</param>
		[DispId(176)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PasteSpecial([MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Link, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Placement, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DisplayAsIcon, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DataType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconFileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconLabel);

		/// <summary>
		/// Looks up a name in the global address book list and displays the Properties dialog box, which includes information about the specified name.
		/// </summary>
		[DispId(177)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void LookupNameProperties();

		/// <summary>
		/// Returns a statistic based on the contents of the specified range.
		/// </summary>
		/// <param name="Statistic">Required <see cref="T:Microsoft.Office.Interop.Word.WdStatistic"/>.</param>
		[DispId(178)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int ComputeStatistics([In] WdStatistic Statistic);

		/// <summary>
		/// In outline view, moves the paragraphs within the specified range after the next visible paragraph or before the previous visible paragraph.
		/// </summary>
		/// <param name="Direction">Required <see cref="T:Microsoft.Office.Interop.Word.WdRelocate"/>. The direction of the move.</param>
		[DispId(179)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Relocate([In] int Direction);

		/// <summary>
		/// Displays the Thesaurus dialog box, which lists alternative word choices, or synonyms, for the text in the specified range.
		/// </summary>
		[DispId(180)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckSynonyms();

		/// <param name="Edition"/><param name="Format"/>
		[TypeLibFunc(64)]
		[DispId(181)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SubscribeTo([MarshalAs(UnmanagedType.BStr), In] string Edition, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format);

		/// <param name="Edition"/><param name="ContainsPICT"/><param name="ContainsRTF"/><param name="ContainsText"/>
		[TypeLibFunc(64)]
		[DispId(182)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CreatePublisher([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Edition, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContainsPICT, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContainsRTF, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContainsText);

		/// <summary>
		/// Attempts to match the text in the specified range or the text surrounding the range with an existing AutoText entry name.
		/// </summary>
		[DispId(183)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertAutoText();

		/// <summary>
		/// Retrieves data from a data source (for example, a separate Microsoft Word document, a Microsoft Excel worksheet, or a Microsoft Access database) and inserts the data as a table in place of the specified range.
		/// </summary>
		/// <param name="Format">Optional Object. A format listed in the Formats box in the Table AutoFormat dialog box (Table menu). Can be any of the <see cref="T:Microsoft.Office.Interop.Word.WdTableFormat"/> constants. A border is applied to the cells in the table by default.</param><param name="Style">Optional Object. The attributes of the AutoFormat specified by <paramref name="Format"/> that are applied to the table. Use the sum of any combination of the following values:ValueMeaning0 (zero)None1Borders2Shading4Font8Color16Auto Fit32Heading Rows64Last Row128First Column256Last Column</param><param name="LinkToSource">Optional Object. True to establish a link between the new table and the data source.</param><param name="Connection">Optional Object. A range within which to perform the query specified by <paramref name="SQLStatement"/>. How you specify the range depends on how data is retrieved. For example:When retrieving data through Open Database Connectivity (ODBC), you specify a connection string. When retrieving data from Microsoft Excel by using dynamic data exchange (DDE), you specify a named range or "Entire Spreadsheet."Security  Dynamic data exchange (DDE) is an older technology that is not secure. If possible, use a more secure alternative to DDE.When retrieving data from Microsoft Access, you specify the word "Table" or "Query" followed by the name of a table or query.</param><param name="SQLStatement">Optional String. An optional query string that retrieves a subset of the data in a primary data source to be inserted into the document.</param><param name="SQLStatement1">Optional String. If the query string is longer than 255 characters, <paramref name="SQLStatement"/> denotes the first portion of the string and <paramref name="SQLStatement1"/> denotes the second portion.</param><param name="PasswordDocument">Optional Object. The password (if any) required to open the data source. (See Remarks below.)</param><param name="PasswordTemplate">Optional Object. If the data source is a Word document, this argument is the password (if any) required to open the attached template. (See Remarks below.)</param><param name="WritePasswordDocument">Optional Object. The password required to save changes to the document. (See Remarks below.)</param><param name="WritePasswordTemplate">Optional Object. The password required to save changes to the template. (See Remarks below.)</param><param name="DataSource">Optional Object. The path and file name of the data source.</param><param name="From">Optional Object. The number of the first data record in the range of records to be inserted.</param><param name="To">Optional Object. The number of the last data record in the range of records to be inserted.</param><param name="IncludeFields">Optional Object. True to include field names from the data source in the first row of the new table.</param>
		[DispId(194)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertDatabase([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Style, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToSource, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Connection, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement1, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DataSource, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeFields);

		/// <summary>
		/// Automatically formats a range.
		/// </summary>
		[DispId(195)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AutoFormat();

		/// <summary>
		/// Begins a spelling and grammar check for the specified range.
		/// </summary>
		[DispId(204)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckGrammar();

		/// <summary>
		/// Begins a spelling check for the specified range.
		/// </summary>
		/// <param name="CustomDictionary">Optional Object. Either an expression that returns a <see cref="T:Microsoft.Office.Interop.Word.Dictionary"/> object or the file name of the custom dictionary.</param><param name="IgnoreUppercase">Optional Object. True if capitalization is ignored. If this argument is omitted, the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.IgnoreUppercase"/> property is used.</param><param name="AlwaysSuggest">Optional Object. True for Microsoft Word to always suggest alternative spellings. If this argument is omitted, the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.SuggestSpellingCorrections"/> property is used.</param><param name="CustomDictionary2">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary3">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary4">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary5">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary6">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary7">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary8">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary9">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary10">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param>
		[DispId(205)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckSpelling([MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreUppercase, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AlwaysSuggest, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary4, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary5, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary6, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary7, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary8, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary9, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary10);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.SpellingSuggestions"/> collection that represents the words suggested as spelling replacements for the first word in the specified range.
		/// </summary>
		/// <param name="CustomDictionary">Optional Object. Either an expression that returns a <see cref="T:Microsoft.Office.Interop.Word.Dictionary"/> object or the file name of the custom dictionary.</param><param name="IgnoreUppercase">Optional Object. True to ignore words in all uppercase letters. If this argument is omitted, the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.IgnoreUppercase"/> property is used.</param><param name="MainDictionary">Optional Object. Either an expression that returns a Dictionary object or the file name of the main dictionary. If you don't specify a main dictionary, Microsoft Word uses the main dictionary that corresponds to the language formatting of the first word in the range.</param><param name="SuggestionMode">Optional Object. Specifies the way Word makes spelling suggestions. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSpellingWordType"/> constants. The default value is WdSpellword.</param><param name="CustomDictionary2">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary3">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary4">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary5">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary6">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary7">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary8">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary9">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param><param name="CustomDictionary10">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary.</param>
		[DispId(209)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		SpellingSuggestions GetSpellingSuggestions([MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreUppercase, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MainDictionary, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SuggestionMode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary4, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary5, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary6, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary7, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary8, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary9, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary10);

		/// <summary>
		/// Inserts a new paragraph before the specified range.
		/// </summary>
		[DispId(212)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertParagraphBefore();

		/// <summary>
		/// Moves the range to the next subdocument.
		/// </summary>
		[DispId(219)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void NextSubdocument();

		/// <summary>
		/// Moves the range or selection to the previous subdocument. If there isn't another subdocument, an error occurs.
		/// </summary>
		[DispId(220)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PreviousSubdocument();

		/// <summary>
		/// Converts the specified range from Hangul to Hanja or vice versa.
		/// </summary>
		/// <param name="ConversionsMode">Optional Object. Sets the direction for the conversion between Hangul and Hanja. Can be either of the following <see cref="T:Microsoft.Office.Interop.Word.WdMultipleWordConversionsMode"/> constants: wdHangulToHanja or wdHanjaToHangul. The default value is the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.MultipleWordConversionsMode"/> property.</param><param name="FastConversion">Optional Object. True if Microsoft Word automatically converts a word with only one suggestion for conversion. The default value is the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.HangulHanjaFastConversion"/> property.</param><param name="CheckHangulEnding">Optional Object. True if Word automatically detects Hangul endings and ignores them. The default value is the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.CheckHangulEndings"/> property. This argument is ignored if the <paramref name="ConversionsMode"/> argument is set to wdHanjaToHangul.</param><param name="EnableRecentOrdering">Optional Object. True if Word displays the most recently used words at the top of the suggestions list. The default value is the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.EnableHangulHanjaRecentOrdering"/> property.</param><param name="CustomDictionary">Optional Object. The name of a custom Hangul-Hanja conversion dictionary. Use this argument in order to use a custom dictionary with Hangul-Hanja conversions not contained in the main dictionary.</param>
		[DispId(221)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ConvertHangulAndHanja([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConversionsMode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FastConversion, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CheckHangulEnding, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EnableRecentOrdering, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary);

		/// <summary>
		/// Pastes a cell or group of cells as a nested table into the selected range.
		/// </summary>
		[DispId(222)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PasteAsNestedTable();

		/// <summary>
		/// Adds, modifies, or removes an enclosure around the specified character or characters.
		/// </summary>
		/// <param name="Style">Required Object. The style of the enclosure. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdEncloseStyle"/> constant.</param><param name="Symbol">Optional Object. The symbol in which to enclose the specified range. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdEnclosureType"/> constant.</param><param name="EnclosedText">Optional Object. The characters that you want to enclose. If you include this argument, Microsoft Word replaces the specified range with the enclosed characters. If you don't specify text to enclose, Microsoft Word encloses all text in the specified range.</param>
		[DispId(223)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ModifyEnclosure([MarshalAs(UnmanagedType.Struct), In] ref object Style, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Symbol, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EnclosedText);

		/// <summary>
		/// Adds phonetic guides to the specified range.
		/// </summary>
		/// <param name="Text">Required String. The phonetic text to add.</param><param name="Alignment">Optional <see cref="T:Microsoft.Office.Interop.Word.WdPhoneticGuideAlignmentType"/>. The alignment of the added phonetic text.</param><param name="Raise">Optional Integer. The distance (in points) from the top of the text in the specified range to the top of the phonetic text. If no value is specified, Microsoft Word automatically sets the phonetic text at an optimum distance above the specified range.</param><param name="FontSize">Optional Integer. The font size to use for the phonetic text. If no value is specified, Word uses a font size 50 percent smaller than the text in the specified range.</param><param name="FontName">Optional String. The name of the font to use for the phonetic text. If no value is specified, Word uses the same font as the text in the specified range.</param>
		[DispId(224)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PhoneticGuide([MarshalAs(UnmanagedType.BStr), In] string Text, [In] WdPhoneticGuideAlignmentType Alignment = (WdPhoneticGuideAlignmentType) - 1, [In] int Raise = 0, [In] int FontSize = 0, [MarshalAs(UnmanagedType.BStr), In] string FontName = "");

		/// <summary>
		/// Inserts the current date or time, or both, either as text or as a TIME field.
		/// </summary>
		/// <param name="DateTimeFormat">Optional Object. The format to be used for displaying the date or time, or both. If this argument is omitted, Microsoft Word uses the short-date style from the Windows Control Panel (Regional Settings icon).</param><param name="InsertAsField">Optional Object. True to insert the specified information as a TIME field. The default value is True.</param><param name="InsertAsFullWidth">Optional Object. True to insert the specified information as double-byte digits. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="DateLanguage">Optional Object. Sets the language in which to display the date or time. Can be either of the <see cref="T:Microsoft.Office.Interop.Word.WdDateLanguage"/> constants: wdDateLanguageBidi or wdDateLanguageLatin. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="CalendarType">Optional Object. Sets the calendar type to use when displaying the date or time. Can be either of the <see cref="T:Microsoft.Office.Interop.Word.WdCalendarTypeBi"/> constants: wdCalendarTypeBidi or wdCalendarTypeGregorian. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param>
		[DispId(444)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertDateTime([MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateTimeFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsField, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsFullWidth, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateLanguage, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CalendarType);

		/// <summary>
		/// Sorts the paragraphs in the specified range.
		/// </summary>
		/// <param name="ExcludeHeader">Optional Object. True to exclude the first row or paragraph header from the sort operation. The default value is False.</param><param name="FieldNumber">Optional Object. The fields to sort by. Microsoft Word sorts by <paramref name="FieldNumber"/>, then by <paramref name="FieldNumber2"/>, and then by <paramref name="FieldNumber3"/>.</param><param name="SortFieldType">Optional Object. The respective sort types for <paramref name="FieldNumber"/>, <paramref name="FieldNumber2"/>, and <paramref name="FieldNumber3"/>. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSortFieldType"/> constants.</param><param name="SortOrder">Optional Object. The sorting order to use when sorting <paramref name="FieldNumber"/>, <paramref name="FieldNumber2"/>, and <paramref name="FieldNumber3"/>. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSortOrder"/> constants.</param><param name="FieldNumber2">Optional Object. The fields to sort by. Microsoft Word sorts by <paramref name="FieldNumber"/>, then by <paramref name="FieldNumber2"/>, and then by <paramref name="FieldNumber3"/></param><param name="SortFieldType2">Optional Object. The respective sort types for <paramref name="FieldNumber"/>, <paramref name="FieldNumber2"/>, and <paramref name="FieldNumber3"/>. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSortFieldType"/> constants</param><param name="SortOrder2">Optional Object. The sorting order to use when sorting <paramref name="FieldNumber"/>, <paramref name="FieldNumber2"/>, and <paramref name="FieldNumber3"/>. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSortOrder"/> constants.</param><param name="FieldNumber3">Optional Object. The fields to sort by. Microsoft Word sorts by <paramref name="FieldNumber"/>, then by <paramref name="FieldNumber2"/>, and then by <paramref name="FieldNumber3"/></param><param name="SortFieldType3">Optional Object. The respective sort types for <paramref name="FieldNumber"/>, <paramref name="FieldNumber2"/>, and <paramref name="FieldNumber3"/>. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSortFieldType"/> constants</param><param name="SortOrder3">Optional Object. The sorting order to use when sorting <paramref name="FieldNumber"/>, <paramref name="FieldNumber2"/>, and <paramref name="FieldNumber3"/>. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSortOrder"/> constants.</param><param name="SortColumn">Optional Object. True to sort only the column specified by the <see cref="T:Microsoft.Office.Interop.Word.Range"/> object.</param><param name="Separator">Optional Object. The type of field separator. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSortSeparator"/> constants.</param><param name="CaseSensitive">Optional Object. True to sort with case sensitivity. The default value is False.</param><param name="BidiSort">Optional Object. True to sort based on right-to-left language rules. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="IgnoreThe">Optional Object. True to ignore the Arabic character <paramref name="alef lam"/> when sorting right-to-left language text. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="IgnoreKashida">Optional Object. True to ignore kashidas when sorting right-to-left language text. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="IgnoreDiacritics">Optional Object. True to ignore bidirectional control characters when sorting right-to-left language text. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="IgnoreHe">Optional Object. True to ignore the Hebrew character <paramref name="he"/> when sorting right-to-left language text. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="LanguageID">Optional Object. <paramref name="LanguageIDOptional"/>Object. Specifies the sorting language. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdLanguageID"/>constants.</param>
		[DispId(484)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Sort([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeHeader, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CaseSensitive, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object BidiSort, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreThe, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreKashida, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreDiacritics, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreHe, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

		/// <summary>
		/// Analyzes the specified text to determine the language that it is written in.
		/// </summary>
		[DispId(203)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DetectLanguage();

		/// <summary>
		/// Converts text within a range or selection to a table.
		/// </summary>
		/// <param name="Separator">Optional Object. Specifies the character used to separate text into cells. Can be a character or a <see cref="T:Microsoft.Office.Interop.Word.WdTableFieldSeparator"/> constant. If this argument is omitted, the value of the DefaultTableSeparator property is used.</param><param name="NumRows">Optional Object. The number of rows in the table. If this argument is omitted, Word sets the number of rows, based on the contents of the range.</param><param name="NumColumns">Optional Object. The number of columns in the table. If this argument is omitted, Word sets the number of columns, based on the contents of the range.</param><param name="InitialColumnWidth">Optional Object. The initial width of each column, in points. If this argument is omitted, Word calculates and adjusts the column width so that the table stretches from margin to margin.</param><param name="Format">Optional Object. Specifies one of the predefined formats listed in the Table AutoFormat dialog box (Table menu). Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdTableFormat"/> constants.</param><param name="ApplyBorders">Optional Object. True to apply the border properties of the specified format.</param><param name="ApplyShading">Optional Object. True to apply the shading properties of the specified format.</param><param name="ApplyFont">Optional Object. True to apply the font properties of the specified format.</param><param name="ApplyColor">Optional Object. True to apply the color properties of the specified format.</param><param name="ApplyHeadingRows">Optional Object. True to apply the heading-row properties of the specified format.</param><param name="ApplyLastRow">Optional Object. True to apply the last-row properties of the specified format.</param><param name="ApplyFirstColumn">Optional Object. True to apply the first-column properties of the specified format.</param><param name="ApplyLastColumn">Optional Object. True to apply the last-column properties of the specified format.</param><param name="AutoFit">Optional Object. True to decrease the width of the table columns as much as possible without changing the way text wraps in the cells.</param><param name="AutoFitBehavior">Optional Object. Sets the AutoFit rules for how Word sizes a table. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdAutoFitBehavior"/> constants. If <paramref name="DefaultTableBehavior"/> is wdWord8TableBehavior, this argument is ignored.</param><param name="DefaultTableBehavior">Optional Object. Sets a value that specifies whether Microsoft Word automatically resizes cells in a table to fit the contents (AutoFit). Can be a <see cref="T:Microsoft.Office.Interop.Word.WdDefaultTableBehavior"/> constant.</param>
		[DispId(498)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Table ConvertToTable([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumColumns, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InitialColumnWidth, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyBorders, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyShading, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFont, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyColor, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyHeadingRows, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastRow, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFirstColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoFit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoFitBehavior, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultTableBehavior);

		/// <summary>
		/// Converts the specified range from Traditional Chinese to Simplified Chinese or vice versa.
		/// </summary>
		/// <param name="WdTCSCConverterDirection">Optional <see cref="T:Microsoft.Office.Interop.Word.WdTCSCConverterDirection"/>.</param><param name="CommonTerms">Optional Boolean. True if Microsoft Word converts common expressions intact rather than converting on a character-by-character basis.</param><param name="UseVariants">Optional Boolean. True if Word uses Taiwan, Hong Kong SAR, and Macao SAR character variants. Can only be used if translating from Simplified Chinese to Traditional Chinese.</param>
		[DispId(499)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void TCSCConverter([In] WdTCSCConverterDirection WdTCSCConverterDirection = WdTCSCConverterDirection.wdTCSCConverterDirectionAuto, [In] bool CommonTerms = false, [In] bool UseVariants = false);

		/// <summary>
		/// Pastes the selected table cells and formats them as specified.
		/// </summary>
		/// <param name="Type">Required <see cref="T:Microsoft.Office.Interop.Word.WdRecoveryType"/>. The type of formatting to use when pasting the selected table cells.</param>
		[DispId(412)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PasteAndFormat([In] WdRecoveryType Type);

		/// <summary>
		/// Pastes and formats a Microsoft Excel table.
		/// </summary>
		/// <param name="LinkedToExcel">Required Boolean. True links the pasted table to the original Excel file so that changes made to the Excel file are reflected in Microsoft Word.</param><param name="WordFormatting">Required Boolean. True formats the table using the formatting in the Word document. False formats the table according to the original Excel file.</param><param name="RTF">Required Boolean. True pastes the Excel table using Rich Text Format (RTF). False pastes the Excel table as HTML.</param>
		[DispId(413)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PasteExcelTable([In] bool LinkedToExcel, [In] bool WordFormatting, [In] bool RTF);

		/// <summary>
		/// Merges pasted cells into an existing table by inserting the pasted rows between the selected rows.
		/// </summary>
		[DispId(414)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PasteAppendTable();

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that represents an area of a document that can be modified by the specified user or group of users.
		/// </summary>
		/// <param name="EditorID">Optional Object. Can be a String that represents the user's e-mail alias (if in the same domain), an e-mail address, or a <see cref="T:Microsoft.Office.Interop.Word.WdEditorType"/> constant that represents a group of users. If omitted, selects all ranges for which all users have permissions to edit.</param>
		[DispId(415)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range GoToEditableRange([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

		/// <summary>
		/// Inserts the specified XML text into the specified range or selection.
		/// </summary>
		/// <param name="XML">Required String. The XML text to insert.</param><param name="Transform">Optional Object. The transform to apply to the inserted XML text.</param>
		[DispId(416)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertXML([MarshalAs(UnmanagedType.BStr), In] string XML, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Transform);

		/// <summary>
		/// Inserts a caption immediately preceding or following the specified range.
		/// </summary>
		/// <param name="Label">Required Object. The caption label to be inserted. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdCaptionLabelID"/> constants.</param><param name="Title">Optional Object. The string to be inserted immediately following the label in the caption (ignored if <paramref name="TitleAutoText"/> is specified).</param><param name="TitleAutoText">Optional Object. The AutoText entry whose contents you want to insert immediately following the label in the caption (overrides any text specified by <paramref name="Title"/>).</param><param name="Position">Optional Object. Specifies whether the caption will be inserted above or below the <see cref="T:Microsoft.Office.Interop.Word.Range"/> object. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdCaptionPosition"/> constants.</param><param name="ExcludeLabel">Optional Object. True does not include the text label, as defined in the <paramref name="Label"/> parameter. False includes the specified label.</param>
		[DispId(417)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertCaption([MarshalAs(UnmanagedType.Struct), In] ref object Label, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Title, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TitleAutoText, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Position, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeLabel);

		/// <summary>
		/// Inserts a cross-reference to a heading, bookmark, footnote, or endnote, or to an item for which a caption label is defined (for example, an equation, figure, or table).
		/// </summary>
		/// <param name="ReferenceType">Required Object. The type of item for which a cross-reference is to be inserted. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdReferenceType"/> or <see cref="T:Microsoft.Office.Interop.Word.WdCaptionLabelID"/> constant or a user defined caption label.</param><param name="ReferenceKind">Required <see cref="T:Microsoft.Office.Interop.Word.WdReferenceKind"/>. The information to be included in the cross-reference.</param><param name="ReferenceItem">Required Object. If <paramref name="ReferenceType"/> is wdRefTypeBookmark, this argument specifies a bookmark name. For all other <paramref name="ReferenceType"/> values, this argument specifies the item number or name in the Reference type box in the Cross-reference dialog box. Use the <see cref="M:Microsoft.Office.Interop.Word._Document.GetCrossReferenceItems(System.Object@)"/> method to return a list of item names that can be used with this argument.</param><param name="InsertAsHyperlink">Optional Object. True to insert the cross-reference as a hyperlink to the referenced item.</param><param name="IncludePosition">Optional Object. True to insert "above" or "below," depending on the location of the reference item in relation to the cross-reference.</param><param name="SeparateNumbers">Optional Object. True to use a separator to separate the numbers from the associated text. (Use only if the <paramref name="ReferenceType"/> parameter is set to wdRefTypeNumberedItem and the <paramref name="ReferenceKind"/> parameter is set to wdNumberFullContext.)</param><param name="SeparatorString">Optional Object. Specifies the string to use as a separator if the SeparateNumbers parameter is set to True.</param>
		[DispId(418)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertCrossReference([MarshalAs(UnmanagedType.Struct), In] ref object ReferenceType, [In] WdReferenceKind ReferenceKind, [MarshalAs(UnmanagedType.Struct), In] ref object ReferenceItem, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsHyperlink, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludePosition, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SeparateNumbers, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SeparatorString);

		/// <summary>
		/// Exports the selected range into a document for use as a document fragment.
		/// </summary>
		/// <param name="FileName">Required String Specifies the path and file name of the file in which to save the document  fragment.</param><param name="Format">Required <see cref="T:Microsoft.Office.Interop.Word.WdSaveFormat"/> Specifies the file format of the document fragment file. You can save a document fragment in any format that Microsoft Office Word supports.</param>
		[DispId(425)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ExportFragment([MarshalAs(UnmanagedType.BStr), In] string FileName, [In] WdSaveFormat Format);

		/// <summary>
		/// Sets the list level for one or more items in a numbered list.
		/// </summary>
		/// <param name="Level">Required Short A number that indicates the new list level.</param>
		[DispId(427)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetListLevel([In] short Level);

		/// <summary>
		/// Inserts an absolute tab that is always positioned in the same spot, relative to either the margins or indents.
		/// </summary>
		/// <param name="Alignment">Required Integer Indicates the type of alignment—left, center, or right—for the tab stop. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdAlignmentTabAlignment"/> constants.</param><param name="RelativeTo">Required Integer Indicates whether the tab stop is relative to the margins or to the paragraph indents. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdAlignmentTabRelative"/> constants.</param>
		[DispId(500)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertAlignmentTab([In] int Alignment, [In] int RelativeTo = 0);

		/// <summary>
		/// Imports a document fragment into the document at the specified range.
		/// </summary>
		/// <param name="FileName">Required String Specifies the path and file name where the document fragment is stored.</param><param name="MatchDestination">Optional Boolean Specifies whether to match the destination formatting. If False, the imported document fragment retains the formatting in the original document. Default value is False.</param>
		[DispId(502)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ImportFragment([MarshalAs(UnmanagedType.BStr), In] string FileName, [In] bool MatchDestination = false);

		/// <summary>
		/// Saves  a portion of a document as  PDF or XPS format.
		/// </summary>
		/// <param name="OutputFileName">Required String The path and file name of the new PDF or XPS file.</param><param name="ExportFormat">Required <see cref="T:Microsoft.Office.Interop.Word.WdExportFormat"/> Specifies either PDF or XPS format.</param><param name="OpenAfterExport">Optional Boolean Opens the new file after exporting the contents.</param><param name="OptimizeFor">Optional <see cref="T:Microsoft.Office.Interop.Word.WdExportOptimizeFor"/> Specifies whether to optimize for screen or print.</param><param name="ExportCurrentPage">Optional Boolean Specifies whether to export the current page.  True exports the entire page. False exports only the current selection.</param><param name="Item">Optional <see cref="T:Microsoft.Office.Interop.Word.WdExportItem"/> Specifies whether the export process includes text only or includes text with markup.</param><param name="IncludeDocProps">Optional Boolean Specifies whether to include document properties in the newly exported file.</param><param name="KeepIRM">Optional Boolean Specifies whether to copy IRM permissions to an XPS document if the source document has IRM protections. Default value is True.</param><param name="CreateBookmarks">Optional <see cref="T:Microsoft.Office.Interop.Word.WdExportCreateBookmarks"/> Specifies whether to export bookmarks and the type of bookmarks to export.</param><param name="DocStructureTags">Optional Boolean Specifies whether to include extra data to help screen readers, for example information about the flow and logical organization of the content. Default value is  True.</param><param name="BitmapMissingFonts">Optional Boolean Specifies whether to include a bitmap of the text. Set this parameter to True when font licenses do not permit a font to be embedded in the PDF file. If False, the font is referenced, and the viewer's computer substitutes an appropriate font if the authored one is not available. Default value is  True.</param><param name="UseISO19005_1">Optional Boolean  Specifies whether to limit PDF usage to the PDF subset standardized as ISO 19005-1. If True, the resulting files are more reliably self-contained but may be larger or show more visual artifacts due to the restrictions of the format. Default value is  False.</param><param name="FixedFormatExtClassPtr">Optional Object Specifies a pointer to an add-in that allows calls to an alternate implementation of code.  The alternate implementation of code interprets the EMF and EMF+ page descriptions that are generated by the applications to make their own PDF or XPS. For more information, see "Extending the Office (2007) Fixed-Format Export Feature" on MSDN.</param>
		[DispId(503)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ExportAsFixedFormat([MarshalAs(UnmanagedType.BStr), In] string OutputFileName, [In] WdExportFormat ExportFormat, [In] bool OpenAfterExport = false, [In] WdExportOptimizeFor OptimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint, [In] bool ExportCurrentPage = false, [In] WdExportItem Item = WdExportItem.wdExportDocumentContent, [In] bool IncludeDocProps = false, [In] bool KeepIRM = true, [In] WdExportCreateBookmarks CreateBookmarks = WdExportCreateBookmarks.wdExportCreateNoBookmarks, [In] bool DocStructureTags = true, [In] bool BitmapMissingFonts = true, [In] bool UseISO19005_1 = false, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FixedFormatExtClassPtr);

		/// <summary>
		/// Returns or sets the text in the specified range.
		/// </summary>
		[DispId(0)]
		string Text { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that includes the formatted text in the specified range or selection.
		/// </summary>
		[DispId(2)]
		Range FormattedText { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the starting character position of a range.
		/// </summary>
		[DispId(3)]
		int Start { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the ending character position of a range.
		/// </summary>
		[DispId(4)]
		int End { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.Font"/> object that represents the character formatting of the specified object.
		/// </summary>
		[DispId(5)]
		Font Font { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that represents all the properties of the specified range.
		/// </summary>
		[DispId(6)]
		Range Duplicate { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the story type for the specified range.
		/// </summary>
		[DispId(7)]
		WdStoryType StoryType { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Tables"/> collection that represents all the tables in the specified range.
		/// </summary>
		[DispId(50)]
		Tables Tables { [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Words"/> collection that represents all the words in a range.
		/// </summary>
		[DispId(51)]
		Words Words { [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Sentences"/> collection that represents all the sentences in the range.
		/// </summary>
		[DispId(52)]
		Sentences Sentences { [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Characters"/> collection that represents the characters in a range.
		/// </summary>
		[DispId(53)]
		Characters Characters { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Footnotes"/> collection that represents all the footnotes in a range.
		/// </summary>
		[DispId(54)]
		Footnotes Footnotes { [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Endnotes"/> collection that represents all the endnotes in a range.
		/// </summary>
		[DispId(55)]
		Endnotes Endnotes { [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Comments"/> collection that represents all the comments in the specified range.
		/// </summary>
		[DispId(56)]
		Comments Comments { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Cells"/> collection that represents the table cells in a range.
		/// </summary>
		[DispId(57)]
		Cells Cells { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Sections"/> collection that represents the sections in the specified range.
		/// </summary>
		[DispId(58)]
		Sections Sections { [DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Paragraphs"/> collection that represents all the paragraphs in the specified range.
		/// </summary>
		[DispId(59)]
		Paragraphs Paragraphs { [DispId(59), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Borders"/> collection that represents all the borders for the specified object.
		/// </summary>
		[DispId(1100)]
		Borders Borders { [DispId(1100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(1100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Shading"/> object that refers to the shading formatting for the specified object.
		/// </summary>
		[DispId(61)]
		Shading Shading { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.TextRetrievalMode"/> object that controls how text is retrieved from the specified range.
		/// </summary>
		[DispId(62)]
		TextRetrievalMode TextRetrievalMode { [DispId(62), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(62), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a read-only <see cref="T:Microsoft.Office.Interop.Word.Fields"/> collection that represents all the fields in the range.
		/// </summary>
		[DispId(64)]
		Fields Fields { [DispId(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.FormFields"/> collection that represents all the form fields in the range.
		/// </summary>
		[DispId(65)]
		FormFields FormFields { [DispId(65), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Frames"/> collection that represents all the frames in a range.
		/// </summary>
		[DispId(66)]
		Frames Frames { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.ParagraphFormat"/> object that represents the paragraph settings for the specified range.
		/// </summary>
		[DispId(1102)]
		ParagraphFormat ParagraphFormat { [DispId(1102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(1102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ListFormat"/> object that represents all the list formatting characteristics of a range.
		/// </summary>
		[DispId(68)]
		ListFormat ListFormat { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Bookmarks"/> collection that represents all the bookmarks in a range.
		/// </summary>
		[DispId(75)]
		Bookmarks Bookmarks { [DispId(75), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.Application"/> object that represents the Microsoft Word application.
		/// </summary>
		[DispId(1000)]
		Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a 32-bit integer that indicates the application in which the specified object was created.
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
		/// Determines if the font or range is formatted as bold.
		/// </summary>
		[DispId(130)]
		int Bold { [DispId(130), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(130), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if the range is formatted as italic.
		/// </summary>
		[DispId(131)]
		int Italic { [DispId(131), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(131), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the type of underline applied to the range.
		/// </summary>
		[DispId(139)]
		WdUnderline Underline { [DispId(139), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(139), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the emphasis mark for a character or designated character string.
		/// </summary>
		[DispId(140)]
		WdEmphasisMark EmphasisMark { [DispId(140), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(140), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word ignores the number of characters per line for the range.
		/// </summary>
		[DispId(141)]
		bool DisableCharacterSpaceGrid { [DispId(141), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(141), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Revisions"/> collection that represents the tracked changes in the range.
		/// </summary>
		[DispId(150)]
		Revisions Revisions { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the style for the specified object.
		/// </summary>
		[DispId(151)]
		object Style { [DispId(151), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(151), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the number of characters in the story that contains the specified range.
		/// </summary>
		[DispId(152)]
		int StoryLength { [DispId(152), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the language for the specified object.
		/// </summary>
		[DispId(153)]
		WdLanguageID LanguageID { [DispId(153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.SynonymInfo"/> object that contains information from the thesaurus on synonyms, antonyms, or related words and expressions for the specified word or phrase.
		/// </summary>
		[DispId(155)]
		SynonymInfo SynonymInfo { [DispId(155), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Hyperlinks"/> collection that represents all the hyperlinks in the specified range.
		/// </summary>
		[DispId(156)]
		Hyperlinks Hyperlinks { [DispId(156), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ListParagraphs"/> collection that represents all the numbered paragraphs in the range.
		/// </summary>
		[DispId(157)]
		ListParagraphs ListParagraphs { [DispId(157), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Subdocuments"/> collection that represents all the subdocuments in the specified range.
		/// </summary>
		[DispId(159)]
		Subdocuments Subdocuments { [DispId(159), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if a grammar check has been run on the specified range.
		/// </summary>
		[DispId(260)]
		bool GrammarChecked { [DispId(260), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(260), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if spelling has been checked throughout the specified range.
		/// </summary>
		[DispId(261)]
		bool SpellingChecked { [DispId(261), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(261), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the highlight color for the specified range.
		/// </summary>
		[DispId(301)]
		WdColorIndex HighlightColorIndex { [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Columns"/> collection that represents all the table columns in the range.
		/// </summary>
		[DispId(302)]
		Columns Columns { [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Rows"/> collection that represents all the table rows in a range.
		/// </summary>
		[DispId(303)]
		Rows Rows { [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		[DispId(304)]
		int CanEdit { [DispId(304), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		[DispId(305)]
		int CanPaste { [TypeLibFunc(64), DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the specified range is collapsed and is located at the end-of-row mark in a table.
		/// </summary>
		[DispId(307)]
		bool IsEndOfRowMark { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the number of the bookmark that encloses the beginning of the specified selection or range; returns 0 (zero) if there's no corresponding bookmark.
		/// </summary>
		[DispId(308)]
		int BookmarkID { [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the number of the last bookmark that starts before or at the same place as the specified range.
		/// </summary>
		[DispId(309)]
		int PreviousBookmarkID { [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Find"/> object that contains the criteria for a find operation.
		/// </summary>
		[DispId(262)]
		Find Find { [DispId(262), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.PageSetup"/> object that's associated with the specified range.
		/// </summary>
		[DispId(1101)]
		PageSetup PageSetup { [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ShapeRange"/> collection that represents all the <see cref="T:Microsoft.Office.Interop.Word.Shape"/> objects in the specified range.
		/// </summary>
		[DispId(311)]
		Microsoft.Office.Interop.Word.ShapeRange ShapeRange { [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.WdCharacterCase"/> constant that represents the case of the text in the specified range.
		/// </summary>
		[DispId(312)]
		WdCharacterCase Case { [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		[DispId(313)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object get_Information([In] WdInformation Type);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ReadabilityStatistics"/> collection that represents the readability statistics for the specified range.
		/// </summary>
		[DispId(314)]
		ReadabilityStatistics ReadabilityStatistics { [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ProofreadingErrors"/> collection that represents the sentences that failed the grammar check on the specified range.
		/// </summary>
		[DispId(315)]
		ProofreadingErrors GrammaticalErrors { [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ProofreadingErrors"/> collection that represents the words identified as spelling errors in the specified range.
		/// </summary>
		[DispId(316)]
		ProofreadingErrors SpellingErrors { [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the orientation of text in a range when the Text Direction feature is enabled.
		/// </summary>
		[DispId(317)]
		WdTextOrientation Orientation { [DispId(317), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(317), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.InlineShapes"/> collection that represents all the <see cref="T:Microsoft.Office.Interop.Word.InlineShape"/> objects in a document, range, or selection.
		/// </summary>
		[DispId(319)]
		InlineShapes InlineShapes { [DispId(319), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that refers to the next story as shown in the following table.
		/// </summary>
		[DispId(320)]
		Range NextStoryRange { [DispId(320), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an East Asian language for the specified object.
		/// </summary>
		[DispId(321)]
		WdLanguageID LanguageIDFarEast { [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the language for the specified object.
		/// </summary>
		[DispId(322)]
		WdLanguageID LanguageIDOther { [DispId(322), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(322), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a value that specifies whether Microsoft Word has detected the language of the specified text.
		/// </summary>
		[DispId(263)]
		bool LanguageDetected { [DispId(263), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(263), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the width (in the current measurement units) in which Microsoft Word fits the text in the current range.
		/// </summary>
		[DispId(264)]
		float FitTextWidth { [DispId(264), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(264), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the formatting for horizontal text set within vertical text.
		/// </summary>
		[DispId(265)]
		WdHorizontalInVerticalType HorizontalInVertical { [DispId(265), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(265), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets whether Microsoft Word sets two lines of text in one and specifies the characters that enclose the text, if any.
		/// </summary>
		[DispId(266)]
		WdTwoLinesInOneType TwoLinesInOne { [DispId(266), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(266), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if the specified range contains combined characters.
		/// </summary>
		[DispId(267)]
		bool CombineCharacters { [DispId(267), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(267), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if the spelling and grammar checker ignores the specified text.
		/// </summary>
		[DispId(323)]
		int NoProofing { [DispId(323), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(323), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Tables"/> collection that represents the tables at the outermost nesting level in the current range.
		/// </summary>
		[DispId(324)]
		Tables TopLevelTables { [DispId(324), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.Scripts"/> collection that represents the collection of HTML scripts in the specified object.
		/// </summary>
		[DispId(325)]
		Scripts Scripts { [DispId(325), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the character width of the specified range.
		/// </summary>
		[DispId(326)]
		WdCharacterWidth CharacterWidth { [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets whether the specified range of Japanese language text is hiragana or katakana.
		/// </summary>
		[DispId(327)]
		WdKana Kana { [DispId(327), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(327), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if the font or range is formatted as bold.
		/// </summary>
		/// 
		/// <returns>
		/// .
		/// </returns>
		[DispId(400)]
		int BoldBi { [DispId(400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if the range is formatted as italic.
		/// </summary>
		[DispId(401)]
		int ItalicBi { [DispId(401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the identifying label for the specified object when the current document is saved as a Web page.
		/// </summary>
		[DispId(405)]
		string ID { [DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.HTMLDivisions"/> object that represents an HTML division in a Web document.
		/// </summary>
		[DispId(406)]
		HTMLDivisions HTMLDivisions { [DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.SmartTags"/> object that represents a smart tag in a range.
		/// </summary>
		[DispId(407)]
		SmartTags SmartTags { [TypeLibFunc(64), DispId(407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if all nonprinting characters (such as hidden text, tab marks, space marks, and paragraph marks) are displayed.
		/// </summary>
		[DispId(408)]
		bool ShowAll { [DispId(408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Document"/> object associated with the specified range.
		/// </summary>
		[DispId(409)]
		Document Document { [DispId(409), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.FootnoteOptions"/> object that represents the footnote options in a range.
		/// </summary>
		[DispId(410)]
		FootnoteOptions FootnoteOptions { [DispId(410), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.EndnoteOptions"/> object that represents the endnotes in a range or selection.
		/// </summary>
		[DispId(411)]
		EndnoteOptions EndnoteOptions { [DispId(411), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.XMLNodes"/> collection that represents the collection of all XML elements within a document or in a range— including those elements that are only partially within the range.
		/// </summary>
		[DispId(340)]
		XMLNodes XMLNodes { [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.XMLNode"/> object that represents the parent node of a selection or range.
		/// </summary>
		[DispId(341)]
		XMLNode XMLParentNode { [DispId(341), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.Editors"/> object that represents all the users authorized to modify a selection or range within a document.
		/// </summary>
		[DispId(343)]
		Editors Editors { [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		[DispId(344)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string get_XML([In] bool DataOnly = false);

		/// <summary>
		/// Returns a picture representation of how a selection or range of text appears.
		/// </summary>
		[DispId(345)]
		object EnhMetaFileBits { [DispId(345), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.OMaths"/> collection that represents the <see cref="T:Microsoft.Office.Interop.Word.OMath"/> objects within the specified range. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.OMaths"/>
		/// </returns>
		[DispId(346)]
		OMaths OMaths { [DispId(346), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Object that represents the style used to format one or more characters. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(420)]
		object CharacterStyle { [DispId(420), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Object that represents the style used to format a paragraph. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(421)]
		object ParagraphStyle { [DispId(421), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Object that represents the style used to format a bulleted list or numbered list. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(422)]
		object ListStyle { [DispId(422), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Object that represents the style used to format a table. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Object
		/// </returns>
		[DispId(423)]
		object TableStyle { [DispId(423), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/> collection that represents the content controls contained within a range. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/>
		/// </returns>
		[DispId(424)]
		ContentControls ContentControls { [DispId(424), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String that represents the XML contained within the range in the Microsoft Office Word Open XML format. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(426)]
		string WordOpenXML { [DispId(426), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ContentControl"/> object that represents the parent content control for the specified range. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControl"/>
		/// </returns>
		[DispId(501)]
		ContentControl ParentContentControl { [DispId(501), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.CoAuthLocks"/> collection object that represents all the locks in the range.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.CoAuthLocks"/> collection object that represents all the locks in the range.
		/// </returns>
		[DispId(504)]
		CoAuthLocks Locks { [DispId(504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.CoAuthUpdates"/> collection object that represents all the available updates in the range.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.CoAuthUpdates"/> collection object that represents all the available updates in the range.
		/// </returns>
		[DispId(505)]
		CoAuthUpdates Updates { [DispId(505), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.Conflicts"/> collection object that contains all the conflict objects in the range.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.Conflicts"/> collection object that contains all the conflict objects in the range.
		/// </returns>
		[DispId(506)]
		Conflicts Conflicts { [DispId(506), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
