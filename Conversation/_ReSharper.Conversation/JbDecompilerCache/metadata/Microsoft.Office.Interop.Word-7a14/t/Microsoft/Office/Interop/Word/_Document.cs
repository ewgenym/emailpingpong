// Type: Microsoft.Office.Interop.Word._Document
// Assembly: Microsoft.Office.Interop.Word, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using Microsoft.Vbe.Interop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word
{
	/// <summary>
	/// Represents a document.
	/// </summary>
	[TypeLibType(4176)]
	[Guid("0002096B-0000-0000-C000-000000000046")]
	[ComImport]
	public interface _Document
	{
		/// <summary>
		/// Closes the specified document or documents.
		/// </summary>
		/// <param name="SaveChanges">Optional Object. Specifies the save action for the document. Can be one of the following <see cref="T:Microsoft.Office.Interop.Word.WdSaveOptions"/> constants: wdDoNotSaveChanges, wdPromptToSaveChanges, or wdSaveChanges.</param><param name="OriginalFormat">Optional Object. Specifies the save format for the document. Can be one of the following <see cref="T:Microsoft.Office.Interop.Word.WdOriginalFormat"/> constants: wdOriginalDocumentFormat, wdPromptUser, or wdWordDocument.</param><param name="RouteDocument">Optional Object. True to route the document to the next recipient. If the document doesn't have a routing slip attached, this argument is ignored.</param>
		[DispId(1105)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Close([MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);

		/// <param name="FileName"/><param name="FileFormat"/><param name="LockComments"/><param name="Password"/><param name="AddToRecentFiles"/><param name="WritePassword"/><param name="ReadOnlyRecommended"/><param name="EmbedTrueTypeFonts"/><param name="SaveNativePictureFormat"/><param name="SaveFormsData"/><param name="SaveAsAOCELetter"/>
		[DispId(102)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SaveAs2000([MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LockComments, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePassword, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnlyRecommended, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EmbedTrueTypeFonts, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveNativePictureFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveFormsData, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveAsAOCELetter);

		/// <summary>
		/// Repaginates the entire document.
		/// </summary>
		[DispId(103)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Repaginate();

		/// <summary>
		/// Decreases the font size of text just enough so that the document will fit on one fewer pages.
		/// </summary>
		[DispId(104)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void FitToPages();

		/// <summary>
		/// Initiates manual hyphenation of a document, one line at a time. The user is prompted to accept or decline suggested hyphenations.
		/// </summary>
		[DispId(105)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ManualHyphenation();

		/// <summary>
		/// Selects the specified object.
		/// </summary>
		[DispId(65535)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Select();

		/// <summary>
		/// Displays the Data Form dialog box, in which you can add, delete, or modify data records.
		/// </summary>
		[DispId(106)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DataForm();

		/// <summary>
		/// Routes the specified document, using the document's current routing slip.
		/// </summary>
		[TypeLibFunc(64)]
		[DispId(107)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Route();

		/// <summary>
		/// Saves the specified document. If the document hasn't been saved before, the Save As dialog box prompts the user for a file name.
		/// </summary>
		[DispId(108)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Save();

		/// <param name="Background"/><param name="Append"/><param name="Range"/><param name="OutputFileName"/><param name="From"/><param name="To"/><param name="Item"/><param name="Copies"/><param name="Pages"/><param name="PageType"/><param name="PrintToFile"/><param name="Collate"/><param name="ActivePrinterMacGX"/><param name="ManualDuplexPrint"/>
		[TypeLibFunc(64)]
		[DispId(109)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PrintOutOld([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Background, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Append, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OutputFileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Item, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Copies, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pages, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintToFile, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Collate, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint);

		/// <summary>
		/// Opens a message window for sending the specified document through Microsoft Exchange.
		/// </summary>
		[DispId(110)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SendMail();

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object by using the specified starting and ending character positions.
		/// </summary>
		/// <param name="Start">Optional Object. The starting character position.</param><param name="End">Optional Object. The ending character position.</param>
		[DispId(2000)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range Range([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object End);

		/// <summary>
		/// Runs an auto macro that's stored in the specified document. If the specified auto macro doesn't exist, nothing happens.
		/// </summary>
		/// <param name="Which">Required <see cref="T:Microsoft.Office.Interop.Word.WdAutoMacros"/>.</param>
		[DispId(112)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RunAutoMacro([In] WdAutoMacros Which);

		/// <summary>
		/// Activates the specified object.
		/// </summary>
		[DispId(113)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Activate();

		/// <summary>
		/// Switches the view to print preview.
		/// </summary>
		[DispId(114)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PrintPreview();

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that represents the start position of the specified item.
		/// </summary>
		/// <param name="What">Optional Object. The kind of item to which the range or selection is moved. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdGoToItem"/> constants.</param><param name="Which">Optional Object. The item to which the range or selection is moved. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdGoToDirection"/> constants.</param><param name="Count">Optional Object. The number of the item in the document. The default value is 1.Only positive values are valid. To specify an item that precedes the range or selection, use wdGoToPrevious as the <paramref name="Which"/> argument and specify a <paramref name="Count"/> value.</param><param name="Name">Optional Object. If the <paramref name="What"/> argument is wdGoToBookmark, wdGoToComment, wdGoToField, or wdGoToObject, this argument specifies a name.</param>
		[DispId(115)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range GoTo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object What, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Which, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name);

		/// <summary>
		/// Undoes the last action or a sequence of actions, which are displayed in the Undo list. Returns True if the actions were successfully undone.
		/// </summary>
		/// <param name="Times">Optional Object. The number of actions to be undone.</param>
		[DispId(116)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool Undo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

		/// <summary>
		/// Redoes the last action that was undone (reverses the <see cref="M:Microsoft.Office.Interop.Word._Document.Undo(System.Object@)"/> method). Returns True if the actions were redone successfully.
		/// </summary>
		/// <param name="Times">Optional Object. The number of actions to be redone.</param>
		[DispId(117)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool Redo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

		/// <summary>
		/// Returns a statistic based on the contents of the specified document.
		/// </summary>
		/// <param name="Statistic">Required <see cref="T:Microsoft.Office.Interop.Word.WdStatistic"/>.</param><param name="IncludeFootnotesAndEndnotes">Optional Object. True to include footnotes and endnotes when computing statistics. If this argument is omitted, the default value is False.</param>
		[DispId(118)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int ComputeStatistics([In] WdStatistic Statistic, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeFootnotesAndEndnotes);

		/// <summary>
		/// Sets the compatibility options on the Compatibility tab in the Options dialog box (Tools menu) as the default settings for new documents.
		/// </summary>
		[DispId(119)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void MakeCompatibilityDefault();

		/// <param name="Type"/><param name="NoReset"/><param name="Password"/>
		[DispId(120)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Protect2002([In] WdProtectionType Type, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoReset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password);

		/// <summary>
		/// Removes protection from the specified document. If the document isn't protected, this method generates an error.
		/// </summary>
		/// <param name="Password">Optional Object. The password string used to protect the document. Passwords are case-sensitive. If the document is protected with a password and the correct password isn't supplied, a dialog box prompts the user for the password.</param>
		[DispId(121)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password);

		/// <param name="Type"/><param name="Option"/><param name="Name"/><param name="Format"/>
		[DispId(122)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EditionOptions([In] WdEditionType Type, [In] WdEditionOption Option, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format);

		/// <summary>
		/// Runs the Letter Wizard on the specified document.
		/// </summary>
		/// <param name="LetterContent">Optional Object. A <see cref="T:Microsoft.Office.Interop.Word.LetterContent"/> object. Any filled properties in the LetterContent object show up as prefilled elements in the Letter Wizard dialog boxes. If this argument is omitted, the <see cref="M:Microsoft.Office.Interop.Word._Document.GetLetterContent"/> method is automatically used to get a LetterContent object from the specified document.</param><param name="WizardMode">Optional Object. True to display the Letter Wizard dialog box as a series of steps with a Next, Back, and Finish button. False to display the Letter Wizard dialog box as if it were opened from the Tools menu (a properties dialog box with an OK button and a Cancel button). The default value is True.</param>
		[DispId(123)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RunLetterWizard([MarshalAs(UnmanagedType.Struct), In, Optional] ref object LetterContent, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WizardMode);

		/// <summary>
		/// Retrieves letter elements from the specified document and returns a <see cref="T:Microsoft.Office.Interop.Word.LetterContent"/> object.
		/// </summary>
		[DispId(124)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		LetterContent GetLetterContent();

		/// <summary>
		/// Inserts the contents of the specified <see cref="T:Microsoft.Office.Interop.Word.LetterContent"/> object into a document.
		/// </summary>
		/// <param name="LetterContent">Required <see cref="LetterContent"/> object. The LetterContent object that includes the various elements of the letter.</param>
		[DispId(125)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetLetterContent([MarshalAs(UnmanagedType.Struct), In] ref object LetterContent);

		/// <summary>
		/// Copies styles from the specified template to a document.
		/// </summary>
		/// <param name="Template">Required String. The template file name.</param>
		[DispId(126)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CopyStylesFromTemplate([MarshalAs(UnmanagedType.BStr), In] string Template);

		/// <summary>
		/// Copies all styles from the attached template into the document, overwriting any existing styles in the document that have the same name.
		/// </summary>
		[DispId(127)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UpdateStyles();

		/// <summary>
		/// Begins a spelling and grammar check for the specified document or range.
		/// </summary>
		[DispId(131)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckGrammar();

		/// <summary>
		/// Begins a spelling check for the specified document or range.
		/// </summary>
		/// <param name="CustomDictionary">Optional Object. Either an expression that returns a <see cref="T:Microsoft.Office.Interop.Word.Dictionary"/> object or the file name of the custom dictionary.</param><param name="IgnoreUppercase">Optional Object. True if capitalization is ignored. If this argument is omitted, the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.IgnoreUppercase"/> property is used.</param><param name="AlwaysSuggest">Optional Object. True for Microsoft Word to always suggest alternative spellings. If this argument is omitted, the current value of the <see cref="P:Microsoft.Office.Interop.Word.Options.SuggestSpellingCorrections"/> property is used.</param><param name="CustomDictionary2">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary3">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary4">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary5">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary6">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary7">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary8">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary9">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param><param name="CustomDictionary10">Optional Object. Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
		[DispId(132)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckSpelling([MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreUppercase, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AlwaysSuggest, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary4, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary5, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary6, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary7, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary8, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary9, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary10);

		/// <summary>
		/// Displays a cached document if it's already been downloaded. Otherwise, this method resolves the hyperlink, downloads the target document, and displays the document in the appropriate application.
		/// </summary>
		/// <param name="Address">Required String. The address of the target document.</param><param name="SubAddress">Optional Object. The location within the target document. The default value is an empty string.</param><param name="NewWindow">Optional Object. True to display the target location in a new window. The default value is False.</param><param name="AddHistory">Optional Object. True to add the link to the current day's history folder.</param><param name="ExtraInfo">Optional Object. A string or a byte array that specifies additional information for HTTP to use to resolve the hyperlink. For example, you can use <paramref name="ExtraInfo"/> to specify the coordinates of an image map, the contents of a form, or a FAT file name. The string is either posted or appended, depending on the value of <paramref name="Method"/>. Use the <see cref="P:Microsoft.Office.Interop.Word.Hyperlink.ExtraInfoRequired"/> property to determine whether extra information is required.</param><param name="Method">Optional Object. Specifies the way additional information for HTTP is handled. <see cref="T:Microsoft.Office.Core.MsoExtraInfoMethod"/>.</param><param name="HeaderInfo">Optional Object. A string that specifies header information for the HTTP request. The default value is an empty string. You can combine several header lines into a single string. The specified string is automatically converted into ANSI characters. Note that the <paramref name="HeaderInfo"/> argument may overwrite default HTTP header fields.</param>
		[DispId(135)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void FollowHyperlink([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubAddress, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NewWindow, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddHistory, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtraInfo, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Method, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HeaderInfo);

		/// <summary>
		/// Creates a shortcut to the document or hyperlink and adds it to the Favorites folder.
		/// </summary>
		[DispId(136)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddToFavorites();

		/// <summary>
		/// Reloads a cached document by resolving the hyperlink to the document and downloading it.
		/// </summary>
		[DispId(137)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Reload();

		/// <summary>
		/// Creates an automatic summary of the specified document, and returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object.
		/// </summary>
		/// <param name="Length">Optional Object. The length of the summary as a percentage of the total document length (the larger the number, the more detail that's included in the summary).</param><param name="Mode">Optional Object. Specifies the way the summary is displayed. Can be one of the <see cref="T:Microsoft.Office.Interop.Word.WdSummaryMode"/> constants.</param><param name="UpdateProperties">Optional Object. True to update the Keyword and Comments boxes in the Properties dialog box to reflect the content of the summary for the specified document.</param>
		[DispId(138)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Range AutoSummarize([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Length, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Mode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UpdateProperties);

		/// <summary>
		/// Removes numbers or bullets from the specified object.
		/// </summary>
		/// <param name="NumberType">Optional <see cref="T:Microsoft.Office.Interop.Word.WdNumberType"/>. The type of number to be removed.</param>
		[DispId(140)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveNumbers([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

		/// <summary>
		/// Changes the list numbers and LISTNUM fields in the specified object to text.
		/// </summary>
		/// <param name="NumberType">Optional Object. The type of number to be converted. Can be any of the <see cref="T:Microsoft.Office.Interop.Word.WdNumberType"/> constants.</param>
		[DispId(141)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ConvertNumbersToText([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

		/// <summary>
		/// Returns the number of bulleted or numbered items and LISTNUM fields in the specified object.
		/// </summary>
		/// <param name="NumberType">Optional Object. The type of numbers to be counted. Can be one of the following <see cref="T:Microsoft.Office.Interop.Word.WdNumberType"/> constants: wdNumberParagraph, wdNumberListNum, or wdNumberAllNumbers. The default value is wdNumberAllNumbers.</param><param name="Level">Optional Object. A number that corresponds to the numbering level you want to count. If this argument is omitted, all levels are counted.</param>
		[DispId(142)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int CountNumberedItems([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

		/// <summary>
		/// Posts the specified document to a public folder in Microsoft Exchange. This method displays the Send to Exchange Folder dialog box so that a folder can be selected.
		/// </summary>
		[DispId(143)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Post();

		/// <summary>
		/// Toggles form design mode on or off.
		/// </summary>
		[DispId(144)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ToggleFormsDesign();

		/// <param name="Name"/>
		[TypeLibFunc(64)]
		[DispId(145)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Compare2000([MarshalAs(UnmanagedType.BStr), In] string Name);

		/// <summary>
		/// Updates the keyword and comment text in the Properties dialog box (File menu) to reflect the AutoSummary content for the specified document.
		/// </summary>
		[DispId(146)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UpdateSummaryProperties();

		/// <summary>
		/// Returns an array of items that can be cross-referenced based on the specified cross-reference type.
		/// </summary>
		/// <param name="ReferenceType">Required Object. The type of item you want to insert a cross-reference to. <see cref="T:Microsoft.Office.Interop.Word.WdReferenceType"/>.</param>
		[DispId(147)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object GetCrossReferenceItems([MarshalAs(UnmanagedType.Struct), In] ref object ReferenceType);

		/// <summary>
		/// Automatically formats a document.
		/// </summary>
		[DispId(148)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AutoFormat();

		/// <summary>
		/// Displays the code window for the selected ActiveX control in the specified document.
		/// </summary>
		[DispId(149)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ViewCode();

		/// <summary>
		/// Displays the property window for the selected ActiveX control in the specified document.
		/// </summary>
		[DispId(150)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ViewPropertyBrowser();

		[DispId(250)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ForwardMailer();

		/// <summary>
		/// Opens a new e-mail message— with the sender's address on the To: line— for replying to the active message.
		/// </summary>
		[DispId(251)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Reply();

		/// <summary>
		/// Opens a new e-mail message— with the sender’s and all other recipients' addresses on the To: and Cc: lines, as appropriate— for replying to the active message.
		/// </summary>
		[DispId(252)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ReplyAll();

		/// <param name="FileFormat"/><param name="Priority"/>
		[DispId(253)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SendMailer([MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Priority);

		/// <summary>
		/// Clears the list of actions that can be undone for the specified document. Corresponds to the list of items that appears when you click the arrow beside the Undo button on the Standard toolbar.
		/// </summary>
		[DispId(254)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UndoClear();

		/// <summary>
		/// Opens PowerPoint with the specified Word document loaded.
		/// </summary>
		[DispId(255)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PresentIt();

		/// <summary>
		/// Sends the specified document as a fax, without any user interaction.
		/// </summary>
		/// <param name="Address">Required String. The recipient's fax number.</param><param name="Subject">Optional Object. The text for the subject line. The character limit is 255.</param>
		[DispId(256)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SendFax([MarshalAs(UnmanagedType.BStr), In] string Address, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject);

		/// <param name="FileName"/>
		[DispId(257)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Merge2000([MarshalAs(UnmanagedType.BStr), In] string FileName);

		/// <summary>
		/// Switches the specified document from print preview to the previous view. If the specified document isn't in print preview, an error occurs.
		/// </summary>
		[DispId(258)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ClosePrintPreview();

		/// <summary>
		/// Searches all text in a Japanese language document and displays instances where character usage is inconsistent for the same words.
		/// </summary>
		[DispId(259)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckConsistency();

		/// <summary>
		/// Creates and returns a <see cref="T:Microsoft.Office.Interop.Word.LetterContent"/> object based on the specified letter elements.
		/// </summary>
		/// <param name="DateFormat">Required String. The date for the letter.</param><param name="IncludeHeaderFooter">Required Boolean. True to include the header and footer from the page design template.</param><param name="PageDesign">Required String. The name of the template attached to the document.</param><param name="LetterStyle">Required <see cref="T:Microsoft.Office.Interop.Word.WdLetterStyle"/>. The document layout.</param><param name="Letterhead">Required Boolean. True to reserve space for a preprinted letterhead.</param><param name="LetterheadLocation">Required <see cref="T:Microsoft.Office.Interop.Word.WdLetterheadLocation"/>. The location of the preprinted letterhead.</param><param name="LetterheadSize">Required Single. The amount of space (in points) to be reserved for a preprinted letterhead.</param><param name="RecipientName">Required String. The name of the person who'll be receiving the letter.</param><param name="RecipientAddress">Required String. The mailing address of the person who'll be receiving the letter.</param><param name="Salutation">Required String. The salutation text for the letter.</param><param name="SalutationType">Required <see cref="T:Microsoft.Office.Interop.Word.WdSalutationType"/>. The salutation type for the letter.</param><param name="RecipientReference">Required String. The reference line text for the letter (for example, "In reply to:").</param><param name="MailingInstructions">Required String. The mailing instruction text for the letter (for example, "Certified Mail").</param><param name="AttentionLine">Required String. The attention line text for the letter (for example, "Attention:").</param><param name="Subject">Required String. The subject text for the specified letter.</param><param name="CCList">Required String. The names of the carbon copy (CC) recipients for the letter.</param><param name="ReturnAddress">Required String. The text of the return mailing address for the letter.</param><param name="SenderName">Required String. The name of the person sending the letter.</param><param name="Closing">Required String. The closing text for the letter.</param><param name="SenderCompany">Required String. The company name of the person creating the letter.</param><param name="SenderJobTitle">Required String. The job title of the person creating the letter.</param><param name="SenderInitials">Required String. The initials of the person creating the letter.</param><param name="EnclosureNumber">Required Integer. The number of enclosures for the letter.</param><param name="InfoBlock">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="RecipientCode">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="RecipientGender">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="ReturnAddressShortForm">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="SenderCity">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="SenderCode">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="SenderGender">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="SenderReference">Optional Object. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param>
		[DispId(260)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		LetterContent CreateLetterContent([MarshalAs(UnmanagedType.BStr), In] string DateFormat, [In] bool IncludeHeaderFooter, [MarshalAs(UnmanagedType.BStr), In] string PageDesign, [In] WdLetterStyle LetterStyle, [In] bool Letterhead, [In] WdLetterheadLocation LetterheadLocation, [In] float LetterheadSize, [MarshalAs(UnmanagedType.BStr), In] string RecipientName, [MarshalAs(UnmanagedType.BStr), In] string RecipientAddress, [MarshalAs(UnmanagedType.BStr), In] string Salutation, [In] WdSalutationType SalutationType, [MarshalAs(UnmanagedType.BStr), In] string RecipientReference, [MarshalAs(UnmanagedType.BStr), In] string MailingInstructions, [MarshalAs(UnmanagedType.BStr), In] string AttentionLine, [MarshalAs(UnmanagedType.BStr), In] string Subject, [MarshalAs(UnmanagedType.BStr), In] string CCList, [MarshalAs(UnmanagedType.BStr), In] string ReturnAddress, [MarshalAs(UnmanagedType.BStr), In] string SenderName, [MarshalAs(UnmanagedType.BStr), In] string Closing, [MarshalAs(UnmanagedType.BStr), In] string SenderCompany, [MarshalAs(UnmanagedType.BStr), In] string SenderJobTitle, [MarshalAs(UnmanagedType.BStr), In] string SenderInitials, [In] int EnclosureNumber, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InfoBlock, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientCode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientGender, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressShortForm, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderCity, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderCode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderGender, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderReference);

		/// <summary>
		/// Accepts all tracked changes in the specified document.
		/// </summary>
		[DispId(317)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AcceptAllRevisions();

		/// <summary>
		/// Rejects all tracked changes in the specified document.
		/// </summary>
		[DispId(318)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RejectAllRevisions();

		/// <summary>
		/// Analyzes the specified text to determine the language that it is written in.
		/// </summary>
		[DispId(151)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DetectLanguage();

		/// <summary>
		/// Applies a theme to an open document.
		/// </summary>
		/// <param name="Name">Required String. The name of the theme plus any theme formatting options you want to apply. The format of this string is "<paramref name="theme nnn"/>" where <paramref name="theme"/> and <paramref name="nnn"/> are defined as follows:StringDescription<paramref name="theme"/>The name of the folder that contains the data for the requested theme. (The default location for theme data folders is C:\Program Files\Common Files\Microsoft Shared\Themes.) You must use the folder name for the theme rather than the display name that appears in the Theme dialog box (Theme command, Format menu).<paramref name="nnn"/>A three-digit string that indicates which theme formatting options to activate (1 to activate, 0 to deactivate). The digits correspond to the Vivid Colors, Active Graphics, and Background Image check boxes in the Theme dialog box (Theme command, Format menu). If this string is omitted, the default value for <paramref name="nnn"/> is "011" (Active Graphics and Background Image are activated).</param>
		[DispId(322)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ApplyTheme([MarshalAs(UnmanagedType.BStr), In] string Name);

		/// <summary>
		/// Removes the active theme from the current document.
		/// </summary>
		[DispId(323)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveTheme();

		/// <summary>
		/// Displays a preview of the current document as it would look if saved as a Web page.
		/// </summary>
		[DispId(325)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void WebPagePreview();

		/// <summary>
		/// Reloads a document based on an HTML document, using the specified document encoding.
		/// </summary>
		/// <param name="Encoding">Required <see cref="T:Microsoft.Office.Core.MsoEncoding"/>.</param>
		[DispId(331)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ReloadAs([In] MsoEncoding Encoding);

		/// <param name="Background"/><param name="Append"/><param name="Range"/><param name="OutputFileName"/><param name="From"/><param name="To"/><param name="Item"/><param name="Copies"/><param name="Pages"/><param name="PageType"/><param name="PrintToFile"/><param name="Collate"/><param name="ActivePrinterMacGX"/><param name="ManualDuplexPrint"/><param name="PrintZoomColumn"/><param name="PrintZoomRow"/><param name="PrintZoomPaperWidth"/><param name="PrintZoomPaperHeight"/>
		[DispId(444)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PrintOut2000([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Background, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Append, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OutputFileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Item, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Copies, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pages, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintToFile, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Collate, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

		/// <param name="s"/>
		[TypeLibFunc(64)]
		[DispId(445)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void sblt([MarshalAs(UnmanagedType.BStr), In] string s);

		/// <summary>
		/// Reconverts a Vietnamese document to Unicode using a code page other than the default.
		/// </summary>
		/// <param name="CodePageOrigin">Required Integer. The original code page used to encode the document.</param>
		[DispId(447)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ConvertVietDoc([In] int CodePageOrigin);

		/// <summary>
		/// Prints all or part of the specified document.
		/// </summary>
		/// <param name="Background">Optional Object. Set to True to have the macro continue while Microsoft Word prints the document.</param><param name="Append">Optional Object. Set to True to append the specified document to the file name specified by the <paramref name="OutputFileName"/> argument. False to overwrite the contents of <paramref name="OutputFileName"/>.</param><param name="Range">Optional Object. The page range. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdPrintOutRange"/> constant.</param><param name="OutputFileName">Optional Object. If <paramref name="PrintToFile"/> is True, this argument specifies the path and file name of the output file.</param><param name="From">Optional Object. The starting page number when <paramref name="Range"/> is set to wdPrintFromTo.</param><param name="To">Optional Object. The ending page number when <paramref name="Range"/> is set to wdPrintFromTo.</param><param name="Item">Optional Object. The item to be printed. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdPrintOutItem"/> constant.</param><param name="Copies">Optional Object. The number of copies to be printed.</param><param name="Pages">Optional Object. The page numbers and page ranges to be printed, separated by commas. For example, "2, 6-10" prints page 2 and pages 6 through 10.</param><param name="PageType">Optional Object. The type of pages to be printed. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdPrintOutPages"/> constant.</param><param name="PrintToFile">Optional Object. True to send printer instructions to a file. Make sure to specify a file name with <paramref name="OutputFileName"/>.</param><param name="Collate">Optional Object. When printing multiple copies of a document, True to print all pages of the document before printing the next copy.</param><param name="ActivePrinterMacGX">Optional Object. This argument is available only in Microsoft Office Macintosh Edition. For additional information about this argument, consult the language reference Help included with Microsoft Office Macintosh Edition.</param><param name="ManualDuplexPrint">Optional Object. True to print a two-sided document on a printer without a duplex printing kit. If this argument is True, the <see cref="P:Microsoft.Office.Interop.Word.Options.PrintBackground"/> and <see cref="P:Microsoft.Office.Interop.Word.Options.PrintReverse"/> properties are ignored. Use the <see cref="P:Microsoft.Office.Interop.Word.Options.PrintOddPagesInAscendingOrder"/> and <see cref="P:Microsoft.Office.Interop.Word.Options.PrintEvenPagesInAscendingOrder"/> properties to control the output during manual duplex printing. This argument may not be available to you, depending on the language support (U.S. English, for example) that you’ve selected or installed.</param><param name="PrintZoomColumn">Optional Object. The number of pages you want Word to fit horizontally on one page. Can be 1, 2, 3, or 4. Use with the <paramref name="PrintZoomRow"/> argument to print multiple pages on a single sheet.</param><param name="PrintZoomRow">Optional Object. The number of pages you want Word to fit vertically on one page. Can be 1, 2, or 4. Use with the <paramref name="PrintZoomColumn"/> argument to print multiple pages on a single sheet.</param><param name="PrintZoomPaperWidth">Optional Object. The width to which you want Word to scale printed pages, in twips (20 twips = 1 point; 72 points = 1 inch).</param><param name="PrintZoomPaperHeight">Optional Object. The height to which you want Word to scale printed pages, in twips (20 twips = 1 point; 72 points = 1 inch).</param>
		[DispId(446)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PrintOut([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Background, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Append, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OutputFileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Item, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Copies, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pages, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintToFile, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Collate, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

		/// <param name="Name"/><param name="AuthorName"/><param name="CompareTarget"/><param name="DetectFormatChanges"/><param name="IgnoreAllComparisonWarnings"/><param name="AddToRecentFiles"/>
		[TypeLibFunc(64)]
		[DispId(345)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Compare2002([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AuthorName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTarget, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreAllComparisonWarnings, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles);

		/// <summary>
		/// Returns a document from a local computer to a server, and sets the local document to read-only so that it cannot be edited locally.
		/// </summary>
		/// <param name="SaveChanges">Optional Boolean. True saves the document to the server location. The default is True.</param><param name="Comments">Optional Object. Comments for the revision of the document being checked in (only applies if <paramref name="SaveChanges"/> equals True).</param><param name="MakePublic">Optional Boolean. True allows the user to perform a publish on the document after being checked in. This submits the document for the approval process, which can eventually result in a version of the document being published to users with read-only rights to the document (only applies if <paramref name="SaveChanges"/> equals True).</param>
		[DispId(349)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckIn([In] bool SaveChanges = true, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Comments, [In] bool MakePublic = false);

		/// <summary>
		/// Determines if Microsoft Word can check in a specified document to a server.
		/// </summary>
		[DispId(351)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CanCheckin();

		/// <summary>
		/// Merges the changes marked with revision marks from one document to another.
		/// </summary>
		/// <param name="FileName">Required String.</param><param name="MergeTarget">Optional <see cref="T:Microsoft.Office.Interop.Word.WdMergeTarget"/>.</param><param name="DetectFormatChanges">Optional Boolean.</param><param name="UseFormattingFrom">Optional <see cref="T:Microsoft.Office.Interop.Word.WdUseFormattingFrom"/>.</param><param name="AddToRecentFiles">Optional Boolean.</param>
		[DispId(362)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Merge([MarshalAs(UnmanagedType.BStr), In] string FileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MergeTarget, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseFormattingFrom, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles);

		/// <summary>
		/// Sends a document in an e-mail message for review by the specified recipients.
		/// </summary>
		/// <param name="Recipients">Optional Object. A string that lists the people to whom to send the message. These can be unresolved names and aliases in an e-mail phone book or full e-mail addresses. Separate multiple recipients with a semicolon (;). If left blank and <paramref name="ShowMessage"/> is False, you will receive an error message and the message will not be sent.</param><param name="Subject">Optional Object. A string for the subject of the message. If left blank, the subject will be: Please review "<paramref name="filename"/>".</param><param name="ShowMessage">Optional Object. A Boolean value that indicates whether the message should be displayed when the method is executed. The default value is True. If set to False, the message is automatically sent to the recipients without first showing the message to the sender.</param><param name="IncludeAttachment">Optional Object. A Boolean value that indicates whether the message should include an attachment or a link to a server location. The default value is True. If set to False, the document must be stored at a shared location.</param>
		[DispId(353)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SendForReview([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Recipients, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeAttachment);

		/// <summary>
		/// Sends an e-mail message to the author of a document that has been sent out for review, notifying them that a reviewer has completed review of the document.
		/// </summary>
		/// <param name="ShowMessage">Optional Object. True to display the message prior to sending. False to automatically send the message without displaying it first. The default value is True.</param>
		[DispId(354)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ReplyWithChanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage);

		/// <summary>
		/// Terminates a review of a file that has been sent for review using the <see cref="M:Microsoft.Office.Interop.Word._Document.SendForReview(System.Object@,System.Object@,System.Object@,System.Object@)"/> method or that has been automatically placed in a review cycle by sending a document to another user in an e-mail message.
		/// </summary>
		[DispId(356)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EndReview();

		/// <summary>
		/// Sets the options Microsoft Word uses for encrypting documents with passwords.
		/// </summary>
		/// <param name="PasswordEncryptionProvider">Required String. The name of the encryption provider.</param><param name="PasswordEncryptionAlgorithm">Required String. The name of the encryption algorithm. Word supports stream-encrypted algorithms.</param><param name="PasswordEncryptionKeyLength">Required Integer. The encryption key length. Must be a multiple of 8, starting at 40.</param><param name="PasswordEncryptionFileProperties">Optional Object. True for Word to encrypt file properties. Default is True.</param>
		[DispId(361)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetPasswordEncryptionOptions([MarshalAs(UnmanagedType.BStr), In] string PasswordEncryptionProvider, [MarshalAs(UnmanagedType.BStr), In] string PasswordEncryptionAlgorithm, [In] int PasswordEncryptionKeyLength, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordEncryptionFileProperties);

		/// <summary>
		/// Removes smart tags recognized by the grammar checker and rechecks the document content against all smart tag recognizers.
		/// </summary>
		[TypeLibFunc(64)]
		[DispId(363)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RecheckSmartTags();

		/// <summary>
		/// Removes all smart tag information from a document.
		/// </summary>
		[TypeLibFunc(64)]
		[DispId(364)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveSmartTags();

		/// <summary>
		/// Specifies the table style to use for newly created tables in a document.
		/// </summary>
		/// <param name="Style">Required Object. A string specifying the name of the style.</param><param name="SetInTemplate">Required Boolean. True to save the table style in the template attached to the document.</param>
		[DispId(366)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetDefaultTableStyle([MarshalAs(UnmanagedType.Struct), In] ref object Style, [In] bool SetInTemplate);

		/// <summary>
		/// Deletes all comments from the <see cref="T:Microsoft.Office.Interop.Word.Comments"/> collection in a document.
		/// </summary>
		[DispId(371)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DeleteAllComments();

		/// <summary>
		/// Accepts all revisions in the specified document that are displayed on the screen.
		/// </summary>
		[DispId(372)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AcceptAllRevisionsShown();

		/// <summary>
		/// Rejects all revisions in a document that are displayed on the screen.
		/// </summary>
		[DispId(373)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RejectAllRevisionsShown();

		/// <summary>
		/// Deletes all revisions in a specified document that are displayed on the screen.
		/// </summary>
		[DispId(374)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DeleteAllCommentsShown();

		/// <summary>
		/// Clears all form fields in a document, preparing the form to be filled in again.
		/// </summary>
		[DispId(375)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ResetFormFields();

		/// <summary>
		/// Saves the specified document with a new name or format. Some of the arguments for this method correspond to the options in the Save Asdialog box (File menu).
		/// </summary>
		/// <param name="FileName">Optional Object. The name for the document. The default is the current folder and file name. If the document has never been saved, the default name is used (for example, Doc1.doc). If a document with the specified file name already exists, the document is overwritten without the user being prompted first.</param><param name="FileFormat">Optional Object. The format in which the document is saved. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdSaveFormat"/> constant. To save a document in another format, specify the appropriate value for the <see cref="P:Microsoft.Office.Interop.Word.FileConverter.SaveFormat"/> property of the <see cref="T:Microsoft.Office.Interop.Word.FileConverter"/> object.</param><param name="LockComments">Optional Object. True to lock the document for comments. The default is False.</param><param name="Password">Optional Object. A password string for opening the document. (See Remarks below.)</param><param name="AddToRecentFiles">Optional Object. True to add the document to the list of recently used files on the File menu. The default is True.</param><param name="WritePassword">Optional Object. A password string for saving changes to the document. (See Remarks below.)</param><param name="ReadOnlyRecommended">Optional Object. True to have Microsoft Word suggest read-only status whenever the document is opened. The default is False.</param><param name="EmbedTrueTypeFonts">Optional Object. True to save TrueType fonts with the document. If omitted, the <paramref name="EmbedTrueTypeFonts"/> argument assumes the value of the <see cref="P:Microsoft.Office.Interop.Word._Document.EmbedTrueTypeFonts"/> property.</param><param name="SaveNativePictureFormat">Optional Object. If graphics were imported from another platform (for example, Macintosh), True to save only the Windows version of the imported graphics.</param><param name="SaveFormsData">Optional Object. True to save the data entered by a user in a form as a data record.</param><param name="SaveAsAOCELetter">Optional Object. If the document has an attached mailer, True to save the document as an AOCE letter (the mailer is saved).</param><param name="Encoding">Optional <see cref="T:Microsoft.Office.Core.MsoEncoding"/>. The code page, or character set, to use for documents saved as encoded text files. The default is the system code page.</param><param name="InsertLineBreaks">Optional Object. If the document is saved as a text file, True to insert line breaks at the end of each line of text.</param><param name="AllowSubstitutions">Optional Object. If the document is saved as a text file, True allows Word to replace some symbols with text that looks similar. For example, displaying the copyright symbol as (c). The default is False.</param><param name="LineEnding">Optional Object. The way Word marks the line and paragraph breaks in documents saved as text files. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdLineEndingType"/> constant.</param><param name="AddBiDiMarks">Optional Object. True adds control characters to the output file to preserve bi-directional layout of the text in the original document.</param>
		[TypeLibFunc(64)]
		[DispId(376)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SaveAs([MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LockComments, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePassword, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnlyRecommended, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EmbedTrueTypeFonts, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveNativePictureFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveFormsData, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveAsAOCELetter, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertLineBreaks, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AllowSubstitutions, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LineEnding, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddBiDiMarks);

		/// <summary>
		/// Accesses the Microsoft Office Web site for available smart tag recognizer and action files.
		/// </summary>
		[DispId(378)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckNewSmartTags();

		/// <summary>
		/// Sends a document to a fax service provider, who faxes the document to one or more specified recipients.
		/// </summary>
		/// <param name="Recipients">Optional Object. A String that represents the fax numbers and e-mail addresses of the people to whom to send the fax. Separate multiple recipients with a semicolon.</param><param name="Subject">Optional Object. A String that represents the subject line for the faxed document.</param><param name="ShowMessage">Optional Object. True displays the fax message before sending it. False sends the fax without displaying the fax message.</param>
		[DispId(464)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SendFaxOverInternet([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Recipients, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage);

		/// <summary>
		/// Applies the specified Extensible Stylesheet Language Transformation (XSLT) file to the specified document and replaces the document with the results.
		/// </summary>
		/// <param name="Path">Required String. The path for the XSLT to use.</param><param name="DataOnly">Optional Boolean. True applies the transformation only to the data in the document, excluding Microsoft Word XML. False applies the transform to the entire document, including Word XML. Default value is True.</param>
		[DispId(500)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void TransformDocument([MarshalAs(UnmanagedType.BStr), In] string Path, [In] bool DataOnly = true);

		/// <summary>
		/// Helps to protect the specified document from changes. When a document is protected, users can make only limited changes, such as adding annotations, making revisions, or completing a form.
		/// </summary>
		/// <param name="Type">Required. The protection type for the specified document. <see cref="T:Microsoft.Office.Interop.Word.WdProtectionType"/>.</param><param name="NoReset">Optional Object. False to reset form fields to their default values. True to retain the current form field values if the specified document is protected. If <paramref name="Type"/> isn't wdAllowOnlyFormFields, the <paramref name="NoReset"/> argument is ignored.</param><param name="Password">Optional Object. The password required to remove protection from the specified document. (See Remarks below.)</param><param name="UseIRM">Optional Object. Specifies whether to use Information Rights Management (IRM) when protecting the document from changes.</param><param name="EnforceStyleLock">Optional Object. Specifies whether formatting restrictions are enforced in a protected document.</param>
		[DispId(467)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Protect([In] WdProtectionType Type, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoReset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseIRM, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EnforceStyleLock);

		/// <summary>
		/// Selects all ranges for which the specified user or group of users has permission to modify.
		/// </summary>
		/// <param name="EditorID">Optional Object. Can be either a String that represents the user's e-mail alias (if in the same domain), an e-mail address, or a <see cref="T:Microsoft.Office.Interop.Word.WdEditorType"/> constant that represents a group of users. If omitted, only ranges for which all users have permissions will be selected.</param>
		[DispId(468)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SelectAllEditableRanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

		/// <summary>
		/// Deletes permissions in all ranges for which the specified user or group of users has permission to modify.
		/// </summary>
		/// <param name="EditorID">Optional Object. Can be either a String that represents the user's e-mail alias (if in the same domain), an e-mail address, or a <see cref="T:Microsoft.Office.Interop.Word.WdEditorType"/> constant that represents a group of users. If omitted, no permissions are deleted from a document.</param>
		[DispId(469)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DeleteAllEditableRanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

		/// <summary>
		/// Deletes all handwritten ink annotations in a document.
		/// </summary>
		[DispId(479)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DeleteAllInkAnnotations();

		/// <param name="RichFormat"/><param name="Url"/><param name="Title"/><param name="Description"/><param name="ID"/>
		[TypeLibFunc(64)]
		[DispId(482)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddDocumentWorkspaceHeader([In] bool RichFormat, [MarshalAs(UnmanagedType.BStr), In] string Url, [MarshalAs(UnmanagedType.BStr), In] string Title, [MarshalAs(UnmanagedType.BStr), In] string Description, [MarshalAs(UnmanagedType.BStr), In] string ID);

		/// <param name="ID"/>
		[TypeLibFunc(64)]
		[DispId(483)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveDocumentWorkspaceHeader([MarshalAs(UnmanagedType.BStr), In] string ID);

		/// <summary>
		/// Displays revision marks that indicate where the specified document differs from another document.
		/// </summary>
		/// <param name="Name">Required String. The name of the document with which the specified document is compared.</param><param name="AuthorName">Optional Object. The reviewer name associated with the differences generated by the comparison. If unspecified, the value defaults to the author name of the revised document or the string "Comparison" if no author information is present.</param><param name="CompareTarget">Optional Object. The target document for the comparison. Can be any WdCompareTarget constant.</param><param name="DetectFormatChanges">Optional Boolean. True (default) for the comparison to include detection of format changes.</param><param name="IgnoreAllComparisonWarnings">Optional Object. True compares the documents without notifying a user of problems. The default value is False.</param><param name="AddToRecentFiles">Optional Object. True adds the document to the list of recently used files on the File menu.</param><param name="RemovePersonalInformation">Optional Object. True removes personal information associated with the differences generated by the comparison.</param><param name="RemoveDateAndTime">Optional Object. True removes data and time information associated with the differences generated by the comparison.</param>
		[DispId(485)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Compare([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AuthorName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTarget, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreAllComparisonWarnings, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RemovePersonalInformation, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RemoveDateAndTime);

		/// <summary>
		/// Purges a document of locked styles when formatting restrictions have been applied in a document.
		/// </summary>
		[DispId(487)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveLockedStyles();

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.XMLNode"/> object that represents a node in the specified document.
		/// </summary>
		/// <param name="XPath">Required String. A valid XPath string. For more information on XPath, see the XPath reference documentation on the Microsoft Developer Network (MSDN) Web site.</param><param name="PrefixMapping">Optional Object. Provides the prefix in the schema against which to perform the search. Use the <paramref name="PrefixMapping"/> parameter if your <paramref name="XPath"/> parameter uses names to search for elements.</param><param name="FastSearchSkippingTextNodes">Optional Boolean. True skips all text nodes while searching for the specified node. False includes text nodes in the search. Default value is True.</param>
		[DispId(488)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		XMLNode SelectSingleNode([MarshalAs(UnmanagedType.BStr), In] string XPath, [MarshalAs(UnmanagedType.BStr), In] string PrefixMapping = "", [In] bool FastSearchSkippingTextNodes = true);

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.XMLNodes"/> collection that represents all the specified nodes in the order in which they appear in the document.
		/// </summary>
		/// <param name="XPath">Required String. A valid XPath string. For more information on XPath, see the XPath reference documentation on the Microsoft Developer Network (MSDN) Web site.</param><param name="PrefixMapping">Optional Object. Provides the prefix in the schema against which to perform the search. Use the <paramref name="PrefixMappin"/>g parameter if your <paramref name="XPath"/> parameter uses names to search for elements.</param><param name="FastSearchSkippingTextNodes">Optional Boolean. True skips all text nodes while searching for the specified node. False includes text nodes in the search. Default value is False.</param>
		[DispId(489)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		XMLNodes SelectNodes([MarshalAs(UnmanagedType.BStr), In] string XPath, [MarshalAs(UnmanagedType.BStr), In] string PrefixMapping = "", [In] bool FastSearchSkippingTextNodes = true);

		[DispId(503)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Dummy1();

		/// <summary>
		/// Removes sensitive information, properties, comments, and other metadata from a document.
		/// </summary>
		/// <param name="RemoveDocInfoType">Specifies what to remove.</param>
		[DispId(495)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveDocumentInformation([In] WdRemoveDocInfoType RemoveDocInfoType);

		/// <summary>
		/// Puts a document on a server from a local computer, and sets the local document to read-only so that it cannot be edited locally.
		/// </summary>
		/// <param name="SaveChanges">True to save the document to the server location. The default is True. </param><param name="Comments">Comments for the revision of the document being checked in (only applies if <paramref name="SaveChanges"/> is set to true).</param><param name="MakePublic">True to allow the user to publish the document after it is checked in. </param><param name="VersionType">Specifies versioning information for the document. </param>
		[DispId(501)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CheckInWithVersion([In] bool SaveChanges = true, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Comments, [In] bool MakePublic = false, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object VersionType);

		[DispId(505)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Dummy2();

		[TypeLibFunc(64)]
		[DispId(506)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Dummy3();

		/// <summary>
		/// Locks the file on the server preventing anyone else from editing it.
		/// </summary>
		[DispId(509)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void LockServerFile();

		/// <summary>
		/// Returns the workflow tasks assigned to a document.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Core.WorkflowTasks"/>
		/// </returns>
		[DispId(511)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		WorkflowTasks GetWorkflowTasks();

		/// <summary>
		/// Returns the workflow templates attached to a document.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Core.WorkflowTemplates"/>
		/// </returns>
		[DispId(512)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		WorkflowTemplates GetWorkflowTemplates();

		[DispId(514)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Dummy4();

		/// <param name="SkipIfAbsent"/><param name="Url"/><param name="Title"/><param name="Description"/><param name="ID"/>
		[DispId(515)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddMeetingWorkspaceHeader([In] bool SkipIfAbsent, [MarshalAs(UnmanagedType.BStr), In] string Url, [MarshalAs(UnmanagedType.BStr), In] string Title, [MarshalAs(UnmanagedType.BStr), In] string Description, [MarshalAs(UnmanagedType.BStr), In] string ID);

		/// <summary>
		/// Saves the group of quick styles currently in use.
		/// </summary>
		/// <param name="FileName">The path and file name for the quick style set file.</param>
		[DispId(524)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SaveAsQuickStyleSet([MarshalAs(UnmanagedType.BStr), In] string FileName);

		/// <summary>
		/// Changes the set of quick styles listed.
		/// </summary>
		/// <param name="Name">The name of the set to use. This corresponds to the name listed in the Style Set list.</param>
		[TypeLibFunc(64)]
		[DispId(525)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ApplyQuickStyleSet([MarshalAs(UnmanagedType.BStr), In] string Name);

		/// <summary>
		/// Applies a document theme to a document.
		/// </summary>
		/// <param name="FileName">The path and file name of the theme to apply.</param>
		[DispId(546)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ApplyDocumentTheme([MarshalAs(UnmanagedType.BStr), In] string FileName);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/> collection that represents all content controls in a document that are linked to the specific custom  XML node in the document's XML data store as specified by the Node parameter. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/>
		/// </returns>
		/// <param name="Node">The XML node in the document's data store to which the content controls are linked.</param>
		[DispId(549)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		ContentControls SelectLinkedControls([MarshalAs(UnmanagedType.Interface), In] CustomXMLNode Node);

		/// <summary>
		/// Returns all of the content controls in a document that are not linked to an XML node in the document's XML data store. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/>
		/// </returns>
		/// <param name="Stream">A custom XML part reference. Setting this parameter filters the returned content controls to include only content controls that reference this <see cref="T:Microsoft.Office.Core._CustomXMLPart"/> in their <see cref="T:Microsoft.Office.Interop.Word.XMLMapping"/> definition.</param>
		[DispId(550)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		ContentControls SelectUnlinkedControls([MarshalAs(UnmanagedType.Interface), In] CustomXMLPart Stream = null);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/> collection that represents all the content controls in a document with the title specified in the <paramref name="Title"/> parameter. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/>
		/// </returns>
		/// <param name="Title">The title of the content controls to return.</param>
		[DispId(551)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		ContentControls SelectContentControlsByTitle([MarshalAs(UnmanagedType.BStr), In] string Title);

		/// <summary>
		/// Saves  a document as  PDF or XPS format.
		/// </summary>
		/// <param name="OutputFileName">The path and file name name of the new PDF or XPS file.</param><param name="ExportFormat">Specifies either PDF or XPS format.</param><param name="OpenAfterExport">Opens the new file after exporting the contents.</param><param name="OptimizeFor">Specifies whether to optimize for screen or print.</param><param name="Range">Specifies whether the export range is the entire document, the current page, a range of text, or the current selection. the default is to export the entire document.</param><param name="From">Specifies the starting page number, if the <paramref name="Range"/> parameter is set to <see cref="F:Microsoft.Office.Interop.Word.WdExportRange.wdExportFromTo"/>.</param><param name="To">Specifies the ending page number, if the <paramref name="Range"/> parameter is set to <see cref="F:Microsoft.Office.Interop.Word.WdExportRange.wdExportFromTo"/>.</param><param name="Item">Specifies whether the export process includes text only or includes text with markup.</param><param name="IncludeDocProps">Specifies whether to include document properties in the newly exported file.</param><param name="KeepIRM">Specifies whether to copy IRM permissions to an XPS document if the source document has IRM protections. Default value is True.</param><param name="CreateBookmarks">Specifies whether to export bookmarks and the type of bookmarks to export.</param><param name="DocStructureTags">Specifies whether to include extra data to help screen readers, for example information about the flow and logical organization of the content. Default value is  True.</param><param name="BitmapMissingFonts">Specifies whether to include a bitmap of the text. Set this parameter to True when font licenses do not permit a font to be embedded in the PDF file. If False, the font is referenced, and the viewer's computer substitutes an appropriate font if the authored one is not available. Default value is  True.</param><param name="UseISO19005_1">Specifies whether to limit PDF usage to the PDF subset standardized as ISO 19005-1. If True, the resulting files are more reliably self-contained but may be larger or show more visual artifacts due to the restrictions of the format. Default value is  False.</param><param name="FixedFormatExtClassPtr">Specifies a pointer to an add-in that allows calls to an alternate implementation of code. The alternate implementation of code interprets the EMF and EMF+ page descriptions that are generated by the applications to make their own PDF or XPS. For more information, see "Extending the Office (2007) Fixed-Format Export Feature" on MSDN.</param>
		[DispId(552)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ExportAsFixedFormat([MarshalAs(UnmanagedType.BStr), In] string OutputFileName, [In] WdExportFormat ExportFormat, [In] bool OpenAfterExport = false, [In] WdExportOptimizeFor OptimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint, [In] WdExportRange Range = WdExportRange.wdExportAllDocument, [In] int From = 1, [In] int To = 1, [In] WdExportItem Item = WdExportItem.wdExportDocumentContent, [In] bool IncludeDocProps = false, [In] bool KeepIRM = true, [In] WdExportCreateBookmarks CreateBookmarks = WdExportCreateBookmarks.wdExportCreateNoBookmarks, [In] bool DocStructureTags = true, [In] bool BitmapMissingFonts = true, [In] bool UseISO19005_1 = false, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FixedFormatExtClassPtr);

		/// <summary>
		/// In Web view, fixes the layout of the document as it currently appears so that line breaks remain fixed and ink annotations do not move when you resize the window.
		/// </summary>
		[DispId(553)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void FreezeLayout();

		/// <summary>
		/// Reverses the effect of <see cref="M:Microsoft.Office.Interop.Word._Document.UnfreezeLayout"/>, and enables line breaks to change and ink annotations to move when you resize the Web browser window.
		/// </summary>
		[DispId(554)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UnfreezeLayout();

		/// <summary>
		/// Downgrades a document to the Word 97-2003 document format so that it can be edited in a previous version of Microsoft Office Word.
		/// </summary>
		[DispId(558)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DowngradeDocument();

		/// <summary>
		/// Converts file to the newest file format and enables all new features.
		/// </summary>
		[DispId(561)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Convert();

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/> collection that represents all the content controls in a document with the tag value specified in the <paramref name="Tag"/> parameter. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/>
		/// </returns>
		/// <param name="Tag">The tag value of the content controls to return.</param>
		[DispId(562)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		ContentControls SelectContentControlsByTag([MarshalAs(UnmanagedType.BStr), In] string Tag);

		/// <summary>
		/// Converts hyphens created by automatic hyphenation to manual hyphens.
		/// </summary>
		[DispId(650)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ConvertAutoHyphens();

		/// <summary>
		/// Applies the specified Quick Style set to the document.
		/// </summary>
		/// <param name="Style"/>
		[DispId(566)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ApplyQuickStyleSet2([MarshalAs(UnmanagedType.Struct), In] ref object Style);

		/// <summary>
		/// Saves the specified document with a new name or format. Some of the arguments for this method correspond to the options in the Save As dialog box (File tab).
		/// </summary>
		/// <param name="FileName">The name for the document. The default is the current folder and file name. If the document has never been saved, the default name is used (for example, Doc1.doc). If a document with the specified file name already exists, the document is overwritten without prompting the user.</param><param name="FileFormat">The format in which the document is saved. Can be any <see cref="T:Microsoft.Office.Interop.Word.WdSaveFormat"/> constant. To save a document in another format, specify the appropriate value for the <see cref="P:Microsoft.Office.Interop.Word.FileConverter.SaveFormat"/> property of the <see cref="T:Microsoft.Office.Interop.Word.FileConverter"/> object.</param><param name="LockComments">true to lock the document for comments; otherwise false. The default is false.</param><param name="Password">A password string for opening the document.</param><param name="AddToRecentFiles">true to add the document to the list of recently used files on the File menu; otherwise, false. The default is true.</param><param name="WritePassword">A password string for saving changes to the document.</param><param name="ReadOnlyRecommended">true to have Microsoft Word suggest read-only status whenever the document is opened; otherwise, false. The default is false.</param><param name="EmbedTrueTypeFonts">true to save TrueType fonts with the document; otherwise, false. If omitted, the <paramref name="EmbedTrueTypeFonts"/> parameter assumes the value of the <see cref="P:Microsoft.Office.Interop.Word._Document.EmbedTrueTypeFonts"/> property.</param><param name="SaveNativePictureFormat">If graphics were imported from another platform (for example, Macintosh), true to save only the Microsoft Windows version of the imported graphics.</param><param name="SaveFormsData">true to save the data entered by a user in a form as a record; otherwise, false.</param><param name="SaveAsAOCELetter">If the document has an attached mailer, true to save the document as an AOCE letter (the mailer is saved).</param><param name="Encoding">The code page, or character set, to use for documents saved as encoded text files. The default is the system code page. You cannot use all <see cref="T:Microsoft.Office.Core.MsoEncoding"/> constants with this parameter.</param><param name="InsertLineBreaks">If the document is saved as a text file, true to insert line breaks at the end of each line of text.</param><param name="AllowSubstitutions">If the document is saved as a text file, true allows Word to replace some symbols with text that looks similar. For example, displaying the copyright symbol as (c). The default is false.</param><param name="LineEnding">The way Word marks the line and paragraph breaks in documents saved as text files. Can be one of the following <see cref="T:Microsoft.Office.Interop.Word.WdLineEndingType"/> constants: <see cref="F:Microsoft.Office.Interop.Word.WdLineEndingType.wdCRLF"/> (default) or F:Microsoft.Office.Interop.Word.WdLineEndingType.wdCROnly.</param><param name="AddBiDiMarks">true adds control characters to the output file to preserve bi-directional layout of the text in the original document.</param><param name="CompatibilityMode">The compatibility mode that Word 2010 uses when opening the document. <see cref="T:Microsoft.Office.Interop.Word.WdCompatibilityMode"/> constant.</param>
		[DispId(568)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SaveAs2([MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LockComments, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePassword, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnlyRecommended, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EmbedTrueTypeFonts, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveNativePictureFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveFormsData, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveAsAOCELetter, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertLineBreaks, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AllowSubstitutions, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LineEnding, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddBiDiMarks, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompatibilityMode);

		/// <summary>
		/// Sets the compatibility mode for the document.
		/// </summary>
		/// <param name="Mode">Specifies which version of Word to approximate. Use a constant from the <see cref="T:Microsoft.Office.Interop.Word.WdCompatibilityMode"/> enumeration as an argument for this parameter.</param>
		[DispId(571)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCompatibilityMode([In] int Mode);

		/// <summary>
		/// Returns the name of the specified object.
		/// </summary>
		[DispId(0)]
		string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.Application"/> object that represents the Microsoft Word application.
		/// </summary>
		[DispId(1)]
		Microsoft.Office.Interop.Word.Application Application { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
		/// Returns a <see cref="T:Microsoft.Office.Core.DocumentProperties"/> collection that represents all the built-in document properties for the specified document.
		/// </summary>
		[DispId(1000)]
		object BuiltInDocumentProperties { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.DocumentProperties"/> collection that represents all the custom document properties for the specified document.
		/// </summary>
		[DispId(2)]
		object CustomDocumentProperties { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the disk or Web path to the specified object.
		/// </summary>
		[DispId(3)]
		string Path { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Bookmarks"/> collection that represents all the bookmarks in a document.
		/// </summary>
		[DispId(4)]
		Bookmarks Bookmarks { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Tables"/> collection that represents all the tables in the specified document.
		/// </summary>
		[DispId(6)]
		Tables Tables { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Footnotes"/> collection that represents all the footnotes in a range, selection, or document.
		/// </summary>
		[DispId(7)]
		Footnotes Footnotes { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.Endnotes"/> collection that represents all the endnotes in a range, selection, or document.
		/// </summary>
		[DispId(8)]
		Endnotes Endnotes { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Comments"/> collection that represents all the comments in the specified document.
		/// </summary>
		[DispId(9)]
		Comments Comments { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the document type (template or document).
		/// </summary>
		[DispId(10)]
		WdDocumentType Type { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if automatic hyphenation is turned on for the specified document.
		/// </summary>
		[DispId(11)]
		bool AutoHyphenation { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determine if words in all capital letters can be hyphenated.
		/// </summary>
		[DispId(12)]
		bool HyphenateCaps { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the width of the hyphenation zone, in points.
		/// </summary>
		[DispId(13)]
		int HyphenationZone { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the maximum number of consecutive lines that can end with hyphens.
		/// </summary>
		[DispId(14)]
		int ConsecutiveHyphensLimit { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Sections"/> collection that represents the sections in the specified document.
		/// </summary>
		[DispId(15)]
		Sections Sections { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Paragraphs"/> collection that represents all the paragraphs in the specified document.
		/// </summary>
		[DispId(16)]
		Paragraphs Paragraphs { [DispId(16), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Words"/> collection that represents all the words in a document.
		/// </summary>
		[DispId(17)]
		Words Words { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Sentences"/> collection that represents all the sentences in the document.
		/// </summary>
		[DispId(18)]
		Sentences Sentences { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Characters"/> collection that represents the characters in a document.
		/// </summary>
		[DispId(19)]
		Characters Characters { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a read-only <see cref="T:Microsoft.Office.Interop.Word.Fields"/> collection that represents all the fields in the document, range, or selection.
		/// </summary>
		[DispId(20)]
		Fields Fields { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.FormFields"/> collection that represents all the form fields in the document, range, or selection.
		/// </summary>
		[DispId(21)]
		FormFields FormFields { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Styles"/> collection for the specified document.
		/// </summary>
		[DispId(22)]
		Styles Styles { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Frames"/> collection that represents all the frames in a document, range, or selection.
		/// </summary>
		[DispId(23)]
		Frames Frames { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.TablesOfFigures"/> collection that represents the tables of figures in the specified document.
		/// </summary>
		[DispId(25)]
		TablesOfFigures TablesOfFigures { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Variables"/> collection that represents the variables stored in the specified document.
		/// </summary>
		[DispId(26)]
		Variables Variables { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.MailMerge"/> object that represents the mail merge functionality for the specified document.
		/// </summary>
		[DispId(27)]
		MailMerge MailMerge { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.Envelope"/> object that represents envelope functionality and the envelope in the specified document.
		/// </summary>
		[DispId(28)]
		Envelope Envelope { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Specifies the name of a document, template, or cascading style sheet, including the drive or Web path.
		/// </summary>
		[DispId(29)]
		string FullName { [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Revisions"/> collection that represents the tracked changes in the document or range.
		/// </summary>
		[DispId(30)]
		Revisions Revisions { [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.TablesOfContents"/> collection that represents the tables of contents in the specified document.
		/// </summary>
		[DispId(31)]
		TablesOfContents TablesOfContents { [DispId(31), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.TablesOfAuthorities"/> collection that represents the tables of authorities in the specified document.
		/// </summary>
		[DispId(32)]
		TablesOfAuthorities TablesOfAuthorities { [DispId(32), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.PageSetup"/> object that's associated with the specified document.
		/// </summary>
		[DispId(1101)]
		PageSetup PageSetup { [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Windows"/> collection that represents all windows for the specified document (for example, Sales.doc:1 and Sales.doc:2).
		/// </summary>
		[DispId(34)]
		Microsoft.Office.Interop.Word.Windows Windows { [DispId(34), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the specified document has a routing slip attached to it.
		/// </summary>
		[DispId(35)]
		bool HasRoutingSlip { [TypeLibFunc(64), DispId(35), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(35), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.RoutingSlip"/> object that represents the routing slip information for the specified document.
		/// </summary>
		[DispId(36)]
		RoutingSlip RoutingSlip { [DispId(36), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the specified document has been routed to the next recipient.
		/// </summary>
		[DispId(37)]
		bool Routed { [DispId(37), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.TablesOfAuthoritiesCategories"/> collection that represents the available tables of authorities categories for the specified document.
		/// </summary>
		[DispId(38)]
		TablesOfAuthoritiesCategories TablesOfAuthoritiesCategories { [DispId(38), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.Indexes"/> collection that represents all the indexes in the specified document.
		/// </summary>
		[DispId(39)]
		Indexes Indexes { [DispId(39), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the specified document or template hasn't changed since it was last saved.
		/// </summary>
		[DispId(40)]
		bool Saved { [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Range"/> object that represents the main document story.
		/// </summary>
		[DispId(41)]
		Range Content { [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Window"/> object that represents the active window.
		/// </summary>
		[DispId(42)]
		Microsoft.Office.Interop.Word.Window ActiveWindow { [DispId(42), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the format type that Microsoft Word uses when automatically formatting the specified document.
		/// </summary>
		[DispId(43)]
		WdDocumentKind Kind { [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if changes to the document cannot be saved to the original document.
		/// </summary>
		[DispId(44)]
		bool ReadOnly { [DispId(44), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Subdocuments"/> collection that represents all the subdocuments in the specified range or document.
		/// </summary>
		[DispId(45)]
		Subdocuments Subdocuments { [DispId(45), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the specified document is a master document.
		/// </summary>
		[DispId(46)]
		bool IsMasterDocument { [DispId(46), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the interval (in points) between the default tab stops in the specified document.
		/// </summary>
		[DispId(48)]
		float DefaultTabStop { [DispId(48), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(48), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// ReturnsTrue if Microsoft Word embeds TrueType fonts in a document when it's saved.
		/// </summary>
		[DispId(50)]
		bool EmbedTrueTypeFonts { [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word saves the data entered in a form as a tab-delimited record for use in a database.
		/// </summary>
		[DispId(51)]
		bool SaveFormsData { [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Word displays a message box whenever a user opens the document, suggesting that it be opened as read-only.
		/// </summary>
		[DispId(52)]
		bool ReadOnlyRecommended { [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word saves a subset of the embedded TrueType fonts with the document.
		/// </summary>
		[DispId(53)]
		bool SaveSubsetFonts { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		[DispId(55)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool get_Compatibility([In] WdCompatibility Type);

		[DispId(55)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void set_Compatibility([In] WdCompatibility Type, [In] bool prop);

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.StoryRanges"/> collection that represents all the stories in the specified document.
		/// </summary>
		[DispId(56)]
		StoryRanges StoryRanges { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.CommandBars"/> collection that represents the menu bar and all the toolbars in Microsoft Word.
		/// </summary>
		[DispId(57)]
		CommandBars CommandBars { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the specified document is opened in a separate document window as a subdocument of a master document.
		/// </summary>
		[DispId(58)]
		bool IsSubdocument { [DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Integer representing the file format of the specified document or file converter.
		/// </summary>
		[DispId(59)]
		int SaveFormat { [DispId(59), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the protection type for the specified document.
		/// </summary>
		[DispId(60)]
		WdProtectionType ProtectionType { [DispId(60), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Hyperlinks"/> collection that represents all the hyperlinks in the specified document, range, or selection.
		/// </summary>
		[DispId(61)]
		Hyperlinks Hyperlinks { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Shapes"/> collection that represents all the <see cref="T:Microsoft.Office.Interop.Word.Shape"/> objects in the specified document.
		/// </summary>
		[DispId(62)]
		Microsoft.Office.Interop.Word.Shapes Shapes { [DispId(62), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ListTemplates"/> collection that represents all the list formats for the specified document.
		/// </summary>
		[DispId(63)]
		ListTemplates ListTemplates { [DispId(63), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Lists"/> collection that contains all the formatted lists in the specified document.
		/// </summary>
		[DispId(64)]
		Lists Lists { [DispId(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the styles in the specified document are updated to match the styles in the attached template each time the document is opened.
		/// </summary>
		[DispId(66)]
		bool UpdateStylesOnOpen { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Template"/> object that represents the template attached to the specified document.
		/// </summary>
		[DispId(67)]
		object AttachedTemplate { [DispId(67), TypeLibFunc(1024), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(67), TypeLibFunc(1024), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.InlineShapes"/> collection that represents all the <see cref="T:Microsoft.Office.Interop.Word.InlineShape"/> objects in a document, range, or selection.
		/// </summary>
		[DispId(68)]
		InlineShapes InlineShapes { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Shape"/> object that represents the background image for the specified document.
		/// </summary>
		[DispId(69)]
		Microsoft.Office.Interop.Word.Shape Background { [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if a grammar check has been run on the specified range or document.
		/// </summary>
		[DispId(70)]
		bool GrammarChecked { [DispId(70), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(70), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if spelling has been checked throughout the specified range or document.
		/// </summary>
		[DispId(71)]
		bool SpellingChecked { [DispId(71), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(71), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if grammatical errors are marked by a wavy green line in the specified document.
		/// </summary>
		[DispId(72)]
		bool ShowGrammaticalErrors { [DispId(72), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(72), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word underlines spelling errors in the document.
		/// </summary>
		[DispId(73)]
		bool ShowSpellingErrors { [DispId(73), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(73), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Versions"/> collection that represents all the versions of the specified document.
		/// </summary>
		[DispId(75)]
		Versions Versions { [DispId(75), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if an automatic summary is displayed for the specified document.
		/// </summary>
		[DispId(76)]
		bool ShowSummary { [DispId(76), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(76), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the way a summary is displayed.
		/// </summary>
		[DispId(77)]
		WdSummaryMode SummaryViewMode { [DispId(77), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(77), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the length of the summary as a percentage of the document length.
		/// </summary>
		[DispId(78)]
		int SummaryLength { [TypeLibFunc(64), DispId(78), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(78), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if the specified document is formatted to use fractional point spacing to display and print characters.
		/// </summary>
		[DispId(79)]
		bool PrintFractionalWidths { [DispId(79), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(79), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if PRINT field instructions (such as PostScript commands) in a document are to be printed on top of text and graphics when a PostScript printer is used.
		/// </summary>
		[DispId(80)]
		bool PrintPostScriptOverText { [DispId(80), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(80), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the object that represents the container application for the specified OLE object.
		/// </summary>
		[DispId(82)]
		object Container { [DispId(82), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if Microsoft Word prints onto a preprinted form only the data entered in the corresponding online form.
		/// </summary>
		[DispId(83)]
		bool PrintFormsData { [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ListParagraphs"/> collection that represents all the numbered paragraphs in the document.
		/// </summary>
		[DispId(84)]
		ListParagraphs ListParagraphs { [DispId(84), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Sets a password that must be supplied to open the specified document.
		/// </summary>
		[DispId(85)]
		string Password { [DispId(85), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Sets a password for saving changes to the specified document.
		/// </summary>
		[DispId(86)]
		string WritePassword { [DispId(86), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns True if a password is required to open the specified document.
		/// </summary>
		[DispId(87)]
		bool HasPassword { [DispId(87), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if the specified document is protected with a write password.
		/// </summary>
		[DispId(88)]
		bool WriteReserved { [DispId(88), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		[DispId(90)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string get_ActiveWritingStyle([MarshalAs(UnmanagedType.Struct), In] ref object LanguageID);

		[DispId(90)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void set_ActiveWritingStyle([MarshalAs(UnmanagedType.Struct), In] ref object LanguageID, [MarshalAs(UnmanagedType.BStr), In] string prop);

		/// <summary>
		/// Determines if the document or application was created or opened by the user.
		/// </summary>
		[DispId(92)]
		bool UserControl { [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		[DispId(93)]
		bool HasMailer { [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		[DispId(94)]
		Mailer Mailer { [DispId(94), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ReadabilityStatistics"/> collection that represents the readability statistics for the specified document.
		/// </summary>
		[DispId(96)]
		ReadabilityStatistics ReadabilityStatistics { [DispId(96), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ProofreadingErrors"/> collection that represents the sentences that failed the grammar check on the specified document or range.
		/// </summary>
		[DispId(97)]
		ProofreadingErrors GrammaticalErrors { [DispId(97), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.ProofreadingErrors"/> collection that represents the words identified as spelling errors in the specified document or range.
		/// </summary>
		[DispId(98)]
		ProofreadingErrors SpellingErrors { [DispId(98), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the VBProject object for the specified template or document.
		/// </summary>
		[DispId(99)]
		VBProject VBProject { [DispId(99), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns True if the specified document is in form design mode.
		/// </summary>
		[DispId(100)]
		bool FormsDesign { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		[DispId(-2147418112)]
		string _CodeName { [DispId(-2147418112), TypeLibFunc(1024), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(1024), DispId(-2147418112), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the code name for the specified document.
		/// </summary>
		[DispId(262)]
		string CodeName { [DispId(262), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if AutoShapes or East Asian characters are automatically aligned with an invisible grid when they are drawn, moved, or resized in the specified document.
		/// </summary>
		[DispId(300)]
		bool SnapToGrid { [DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word automatically aligns AutoShapes or East Asian characters with invisible gridlines that go through the vertical and horizontal edges of other AutoShapes or East Asian characters in the specified document.
		/// </summary>
		[DispId(301)]
		bool SnapToShapes { [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the amount of horizontal space between the invisible gridlines that Microsoft Word uses when you draw, move, and resize AutoShapes or East Asian characters in the specified document.
		/// </summary>
		[DispId(302)]
		float GridDistanceHorizontal { [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the amount of vertical space between the invisible gridlines that Microsoft Word uses when you draw, move, and resize AutoShapes or East Asian characters in the specified document.
		/// </summary>
		[DispId(303)]
		float GridDistanceVertical { [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the point, relative to the left edge of the page, where you want the invisible grid for drawing, moving, and resizing AutoShapes or East Asian characters to begin in the specified document.
		/// </summary>
		[DispId(304)]
		float GridOriginHorizontal { [DispId(304), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(304), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the point, relative to the top of the page, where you want the invisible grid for drawing, moving, and resizing AutoShapes or East Asian characters to begin in the specified document.
		/// </summary>
		[DispId(305)]
		float GridOriginVertical { [DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the interval at which Microsoft Word displays horizontal character gridlines in print layout view.
		/// </summary>
		[DispId(306)]
		int GridSpaceBetweenHorizontalLines { [DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the interval at which Microsoft Word displays vertical character gridlines in print layout view.
		/// </summary>
		[DispId(307)]
		int GridSpaceBetweenVerticalLines { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word starts the character grid from the upper-left corner of the page.
		/// </summary>
		[DispId(308)]
		bool GridOriginFromMargin { [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word kerns half-width Latin characters and punctuation marks in the specified document.
		/// </summary>
		[DispId(309)]
		bool KerningByAlgorithm { [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the character spacing adjustment for the specified document.
		/// </summary>
		[DispId(310)]
		WdJustificationMode JustificationMode { [DispId(310), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(310), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the line break control level for the specified document.
		/// </summary>
		[DispId(311)]
		WdFarEastLineBreakLevel FarEastLineBreakLevel { [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the kinsoku characters before which Microsoft Word will not break a line.
		/// </summary>
		[DispId(312)]
		string NoLineBreakBefore { [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the kinsoku characters after which Microsoft Word will not break a line.
		/// </summary>
		[DispId(313)]
		string NoLineBreakAfter { [DispId(313), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(313), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if changes are tracked in the specified document.
		/// </summary>
		[DispId(314)]
		bool TrackRevisions { [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if revision marks are printed with the document.
		/// </summary>
		[DispId(315)]
		bool PrintRevisions { [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if tracked changes in the specified document are shown on the screen.
		/// </summary>
		[DispId(316)]
		bool ShowRevisions { [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the name of the active theme plus the theme formatting options for the specified document.
		/// </summary>
		[DispId(540)]
		string ActiveTheme { [DispId(540), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the display name of the active theme for the specified document.
		/// </summary>
		[DispId(541)]
		string ActiveThemeDisplayName { [DispId(541), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.Email"/> object that contains all the e-mail – related properties of the current document.
		/// </summary>
		[DispId(319)]
		Email Email { [DispId(319), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.Scripts"/> collection that represents the collection of HTML scripts in the specified object.
		/// </summary>
		[DispId(320)]
		Scripts Scripts { [DispId(320), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a value that specifies whether Microsoft Word has detected the language of the specified text.
		/// </summary>
		[DispId(321)]
		bool LanguageDetected { [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the East Asian language to use when breaking lines of text in the specified document or template.
		/// </summary>
		[DispId(326)]
		WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.Frameset"/> object that represents an entire frames page or a single frame on a frames page.
		/// </summary>
		[DispId(327)]
		Frameset Frameset { [DispId(327), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the default paragraph style applied to text by the Click and Type feature in the specified document.
		/// </summary>
		[DispId(328)]
		object ClickAndTypeParagraphStyle { [TypeLibFunc(1024), DispId(328), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(1024), DispId(328), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Core.HTMLProject"/> object in the specified document that represents a top-level project branch, as in the Project Explorer of the Microsoft Script Editor.
		/// </summary>
		[DispId(329)]
		HTMLProject HTMLProject { [TypeLibFunc(64), DispId(329), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Word.WebOptions"/> object, which contains document-level attributes used by Microsoft Word when you save a document as a Web page or open a Web page.
		/// </summary>
		[DispId(330)]
		WebOptions WebOptions { [DispId(330), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the encoding used to open the specified document.
		/// </summary>
		[DispId(332)]
		MsoEncoding OpenEncoding { [DispId(332), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the encoding to use when saving a document.
		/// </summary>
		[DispId(333)]
		MsoEncoding SaveEncoding { [DispId(333), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(333), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word optimizes the current document for viewing in Word 97.
		/// </summary>
		[DispId(334)]
		bool OptimizeForWord97 { [DispId(334), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(334), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if the Visual Basic for Applications (VBA) project for the specified document has been digitally signed.
		/// </summary>
		[DispId(335)]
		bool VBASigned { [DispId(335), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Core.MsoEnvelope"/> object that represents an e-mail header for a document.
		/// </summary>
		[DispId(336)]
		MsoEnvelope MailEnvelope { [DispId(336), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if all features introduced after the version specified in the <see cref="P:Microsoft.Office.Interop.Word._Document.DisableFeaturesIntroducedAfter"/> property are disabled.
		/// </summary>
		[DispId(337)]
		bool DisableFeatures { [DispId(337), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(337), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word embeds common system fonts.
		/// </summary>
		[DispId(338)]
		bool DoNotEmbedSystemFonts { [DispId(338), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(338), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.SignatureSet"/> object that represents the digital signatures for a document.
		/// </summary>
		[DispId(339)]
		SignatureSet Signatures { [DispId(339), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a String indicating the browser frame in which to display a Web page reached through a hyperlink.
		/// </summary>
		[DispId(340)]
		string DefaultTargetFrame { [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.HTMLDivisions"/> object that represents an HTML division in a Web document.
		/// </summary>
		[DispId(342)]
		HTMLDivisions HTMLDivisions { [DispId(342), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Disables all features introduced after a specified version of Microsoft Word in the document only.
		/// </summary>
		[DispId(343)]
		WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfter { [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word removes all user information from comments, revisions, and the Properties dialog box upon saving a document.
		/// </summary>
		[DispId(344)]
		bool RemovePersonalInformation { [DispId(344), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(344), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.SmartTags"/> object that represents a smart tag in a document.
		/// </summary>
		[DispId(346)]
		SmartTags SmartTags { [TypeLibFunc(64), DispId(346), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if Microsoft Word saves the smart tag information in a document.
		/// </summary>
		[DispId(347)]
		bool EmbedSmartTags { [DispId(347), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(347), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines whether Microsoft Word creates an XML header containing smart tag information when a document containing smart tags is saved as HTML.
		/// </summary>
		[DispId(348)]
		bool SmartTagsAsXMLProps { [TypeLibFunc(64), DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the code page, or character set, that Microsoft Word uses for a document saved as an encoded text file.
		/// </summary>
		[DispId(357)]
		MsoEncoding TextEncoding { [DispId(357), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(357), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.WdLineEndingType"/> constant indicating how Microsoft Word marks the line and paragraph breaks in documents saved as text files.
		/// </summary>
		[DispId(358)]
		WdLineEndingType TextLineEnding { [DispId(358), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(358), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.StyleSheets"/> object that represents the Web style sheets attached to a document.
		/// </summary>
		[DispId(360)]
		StyleSheets StyleSheets { [DispId(360), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Object that represents the table style that is applied to all newly created tables in a document.
		/// </summary>
		[DispId(365)]
		object DefaultTableStyle { [DispId(365), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the name of the algorithm encryption provider that Microsoft Word uses when encrypting documents with passwords.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(367)]
		string PasswordEncryptionProvider { [DispId(367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String indicating the algorithm Microsoft Word uses for encrypting documents with passwords.
		/// </summary>
		[DispId(368)]
		string PasswordEncryptionAlgorithm { [DispId(368), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Integer indicating the key length of the algorithm Microsoft Word uses when encrypting documents with passwords.
		/// </summary>
		[DispId(369)]
		int PasswordEncryptionKeyLength { [DispId(369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns True if Microsoft Word encrypts file properties for password-protected documents.
		/// </summary>
		[DispId(370)]
		bool PasswordEncryptionFileProperties { [DispId(370), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Determines if Microsoft Word embeds speech and handwriting, stores East Asian IME keystrokes, and controls text service data received from devices.
		/// </summary>
		[DispId(377)]
		bool EmbedLinguisticData { [DispId(377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word displays font formatting in the Styles and Formatting task pane.
		/// </summary>
		[DispId(448)]
		bool FormattingShowFont { [DispId(448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word is to show clear formatting in the Styles and Formatting task pane.
		/// </summary>
		[DispId(449)]
		bool FormattingShowClear { [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word displays paragraph formatting in the Styles and Formatting task pane.
		/// </summary>
		[DispId(450)]
		bool FormattingShowParagraph { [DispId(450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Determines if Microsoft Word displays number formatting in the Styles and Formatting task pane.
		/// </summary>
		[DispId(451)]
		bool FormattingShowNumbering { [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.WdShowFilter"/> constant that represents the styles and formatting displayed in the Styles and Formatting task pane.
		/// </summary>
		[DispId(452)]
		WdShowFilter FormattingShowFilter { [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.Permission"/> object that represents the permission settings in the specified document.
		/// </summary>
		[DispId(453)]
		Permission Permission { [DispId(453), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.XMLNodes"/> collection that represents the collection of all XML elements within a document or in a selection or range— including those elements that are only partially within the selection or range.
		/// </summary>
		[DispId(460)]
		XMLNodes XMLNodes { [DispId(460), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.XMLSchemaReferences"/> collection that represents the schemas attached to a document.
		/// </summary>
		[DispId(461)]
		XMLSchemaReferences XMLSchemaReferences { [DispId(461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.SmartDocument"/> object that represents the settings for a smart document solution.
		/// </summary>
		[DispId(462)]
		SmartDocument SmartDocument { [DispId(462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.SharedWorkspace"/> object that represents the Document Workspace in which a specified document is located.
		/// </summary>
		[DispId(463)]
		SharedWorkspace SharedWorkspace { [TypeLibFunc(64), DispId(463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="P:Microsoft.Office.Interop.Word._Document.Sync"/> object that provides access to the methods and properties for documents that are part of a Document Workspace.
		/// </summary>
		[DispId(466)]
		Sync Sync { [DispId(466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether formatting restrictions are enforced in a protected document.
		/// </summary>
		[DispId(471)]
		bool EnforceStyle { [DispId(471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether automatic formatting options override formatting restrictions in a document where formatting restrictions are in effect.
		/// </summary>
		[DispId(472)]
		bool AutoFormatOverride { [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether a document is saved with the XML markup or as text only.
		/// </summary>
		[DispId(473)]
		bool XMLSaveDataOnly { [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean that represents whether to hide the XML namespaces in the list of elements in the XML Structure task pane.
		/// </summary>
		[DispId(477)]
		bool XMLHideNamespaces { [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether error message text is generated from the built-in Microsoft Word error messages or from the Microsoft XML Core Services (MSXML) 5.0 component included with Office.
		/// </summary>
		[DispId(478)]
		bool XMLShowAdvancedErrors { [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean that represents whether to save a document through an Extensible Stylesheet Language Transformation (XSLT).
		/// </summary>
		[DispId(474)]
		bool XMLUseXSLTWhenSaving { [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String that specifies the path and file name for the Extensible Stylesheet Language Transformation (XSLT) to apply when a user saves a document.
		/// </summary>
		[DispId(475)]
		string XMLSaveThroughXSLT { [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.DocumentLibraryVersions"/> collection that represents the collection of versions of a shared document that has versioning enabled and that is stored in a document library on a server.
		/// </summary>
		[DispId(476)]
		DocumentLibraryVersions DocumentLibraryVersions { [DispId(476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Sets or returns a Boolean that represents whether pages displayed in reading layout view are frozen to a specified size for inserting handwritten markup into a document.
		/// </summary>
		[DispId(481)]
		bool ReadingModeLayoutFrozen { [DispId(481), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(481), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean indicating whether a document stores the date and time metadata for tracked changes.
		/// </summary>
		[DispId(484)]
		bool RemoveDateAndTime { [DispId(484), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(484), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.XMLChildNodeSuggestions"/> collection that represents the list of allowed elements for the <see cref="T:Microsoft.Office.Interop.Word.Document"/> object (which returns the root elements for all attached schemas).
		/// </summary>
		[DispId(486)]
		XMLChildNodeSuggestions ChildNodeSuggestions { [DispId(486), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Word.XMLNodes"/> collection that represents all nodes in the document that have validation errors.
		/// </summary>
		[DispId(490)]
		XMLNodes XMLSchemaViolations { [DispId(490), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an Integer that represents the width of pages in a document when it is displayed in reading layout view and is frozen for entering handwritten markup.
		/// </summary>
		[DispId(491)]
		int ReadingLayoutSizeX { [DispId(491), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(491), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer that represents the height of pages in a document when it is displayed in reading layout view and is frozen for entering handwritten markup.
		/// </summary>
		[DispId(492)]
		int ReadingLayoutSizeY { [DispId(492), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(492), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the sort method to use when sorting styles in the Styles task pane. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdStyleSort"/>
		/// </returns>
		[DispId(493)]
		WdStyleSort StyleSortMethod { [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the metadata stored in a document, such as author name, subject, and company. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Core.MetaProperties"/>
		/// </returns>
		[DispId(496)]
		MetaProperties ContentTypeProperties { [DispId(496), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets aBoolean that represents whether to mark moved text when Track Changes is turned on. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(499)]
		bool TrackMoves { [DispId(499), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(499), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether to track formatting changes when change tracking is turned on. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(502)]
		bool TrackFormatting { [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Word.OMath"/> objects within the specified range. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.OMaths"/>
		/// </returns>
		[DispId(504)]
		OMaths OMaths { [DispId(504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the policy specified for a document stored on a server running Microsoft Office SharePoint Server 2007. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Core.ServerPolicy"/>
		/// </returns>
		[DispId(507)]
		ServerPolicy ServerPolicy { [DispId(507), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns all of the content controls in a document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.ContentControls"/>
		/// </returns>
		[DispId(508)]
		ContentControls ContentControls { [DispId(508), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Core.DocumentInspectors"/> collection that enables you to locate hidden personal information, such as author name, company name, and revision date. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Core.DocumentInspectors"/>
		/// </returns>
		[DispId(510)]
		DocumentInspectors DocumentInspectors { [DispId(510), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the bibliography references contained within a document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.Bibliography"/>
		/// </returns>
		[DispId(516)]
		Bibliography Bibliography { [DispId(516), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether a user can change a document theme. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(517)]
		bool LockTheme { [DispId(517), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(517), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether users can change which set of Quick Styles is being used. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Booleans
		/// </returns>
		[DispId(518)]
		bool LockQuickStyleSet { [DispId(518), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(518), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the document title for the original document after running a legal-blackline document compare function. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(519)]
		string OriginalDocumentTitle { [DispId(519), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the document title for a revised document after running a legal-blackline document compare function. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(520)]
		string RevisedDocumentTitle { [DispId(520), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="CustomXMLParts#SameCHM"/> collection that represents the custom XML in the XML data store. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Core._CustomXMLParts"/>
		/// </returns>
		[DispId(521)]
		CustomXMLParts CustomXMLParts { [DispId(521), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether Microsoft Office Word shows the next heading level when the previous heading level is used. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(522)]
		bool FormattingShowNextLevel { [DispId(522), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(522), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether to show user-defined styles. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(523)]
		bool FormattingShowUserStyleName { [DispId(523), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(523), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the research service for a document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Research
		/// </returns>
		[DispId(526)]
		Research Research { [DispId(526), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean that indicates whether a document is final. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(527)]
		bool Final { [DispId(527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.WdOMathBreakBin"/> enumeration value that represents where Microsoft Office Word places binary operators when equations span two or more lines. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdOMathBreakBin"/>
		/// </returns>
		[DispId(528)]
		WdOMathBreakBin OMathBreakBin { [DispId(528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Word.WdOMathBreakSub"/> enumeration value that represents how Microsoft Office Word handles a subtraction operator that falls before a line break. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdOMathBreakSub"/>
		/// </returns>
		[DispId(529)]
		WdOMathBreakSub OMathBreakSub { [DispId(529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the default justification—left, right, centered, or centered as a group—of a group of equations. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Interop.Word.WdOMathJc"/>
		/// </returns>
		[DispId(530)]
		WdOMathJc OMathJc { [DispId(530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the left margin for equations. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Single
		/// </returns>
		[DispId(531)]
		float OMathLeftMargin { [DispId(531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the right margin for equations. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Single
		/// </returns>
		[DispId(532)]
		float OMathRightMargin { [DispId(532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the placement of the second line of an equation that wraps to a new line. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Single
		/// </returns>
		[DispId(535)]
		float OMathWrap { [DispId(535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents the default location of limits for integrals. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(536)]
		bool OMathIntSubSupLim { [DispId(536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents the default location of limits for <paramref name="n"/>-ary objects other than integrals. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(537)]
		bool OMathNarySupSubLim { [DispId(537), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(537), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether to use small fractions in equations contained within the document. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(539)]
		bool OMathSmallFrac { [DispId(539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the flat XML format for the Word Open XML contents of the document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(542)]
		string WordOpenXML { [DispId(542), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Core.OfficeTheme"/> object that represents the Microsoft Office theme applied to a document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// <see cref="T:Microsoft.Office.Core.OfficeTheme"/>
		/// </returns>
		[DispId(545)]
		OfficeTheme DocumentTheme { [DispId(545), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean that represents whether a document has an attached Microsoft Visual Basic for Applications project. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(548)]
		bool HasVBProject { [DispId(548), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the name of the font used in a document to display equations. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// String
		/// </returns>
		[DispId(555)]
		string OMathFontName { [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String specifying the name of the algorithm encryption provider that Microsoft Office Word uses when encrypting documents. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Returns <see cref="T:System.String"/>.
		/// </returns>
		[DispId(559)]
		string EncryptionProvider { [DispId(559), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(559), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean that represents whether to use the default math settings when creating new equations. Read/write.
		/// </summary>
		/// 
		/// <returns>
		/// Boolean
		/// </returns>
		[DispId(560)]
		bool UseMathDefaults { [DispId(560), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(560), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a random number that Word assigns to changes in a document. Read-only.
		/// </summary>
		/// 
		/// <returns>
		/// Integer
		/// </returns>
		[DispId(563)]
		int CurrentRsid { [DispId(563), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <returns>
		/// Returns <see cref="T:System.Int32"/>.
		/// </returns>
		[DispId(564)]
		int DocID { [DispId(564), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a long that specifies the compatibility mode that Word 2010 uses when opening the document.
		/// </summary>
		/// 
		/// <returns>
		/// Returns <see cref="T:System.Int32"/>.
		/// </returns>
		[DispId(567)]
		int CompatibilityMode { [DispId(567), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Word.CoAuthoring"/> object that provides an entry point to co-authoring-related object model in the document.
		/// </summary>
		/// 
		/// <returns>
		/// Returns <see cref="T:Microsoft.Office.Interop.Word.CoAuthoring"/>.
		/// </returns>
		[DispId(600)]
		CoAuthoring CoAuthoring { [DispId(600), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
