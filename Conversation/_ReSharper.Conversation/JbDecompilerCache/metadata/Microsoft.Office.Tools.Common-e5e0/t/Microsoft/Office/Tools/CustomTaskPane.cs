// Type: Microsoft.Office.Tools.CustomTaskPane
// Assembly: Microsoft.Office.Tools.Common, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Program Files\Reference Assemblies\Microsoft\VSTO40\v4.0.Framework\Microsoft.Office.Tools.Common.dll

using Microsoft.Office.Core;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Microsoft.Office.Tools
{
	/// <summary>
	/// Represents a custom task pane in a Microsoft Office application.
	/// </summary>
	[Guid("881b42fd-484d-4494-8500-779de4e4aac1")]
	[ComImport]
	public interface CustomTaskPane : IDisposable
	{
		/// <summary>
		/// Gets the <see cref="T:System.Windows.Forms.UserControl"/> that provides the user interface of the custom task pane.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Windows.Forms.UserControl"/> that provides the user interface of the custom task pane.
		/// </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception>
		UserControl Control { get; }

		/// <summary>
		/// Gets the title of the custom task pane.
		/// </summary>
		/// 
		/// <returns>
		/// The title of the custom task pane.
		/// </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception>
		string Title { get; }

		/// <summary>
		/// Gets the document window that the custom task pane is associated with.
		/// </summary>
		/// 
		/// <returns>
		/// An object that represents the document window that the custom task pane is associated with.
		/// </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception>
		object Window { get; }

		/// <summary>
		/// Gets or sets a value that specifies where the custom task pane is located relative to the application window.
		/// </summary>
		/// 
		/// <returns>
		/// One of the Microsoft.Office.Core.MsoCTPDockPosition values. The default is Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight.
		/// </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception><exception cref="T:System.Runtime.InteropServices.COMException">The value of the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.DockPositionRestrict"/> property is Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRestrictNoChange when you try to change the value of the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.DockPosition"/> property.-or-You try to set this property in the event handler for the <see cref="E:Microsoft.Office.Tools.CustomTaskPane.DockPositionChanged"/> or <see cref="E:Microsoft.Office.Tools.CustomTaskPane.VisibleChanged"/> event.</exception>
		MsoCTPDockPosition DockPosition { get; set; }

		/// <summary>
		/// Gets or sets a value that prevents the custom task pane from being docked in the specified position.
		/// </summary>
		/// 
		/// <returns>
		/// One of the Microsoft.Office.Core.MsoCTPDockPositionRestrict values. The default is Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRestrictNone.
		/// </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception>
		MsoCTPDockPositionRestrict DockPositionRestrict { get; set; }

		/// <summary>
		/// Gets or sets the width of the custom task pane, in points.
		/// </summary>
		/// 
		/// <returns>
		/// The width of the custom task pane, in points.
		/// </returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The value of the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.DockPosition"/> property is Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionTop or Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionBottom when you try to set the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.Width"/> property.-or-You try to set the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.Width"/> property in the event handler for the <see cref="E:Microsoft.Office.Tools.CustomTaskPane.DockPositionChanged"/> or <see cref="E:Microsoft.Office.Tools.CustomTaskPane.VisibleChanged"/> event.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception>
		int Width { get; set; }

		/// <summary>
		/// Gets or sets the height of the custom task pane, in points.
		/// </summary>
		/// 
		/// <returns>
		/// The height of the custom task pane, in points.
		/// </returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The value of the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.DockPosition"/> property is Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight or Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft when you try to set the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.Height"/> property.-or-You try to set the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.Height"/> property in the event handler for the <see cref="E:Microsoft.Office.Tools.CustomTaskPane.DockPositionChanged"/> or <see cref="E:Microsoft.Office.Tools.CustomTaskPane.VisibleChanged"/> event.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception>
		int Height { get; set; }

		/// <summary>
		/// Gets or sets a value that specifies whether the custom task pane is visible.
		/// </summary>
		/// 
		/// <returns>
		/// true if the custom task pane is visible; otherwise, false. The default is false.
		/// </returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">You try to set this property in the event handler for the <see cref="E:Microsoft.Office.Tools.CustomTaskPane.DockPositionChanged"/> or <see cref="E:Microsoft.Office.Tools.CustomTaskPane.VisibleChanged"/> event.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPane.Dispose"/> method of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> has already been called.</exception>
		bool Visible { get; set; }

		/// <summary>
		/// Occurs when the user displays or closes the custom task pane, or when code changes the value of the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.Visible"/> property.
		/// </summary>
		event EventHandler VisibleChanged;

		/// <summary>
		/// Occurs when the user changes the dock position of the custom task pane, or when code changes the value of the <see cref="P:Microsoft.Office.Tools.CustomTaskPane.DockPosition"/> property.
		/// </summary>
		event EventHandler DockPositionChanged;
	}
}
