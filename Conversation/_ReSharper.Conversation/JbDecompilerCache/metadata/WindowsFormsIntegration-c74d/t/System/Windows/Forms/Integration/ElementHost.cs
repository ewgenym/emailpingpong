// Type: System.Windows.Forms.Integration.ElementHost
// Assembly: WindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\WindowsFormsIntegration.dll

using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Runtime;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;

namespace System.Windows.Forms.Integration
{
	/// <summary>
	/// A Windows Forms control that can be used to host a Windows Presentation Foundation (WPF) element.
	/// </summary>
	[DefaultEvent("ChildChanged")]
	[DesignerSerializer("WindowsFormsIntegration.Design.ElementHostCodeDomSerializer, WindowsFormsIntegration.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[ContentProperty("Child")]
	[Designer("WindowsFormsIntegration.Design.ElementHostDesigner, WindowsFormsIntegration.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public class ElementHost : System.Windows.Forms.Control
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Forms.Integration.ElementHost"/> class.
		/// </summary>
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public ElementHost();

		/// <summary>
		/// Overrides the base class implementation <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)"/> to provide correct layout behavior for the hosted Windows Presentation Foundation (WPF) elements.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Drawing.Size"/> computed by the <see cref="T:System.Windows.Forms.Integration.ElementHost"/> control, given the constraints specified by <paramref name="proposedSize"/>.
		/// </returns>
		/// <param name="proposedSize">The custom-sized area for a WPF element. </param>
		public override System.Drawing.Size GetPreferredSize(System.Drawing.Size proposedSize);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged"/> event.
		/// </summary>
		/// <param name="e">The data for the event.</param>
		protected override void OnEnabledChanged(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.Leave"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
		protected override void OnLeave(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Integration.ElementHost.GotFocus"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
		protected override void OnGotFocus(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
		protected override void OnVisibleChanged(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.Paint"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains the event data.</param>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void OnPaint(PaintEventArgs e);

		/// <summary>
		/// Paints the background of the control.
		/// </summary>
		/// <param name="pevent">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains information about the control to paint.</param>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void OnPaintBackground(PaintEventArgs pevent);

		/// <summary>
		/// Renders the control using the provided <see cref="T:System.Drawing.Graphics"/> object.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains the event data. </param>
		protected override void OnPrint(PaintEventArgs e);

		/// <summary>
		/// Activates the hosted element.
		/// </summary>
		/// <param name="directed">true to specify the direction of the control to select; otherwise, false. </param><param name="forward">true to move forward in the tab order; false to move backward in the tab order.</param>
		protected override void Select(bool directed, bool forward);

		/// <summary>
		/// Processes a command key, ensuring that the hosted element has an opportunity to handle the command before normal Windows Forms processing.
		/// </summary>
		/// 
		/// <returns>
		/// true if the character is a Windows Presentation Foundation (WPF) shortcut key; otherwise, false.
		/// </returns>
		/// <param name="msg">A <see cref="T:System.Windows.Forms.Message"/>, passed by reference, that represents the window message to process.</param><param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys"/> values representing the key to process.</param>
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData);

		/// <summary>
		/// Processes a mnemonic character, ensuring that the hosted element has an opportunity to handle the mnemonic before normal Windows Forms processing.
		/// </summary>
		/// 
		/// <returns>
		/// true if the character is a Windows Presentation Foundation (WPF) shortcut key; otherwise, false.
		/// </returns>
		/// <param name="charCode">The character to process.</param>
		[UIPermission(SecurityAction.LinkDemand, Window = UIPermissionWindow.AllWindows)]
		protected override bool ProcessMnemonic(char charCode);

		/// <summary>
		/// Ensures that all WM_CHAR key messages are forwarded to the hosted element.
		/// </summary>
		/// 
		/// <returns>
		/// true in all cases.
		/// </returns>
		/// <param name="charCode">The character to forward.</param>
		protected override bool IsInputChar(char charCode);

		/// <summary>
		/// Enables a <see cref="T:System.Windows.Window"/> to receive keyboard messages correctly when it is opened modelessly from Windows Forms.
		/// </summary>
		/// <param name="window">The Windows Presentation Foundation (WPF) window to be opened modelessly.</param>
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		public static void EnableModelessKeyboardInterop(Window window);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
		protected override void OnHandleCreated(EventArgs e);

		/// <summary>
		/// Processes Windows messages.
		/// </summary>
		/// <param name="m">A message to process.</param>
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m);

		/// <summary>
		/// Scales the parent container and the hosted Windows Forms control.
		/// </summary>
		/// <param name="dx">The scaling factor for the x-axis.</param><param name="dy">The scaling factor for the y-axis.</param>
		protected override void ScaleCore(float dx, float dy);

		/// <summary>
		/// Immediately frees any system resources used by the <see cref="T:System.Windows.Forms.Integration.ElementHost"/> control.
		/// </summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		protected override void Dispose(bool disposing);

		/// <summary>
		/// Notifies the <see cref="P:System.Windows.Forms.Integration.ElementHost.PropertyMap"/> that a property has changed.
		/// </summary>
		/// <param name="propertyName">The name of the property that has changed and requires translation.</param><param name="value">The new value of the property.</param>
		[UIPermission(SecurityAction.InheritanceDemand, Window = UIPermissionWindow.AllWindows)]
		public virtual void OnPropertyChanged(string propertyName, object value);

		/// <summary>
		/// Gets the default size of the control.
		/// </summary>
		/// 
		/// <returns>
		/// The default <see cref="T:System.Drawing.Size"/> of the control.
		/// </returns>
		protected override System.Drawing.Size DefaultSize { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the control is automatically resized to display its entire contents.
		/// </summary>
		/// 
		/// <returns>
		/// true if the control adjusts its size to closely fit its contents; otherwise, false. The default is true.
		/// </returns>
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override bool AutoSize { get; set; }

		/// <summary>
		/// Gets the parent container of the hosted Windows Presentation Foundation (WPF) element.
		/// </summary>
		/// 
		/// <returns>
		/// The parent container.
		/// </returns>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public System.Windows.Controls.Panel HostContainer { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets or sets the <see cref="T:System.Windows.UIElement"/> hosted by the <see cref="T:System.Windows.Forms.Integration.ElementHost"/> control.
		/// </summary>
		/// 
		/// <returns>
		/// The hosted Windows Presentation Foundation (WPF) element.
		/// </returns>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public UIElement Child { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; set; }

		/// <summary>
		/// Gets a value that indicates whether the <see cref="P:System.Windows.Forms.Control.ImeMode"/> property can be set to an active value to enable IME support.
		/// </summary>
		/// 
		/// <returns>
		/// true if <see cref="T:System.Windows.Forms.Integration.ElementHost"/> has a <see cref="P:System.Windows.Forms.Integration.ElementHost.Child"/> element; otherwise, false.
		/// </returns>
		protected override bool CanEnableIme { get; }

		/// <summary>
		/// Gets a value that indicates whether the control has input focus.
		/// </summary>
		/// 
		/// <returns>
		/// true if the control has focus; otherwise, false.
		/// </returns>
		public override bool Focused { get; }

		/// <summary>
		/// Gets or sets the IME mode of a control.
		/// </summary>
		/// 
		/// <returns>
		/// The IME mode of the control.
		/// </returns>
		protected override ImeMode ImeModeBase { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the hosted element has a transparent background.
		/// </summary>
		/// 
		/// <returns>
		/// true if the hosted element has a transparent background; otherwise, false. The default is false.
		/// </returns>
		[DefaultValue(false)]
		public bool BackColorTransparent { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; set; }

		/// <summary>
		/// Gets the property map, which determines how setting properties on the <see cref="T:System.Windows.Forms.Integration.ElementHost"/> control affects the hosted Windows Presentation Foundation (WPF) element.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Forms.Integration.PropertyMap"/> that maps <see cref="T:System.Windows.Forms.Integration.ElementHost"/> to properties on the hosted WPF element.
		/// </returns>
		[Browsable(false)]
		public PropertyMap PropertyMap { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; }

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.Integration.WindowsFormsHost.Child"/> property is set.
		/// </summary>
		public event EventHandler<ChildChangedEventArgs> ChildChanged;

		/// <summary>
		/// Occurs when the value of the <see cref="T:System.Windows.Forms.BindingContext"/> property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler BindingContextChanged;

		/// <summary>
		/// Occurs when the control is clicked.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler Click;

		/// <summary>
		/// Occurs when the value of the <see cref="P:System.Windows.Forms.Control.ClientSize"/> property changes.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler ClientSizeChanged;

		/// <summary>
		/// Occurs when a new control is added to the <see cref="T:System.Windows.Forms.Control.ControlCollection"/>.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event ControlEventHandler ControlAdded;

		/// <summary>
		/// Occurs when a control is removed from the <see cref="T:System.Windows.Forms.Control.ControlCollection"/>.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event ControlEventHandler ControlRemoved;

		/// <summary>
		/// Occurs when the value of the <see cref="P:System.Windows.Forms.Control.Cursor"/> property changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler CursorChanged;

		/// <summary>
		/// Occurs when the control is double-clicked.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler DoubleClick;

		/// <summary>
		/// Occurs when a drag-and-drop operation is completed.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event System.Windows.Forms.DragEventHandler DragDrop;

		/// <summary>
		/// Occurs when an object is dragged into the control's bounds.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event System.Windows.Forms.DragEventHandler DragEnter;

		/// <summary>
		/// Occurs when an object is dragged out of the control's bounds.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler DragLeave;

		/// <summary>
		/// Occurs when an object is dragged over the control's bounds.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event System.Windows.Forms.DragEventHandler DragOver;

		/// <summary>
		/// Occurs when the control is entered.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler Enter;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.Control.Font"/> property value changes.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler FontChanged;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.Control.ForeColor"/> property value changes.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler ForeColorChanged;

		/// <summary>
		/// Occurs during a drag operation.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;

		/// <summary>
		/// Occurs when the control receives focus.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler GotFocus;

		/// <summary>
		/// Occurs when a control's display requires redrawing.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event InvalidateEventHandler Invalidated;

		/// <summary>
		/// Occurs when a key is pressed while the control has focus.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event KeyEventHandler KeyDown;

		/// <summary>
		/// Occurs when a key is pressed while the control has focus.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event KeyPressEventHandler KeyPress;

		/// <summary>
		/// Occurs when a key is released while the control has focus.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event KeyEventHandler KeyUp;

		/// <summary>
		/// Occurs when a control should reposition its child controls.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event LayoutEventHandler Layout;

		/// <summary>
		/// Occurs when the input focus leaves the control.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler Leave;

		/// <summary>
		/// Occurs when the control loses focus.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler LostFocus;

		/// <summary>
		/// Occurs when the control loses or gains mouse capture.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler MouseCaptureChanged;

		/// <summary>
		/// Occurs when the control is clicked by the mouse.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event MouseEventHandler MouseClick;

		/// <summary>
		/// Occurs when the control is double clicked by the mouse.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event MouseEventHandler MouseDoubleClick;

		/// <summary>
		/// Occurs when the mouse pointer is over the control and a mouse button is pressed.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event MouseEventHandler MouseDown;

		/// <summary>
		/// Occurs when the mouse pointer enters the control.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler MouseEnter;

		/// <summary>
		/// Occurs when the mouse pointer rests on the control.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler MouseHover;

		/// <summary>
		/// Occurs when the mouse pointer leaves the control.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler MouseLeave;

		/// <summary>
		/// Occurs when the mouse pointer is moved over the control.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event MouseEventHandler MouseMove;

		/// <summary>
		/// Occurs when the mouse pointer is over the control and a mouse button is released.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event MouseEventHandler MouseUp;

		/// <summary>
		/// Occurs when the mouse wheel moves while the control has focus.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event MouseEventHandler MouseWheel;

		/// <summary>
		/// Occurs when the control's padding changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler PaddingChanged;

		/// <summary>
		/// Occurs when the <see cref="T:System.Windows.Forms.Integration.ElementHost"/> control is redrawn.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event PaintEventHandler Paint;

		/// <summary>
		/// Occurs before the <see cref="E:System.Windows.Forms.Control.KeyDown"/> event when a key is pressed while focus is on this control.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event PreviewKeyDownEventHandler PreviewKeyDown;

		/// <summary>
		/// Occurs during a drag-and-drop operation and enables the drag source to determine whether the drag-and-drop operation should be canceled.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag;

		/// <summary>
		/// Occurs when the control is resized.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler Resize;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.Control.RightToLeft"/> property value changes.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler RightToLeftChanged;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.Control.Size"/> property value changes.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler SizeChanged;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.Control.Text"/> property value changes.
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler TextChanged;
	}
}
