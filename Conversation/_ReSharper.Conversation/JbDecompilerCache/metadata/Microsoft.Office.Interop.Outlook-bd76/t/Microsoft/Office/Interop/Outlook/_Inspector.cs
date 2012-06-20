// Type: Microsoft.Office.Interop.Outlook._Inspector
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using Microsoft.Office.Core;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/>.
	/// </summary>
	[TypeLibType(4160)]
	[Guid("00063005-0000-0000-C000-000000000046")]
	[ComImport]
	public interface _Inspector
	{
		/// <summary>
		/// Closes the  <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/> and optionally saves changes to the displayed Outlook item.
		/// </summary>
		/// <param name="SaveMode">The close behavior. If the item displayed within the inspector has not been changed, this argument has no effect.</param>
		[DispId(8451)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Close([In] OlInspectorClose SaveMode);

		/// <summary>
		/// Displays a new <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/> object for the item.
		/// </summary>
		/// <param name="Modal">True to make the window modal. The default value is False.</param>
		[DispId(8452)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Display([MarshalAs(UnmanagedType.Struct), In, Optional] object Modal);

		/// <summary>
		/// Hides a form page in the inspector.
		/// </summary>
		/// <param name="PageName">The display name of the page to be hidden.</param>
		[DispId(8456)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void HideFormPage([MarshalAs(UnmanagedType.BStr), In] string PageName);

		/// <summary>
		/// Determines whether the mail message associated with an inspector is displayed in an Outlook <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/>  or in Microsoft Word.
		/// </summary>
		/// 
		/// <returns>
		/// True if the mail message is displayed in Microsoft Word (that is, if Word Mail is in use); otherwise, False.
		/// </returns>
		[DispId(8453)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool IsWordMail();

		/// <summary>
		/// Displays the specified form page in the inspector.
		/// </summary>
		/// <param name="PageName">The display name of the form page.</param>
		[DispId(8460)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCurrentFormPage([MarshalAs(UnmanagedType.BStr), In] string PageName);

		/// <summary>
		/// Shows a form page in the inspector.
		/// </summary>
		/// <param name="PageName">The display name of the page to be shown.</param>
		[DispId(8457)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ShowFormPage([MarshalAs(UnmanagedType.BStr), In] string PageName);

		/// <summary>
		/// Activates an inspector window by bringing it to the foreground and setting keyboard focus.
		/// </summary>
		[DispId(8467)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Activate();

		/// <summary>
		/// Binds an Outlook object model property to a control in an inspector.
		/// </summary>
		/// <param name="Control">The control that will be bound to a property.</param><param name="PropertyName">The name of the property that will be bound to the control.</param>
		[DispId(64201)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetControlItemProperty([MarshalAs(UnmanagedType.IDispatch), In] object Control, [MarshalAs(UnmanagedType.BStr), In] string PropertyName);

		/// <summary>
		/// Opens a new page in design mode in the inspector for a new form region.
		/// </summary>
		/// 
		/// <returns>
		/// An Object that represents the page displaying the form region in the inspector.
		/// </returns>
		[DispId(64493)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object NewFormRegion();

		/// <summary>
		/// Opens a page in design mode in the inspector for the specified form region.
		/// </summary>
		/// 
		/// <returns>
		/// An Object that represents the page displaying the form region in the inspector.
		/// </returns>
		/// <param name="Path">A full local file path to the Outlook Form Storage (.OFS) file for the form region that is to be opened in the inspector.</param>
		[DispId(64511)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object OpenFormRegion([MarshalAs(UnmanagedType.BStr), In] string Path);

		/// <summary>
		/// Saves the specified page in design mode in the inspector to the specified file.
		/// </summary>
		/// <param name="Page">The page displaying the form region in the inspector.</param><param name="FileName">The full local file path to an Outlook Form Storage (.OFS) file that the form region is being saved to. </param>
		[DispId(64512)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SaveFormRegion([MarshalAs(UnmanagedType.IDispatch), In] object Page, [MarshalAs(UnmanagedType.BStr), In] string FileName);

		/// <summary>
		/// Sets the start time for a meeting item in the free/busy grid on the Scheduling Assistant tab of the inspector.
		/// </summary>
		/// <param name="Start">The beginning of the time range that the Scheduling Assistant tab of the inspector displays free/busy times for meeting attendees.</param>
		[DispId(64647)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetSchedulingStartTime([In] DateTime Start);

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Application"/>  object that represents the parent Outlook application for the  object. Read-only.
		/// </summary>
		[DispId(61440)]
		Application Application { [DispId(61440), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlObjectClass"/> constant indicating the object's class. Read-only.
		/// </summary>
		[DispId(61450)]
		OlObjectClass Class { [DispId(61450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.NameSpace"/>  object for the current session. Read-only.
		/// </summary>
		[DispId(61451)]
		NameSpace Session { [DispId(61451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the parent Object of the specified object. Read-only.
		/// </summary>
		[DispId(61441)]
		object Parent { [DispId(61441), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(8448)]
		CommandBars CommandBars { [DispId(8448), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an Object representing the current item being displayed in the inspector. Read-only.
		/// </summary>
		[DispId(8450)]
		object CurrentItem { [DispId(8450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlEditorType"/> constant indicating the type of editor. Read-only.
		/// </summary>
		[DispId(8464)]
		OlEditorType EditorType { [DispId(8464), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.Pages"/>  collection that represents all the pages for the item in the inspector. Read-only.
		/// </summary>
		[DispId(8454)]
		object ModifiedFormPages { [DispId(8454), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(8462)]
		object HTMLEditor { [TypeLibFunc(64), DispId(8462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the Microsoft Word Document Object Model of the  message being displayed. Read-only.
		/// </summary>
		[DispId(8463)]
		object WordEditor { [DispId(8463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the title. Read-only.
		/// </summary>
		[DispId(8465)]
		string Caption { [DispId(8465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value specifying the height (in pixels) of the inspector window. Read/write.
		/// </summary>
		[DispId(8468)]
		int Height { [DispId(8468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value specifying the position (in pixels) of the left vertical edge of an inspector window from the edge of the screen. Read/write.
		/// </summary>
		[DispId(8469)]
		int Left { [DispId(8469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value indicating the position (in pixels) of the top horizontal edge of an inspector window from the edge of the screen. Read/write.
		/// </summary>
		[DispId(8470)]
		int Top { [DispId(8470), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8470), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value indicating the width (in pixels) of the specified object. Read/write.
		/// </summary>
		[DispId(8471)]
		int Width { [DispId(8471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets the property with a constant in the  <see cref="T:Microsoft.Office.Interop.Outlook.OlWindowState"/> enumeration specifying the window state of an explorer or inspector window. Read/write.
		/// </summary>
		[DispId(8466)]
		OlWindowState WindowState { [DispId(8466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(8466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Obtains an <see cref="T:Microsoft.Office.Interop.Outlook.AttachmentSelection"/> object consisting of one or more attachments that are selected in the inspector. Read-only.
		/// </summary>
		[DispId(64632)]
		AttachmentSelection AttachmentSelection { [DispId(64632), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
