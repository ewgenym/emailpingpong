// Type: System.Windows.Forms.KeyEventArgs
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
	/// <summary>
	/// Provides data for the <see cref="E:System.Windows.Forms.Control.KeyDown"/> or <see cref="E:System.Windows.Forms.Control.KeyUp"/> event.
	/// </summary>
	/// <filterpriority>2</filterpriority>
	[ComVisible(true)]
	public class KeyEventArgs : EventArgs
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Forms.KeyEventArgs"/> class.
		/// </summary>
		/// <param name="keyData">A <see cref="T:System.Windows.Forms.Keys"/> representing the key that was pressed, combined with any modifier flags that indicate which CTRL, SHIFT, and ALT keys were pressed at the same time. Possible values are obtained be applying the bitwise OR (|) operator to constants from the <see cref="T:System.Windows.Forms.Keys"/> enumeration. </param>
		public KeyEventArgs(Keys keyData);

		/// <summary>
		/// Gets a value indicating whether the ALT key was pressed.
		/// </summary>
		/// 
		/// <returns>
		/// true if the ALT key was pressed; otherwise, false.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public virtual bool Alt { get; }

		/// <summary>
		/// Gets a value indicating whether the CTRL key was pressed.
		/// </summary>
		/// 
		/// <returns>
		/// true if the CTRL key was pressed; otherwise, false.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public bool Control { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the event was handled.
		/// </summary>
		/// 
		/// <returns>
		/// true to bypass the control's default handling; otherwise, false to also pass the event along to the default control handler.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public bool Handled { get; set; }

		/// <summary>
		/// Gets the keyboard code for a <see cref="E:System.Windows.Forms.Control.KeyDown"/> or <see cref="E:System.Windows.Forms.Control.KeyUp"/> event.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Forms.Keys"/> value that is the key code for the event.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public Keys KeyCode { get; }

		/// <summary>
		/// Gets the keyboard value for a <see cref="E:System.Windows.Forms.Control.KeyDown"/> or <see cref="E:System.Windows.Forms.Control.KeyUp"/> event.
		/// </summary>
		/// 
		/// <returns>
		/// The integer representation of the <see cref="P:System.Windows.Forms.KeyEventArgs.KeyCode"/> property.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int KeyValue { get; }

		/// <summary>
		/// Gets the key data for a <see cref="E:System.Windows.Forms.Control.KeyDown"/> or <see cref="E:System.Windows.Forms.Control.KeyUp"/> event.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Forms.Keys"/> representing the key code for the key that was pressed, combined with modifier flags that indicate which combination of CTRL, SHIFT, and ALT keys was pressed at the same time.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public Keys KeyData { get; }

		/// <summary>
		/// Gets the modifier flags for a <see cref="E:System.Windows.Forms.Control.KeyDown"/> or <see cref="E:System.Windows.Forms.Control.KeyUp"/> event. The flags indicate which combination of CTRL, SHIFT, and ALT keys was pressed.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Forms.Keys"/> value representing one or more modifier flags.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public Keys Modifiers { get; }

		/// <summary>
		/// Gets a value indicating whether the SHIFT key was pressed.
		/// </summary>
		/// 
		/// <returns>
		/// true if the SHIFT key was pressed; otherwise, false.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public virtual bool Shift { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the key event should be passed on to the underlying control.
		/// </summary>
		/// 
		/// <returns>
		/// true if the key event should not be sent to the control; otherwise, false.
		/// </returns>
		public bool SuppressKeyPress { get; set; }
	}
}
