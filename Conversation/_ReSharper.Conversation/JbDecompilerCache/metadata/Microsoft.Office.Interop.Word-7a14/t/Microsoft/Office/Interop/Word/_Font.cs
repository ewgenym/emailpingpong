// Type: Microsoft.Office.Interop.Word._Font
// Assembly: Microsoft.Office.Interop.Word, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Word
{
	/// <summary>
	/// Contains font attributes (font name, font size, color, and so on) for an object.
	/// </summary>
	[Guid("00020952-0000-0000-C000-000000000046")]
	[TypeLibType(4304)]
	[ComImport]
	public interface _Font
	{
		/// <summary>
		/// Increases the font size to the next available size. If the selection or range contains more than one font size, each size is increased to the next available setting.
		/// </summary>
		[DispId(100)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Grow();

		/// <summary>
		/// Decreases the font size to the next available size.
		/// </summary>
		[DispId(101)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Shrink();

		/// <summary>
		/// Removes manual character formatting (formatting not applied using a style).
		/// </summary>
		[DispId(102)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Reset();

		/// <summary>
		/// Sets the specified font formatting as the default for the active document and all new documents based on the active template. The default font formatting is stored in the Normal style.
		/// </summary>
		[DispId(103)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetAsTemplateDefault();

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
		/// Returns a read-only <see cref="T:Microsoft.Office.Interop.Word.Font"/> object that represents the character formatting of the specified font.
		/// </summary>
		[DispId(10)]
		Font Duplicate { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// True if the font or range is formatted as bold. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(130)]
		int Bold { [DispId(130), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(130), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font or range is formatted as italic. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(131)]
		int Italic { [DispId(131), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(131), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as hidden text. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(132)]
		int Hidden { [DispId(132), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(132), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as small capital letters. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(133)]
		int SmallCaps { [DispId(133), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(133), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as all capital letters. Returns True, False, or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle (reverses the current setting). Read/write Integer.
		/// </summary>
		[DispId(134)]
		int AllCaps { [DispId(134), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(134), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as strikethrough text. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(135)]
		int StrikeThrough { [DispId(135), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(135), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the specified font is formatted as double strikethrough text. Returns True, False, or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(136)]
		int DoubleStrikeThrough { [DispId(136), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(136), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the color for the specified <see cref="T:Microsoft.Office.Interop.Word.Border"/> or <see cref="T:Microsoft.Office.Interop.Word.Font"/> object.
		/// </summary>
		[DispId(137)]
		WdColorIndex ColorIndex { [DispId(137), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(137), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as subscript. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(138)]
		int Subscript { [DispId(138), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(138), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as superscript. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Long.
		/// </summary>
		[DispId(139)]
		int Superscript { [DispId(139), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(139), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the type of underline applied to the font. Read/write <see cref="T:Microsoft.Office.Interop.Word.WdUnderline"/>.
		/// </summary>
		[DispId(140)]
		WdUnderline Underline { [DispId(140), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(140), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the font size in points. Read/write Single.
		/// </summary>
		[DispId(141)]
		float Size { [DispId(141), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(141), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the name of the specified object. Read/write String.
		/// </summary>
		[DispId(142)]
		string Name { [DispId(142), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(142), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the position of text (in points) relative to the base line. A positive number raises the text, and a negative number lowers it. Read/write Integer.
		/// </summary>
		[DispId(143)]
		int Position { [DispId(143), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(143), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the spacing (in points) between characters. Read/write Single.
		/// </summary>
		[DispId(144)]
		float Spacing { [DispId(144), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(144), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the scaling percentage applied to the font. This property stretches or compresses text horizontally as a percentage of the current size (the scaling range is from 1 through 600). Read/write Integer.
		/// </summary>
		[DispId(145)]
		int Scaling { [DispId(145), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(145), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the specified font is formatted as shadowed. Can be True, False, or wdUndefined. Read/write Integer.
		/// </summary>
		[DispId(146)]
		int Shadow { [DispId(146), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(146), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as outline. Returns True, False, or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(147)]
		int Outline { [DispId(147), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(147), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the specified font is formatted as embossed. Returns True, False, or wdUndefined. Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(148)]
		int Emboss { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the minimum font size for which Microsoft Word will adjust kerning automatically. Read/write Single.
		/// </summary>
		[DispId(149)]
		float Kerning { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font is formatted as engraved. Returns True, False or wdUndefined (a mixture of True and False). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(150)]
		int Engrave { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the type of animation applied to the font.
		/// </summary>
		[DispId(151)]
		WdAnimation Animation { [DispId(151), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(151), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

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
		[DispId(153)]
		Shading Shading { [DispId(153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets the emphasis mark for a character or designated character string.
		/// </summary>
		[DispId(154)]
		WdEmphasisMark EmphasisMark { [DispId(154), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(154), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if Microsoft Word ignores the number of characters per line for the corresponding <see cref="T:Microsoft.Office.Interop.Word.Font"/> object. Read/write Boolean.
		/// </summary>
		[DispId(155)]
		bool DisableCharacterSpaceGrid { [DispId(155), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(155), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an East Asian font name. Read/write String.
		/// </summary>
		[DispId(156)]
		string NameFarEast { [DispId(156), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(156), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the font used for Latin text (characters with character codes from 0 (zero) through 127). Read/write String.
		/// </summary>
		[DispId(157)]
		string NameAscii { [DispId(157), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(157), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the font used for characters with character codes from 128 through 255. Read/write String.
		/// </summary>
		[DispId(158)]
		string NameOther { [DispId(158), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(158), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the 24-bit color for the specified <see cref="T:Microsoft.Office.Interop.Word.Font"/> object.
		/// </summary>
		[DispId(159)]
		WdColor Color { [TypeLibFunc(64), DispId(159), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(159), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font or range is formatted as bold. Returns True, False or wdUndefined (for a mixture of bold and non-bold text). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(160)]
		int BoldBi { [DispId(160), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(160), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// True if the font or range is formatted as italic. Returns True, False or wdUndefined (for a mixture of italic and non-italic text). Can be set to True, False, or wdToggle. Read/write Integer.
		/// </summary>
		[DispId(161)]
		int ItalicBi { [DispId(161), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(161), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the font size in points. Read/write Single.
		/// </summary>
		[DispId(162)]
		float SizeBi { [DispId(162), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(162), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the name of the font in a right-to-left language document. Read/write String.
		/// </summary>
		[DispId(163)]
		string NameBi { [DispId(163), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(163), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the color for the specified <see cref="T:Microsoft.Office.Interop.Word.Font"/> object in a right-to-left language document.
		/// </summary>
		[DispId(164)]
		WdColorIndex ColorIndexBi { [DispId(164), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(164), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the 24-bit color to be used for diacritics for the specified <see cref="T:Microsoft.Office.Interop.Word.Font"/> object. Can be any valid <see cref="T:Microsoft.Office.Interop.Word.WdColor"/> constant or a value returned by Visual Basic's RGB function. Read/write.
		/// </summary>
		[DispId(165)]
		WdColor DiacriticColor { [DispId(165), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(165), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the 24-bit color of the underline for the specified <see cref="T:Microsoft.Office.Interop.Word.Font"/> object.
		/// </summary>
		[DispId(166)]
		WdColor UnderlineColor { [DispId(166), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(166), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.GlowFormat"/> object that represents the glow formatting for the font used by the specified range of text.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.GlowFormat"/> object.
		/// </returns>
		[DispId(167)]
		GlowFormat Glow { [DispId(167), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(167), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.ReflectionFormat"/> object that represents the reflection formatting for a shape.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.ReflectionFormat"/> object.
		/// </returns>
		[DispId(168)]
		ReflectionFormat Reflection { [DispId(168), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(168), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.ShadowFormat"/> object that specifies the shadow formatting for the specified font.
		/// </summary>
		/// 
		/// <returns>
		/// The shadow formatting for the specified font.
		/// </returns>
		[DispId(169)]
		ShadowFormat TextShadow { [DispId(169), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(169), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.FillFormat"/> object that contains fill formatting properties for the font used by the specified range of text.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.FillFormat"/> object.
		/// </returns>
		[DispId(170)]
		FillFormat Fill { [DispId(170), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(170), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.LineFormat"/> object that specifies the formatting for a line.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.LineFormat"/> object.
		/// </returns>
		[DispId(171)]
		LineFormat Line { [DispId(171), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(171), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.ThreeDFormat"/> object that contains 3-D effect formatting properties for the specified font.
		/// </summary>
		/// 
		/// <returns>
		/// The 3-D effect formatting properties for the specified font.
		/// </returns>
		[DispId(172)]
		ThreeDFormat ThreeD { [DispId(172), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(172), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets a <see cref="T:Microsoft.Office.Interop.Word.ColorFormat"/> object that represents the color for the specified font.
		/// </summary>
		/// 
		/// <returns>
		/// The color for the specified font.
		/// </returns>
		[DispId(173)]
		ColorFormat TextColor { [DispId(173), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Gets or sets the ligatures setting for the specified Font object.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.WdLigatures"/> object.
		/// </returns>
		[DispId(174)]
		WdLigatures Ligatures { [DispId(174), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(174), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the number form setting for an OpenType font.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.WdNumberForm"/> object.
		/// </returns>
		[DispId(175)]
		WdNumberForm NumberForm { [DispId(175), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(175), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets or sets the number spacing setting for a font.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Word.WdNumberSpacing"/> object.
		/// </returns>
		[DispId(176)]
		WdNumberSpacing NumberSpacing { [DispId(176), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(176), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Specifies whether or not contextual alternates are enabled for the specified font.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Int32"/> object.
		/// </returns>
		[DispId(177)]
		int ContextualAlternates { [DispId(177), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(177), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Gets or sets the stylistic set for the specified font.
		/// </summary>
		/// 
		/// <returns>
		/// The stylistic set.
		/// </returns>
		[DispId(178)]
		WdStylisticSet StylisticSet { [DispId(178), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(178), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }
	}
}
