// Type: System.Windows.Forms.UserControl
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Windows.Forms
{
	/// <summary>
	/// Provides an empty control that can be used to create other controls.
	/// </summary>
	/// <filterpriority>2</filterpriority>
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Designer("System.Windows.Forms.Design.UserControlDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (IRootDesigner))]
	[ComVisible(true)]
	[Designer("System.Windows.Forms.Design.ControlDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("UserControl")]
	[DefaultEvent("Load")]
	public class UserControl : ContainerControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Forms.UserControl"/> class.
		/// </summary>
		public UserControl();

		/// <returns>
		/// true if all of the children validated successfully; otherwise, false. If called from the <see cref="E:System.Windows.Forms.Control.Validating"/> or <see cref="E:System.Windows.Forms.Control.Validated"/> event handlers, this method will always return false.
		/// </returns>
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override bool ValidateChildren();

		/// <returns>
		/// true if all of the children validated successfully; otherwise, false. If called from the <see cref="E:System.Windows.Forms.Control.Validating"/> or <see cref="E:System.Windows.Forms.Control.Validated"/> event handlers, this method will always return false.
		/// </returns>
		/// <param name="validationConstraints">Places restrictions on which controls have their <see cref="E:System.Windows.Forms.Control.Validating"/> event raised.</param>
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		public override bool ValidateChildren(ValidationConstraints validationConstraints);

		/// <summary>
		/// Raises the CreateControl event.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected override void OnCreateControl();

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.UserControl.Load"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnLoad(EventArgs e);

		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
		protected override void OnResize(EventArgs e);

		/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs"/> that contains the event data. </param>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected override void OnMouseDown(MouseEventArgs e);

		/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message"/> to process. </param>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m);

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override bool AutoSize { get; set; }

		/// <summary>
		/// Gets or sets how the control will resize itself.
		/// </summary>
		/// 
		/// <returns>
		/// A value from the <see cref="T:System.Windows.Forms.AutoSizeMode"/> enumeration. The default is <see cref="F:System.Windows.Forms.AutoSizeMode.GrowOnly"/>.
		/// </returns>
		[Browsable(true)]
		[Localizable(true)]
		[DefaultValue(AutoSizeMode.GrowOnly)]
		public AutoSizeMode AutoSizeMode { get; set; }

		/// <summary>
		/// Gets or sets how the control performs validation when the user changes focus to another control.
		/// </summary>
		/// 
		/// <returns>
		/// A member of the <see cref="T:System.Windows.Forms.AutoValidate"/> enumeration. The default value for <see cref="T:System.Windows.Forms.UserControl"/> is <see cref="F:System.Windows.Forms.AutoValidate.EnablePreventFocusChange"/>.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override AutoValidate AutoValidate { get; set; }

		/// <summary>
		/// Gets or sets the border style of the user control.
		/// </summary>
		/// 
		/// <returns>
		/// One of the <see cref="T:System.Windows.Forms.BorderStyle"/> values. The default is <see cref="F:System.Windows.Forms.BorderStyle.Fixed3D"/>.
		/// </returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.BorderStyle"/> values. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
		[DefaultValue(BorderStyle.None)]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public BorderStyle BorderStyle { [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		get; set; }

		/// <returns>
		/// A <see cref="T:System.Windows.Forms.CreateParams"/> that contains the required creation parameters when the handle to the control is created.
		/// </returns>
		protected override CreateParams CreateParams { [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get; }

		/// <returns>
		/// The default <see cref="T:System.Drawing.Size"/> of the control.
		/// </returns>
		protected override Size DefaultSize { get; }

		/// <returns>
		/// The text associated with this control.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Bindable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public override string Text { get; set; }

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.UserControl.AutoSize"/> property changes.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		public new event EventHandler AutoSizeChanged;

		/// <summary>
		/// Occurs when the <see cref="P:System.Windows.Forms.UserControl.AutoValidate"/> property changes.
		/// </summary>
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public new event EventHandler AutoValidateChanged;

		/// <summary>
		/// Occurs before the control becomes visible for the first time.
		/// </summary>
		/// <filterpriority>1</filterpriority>
		public event EventHandler Load;

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged"/> event.
		/// </summary>
		/// <filterpriority>1</filterpriority>
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new event EventHandler TextChanged;
	}
}
