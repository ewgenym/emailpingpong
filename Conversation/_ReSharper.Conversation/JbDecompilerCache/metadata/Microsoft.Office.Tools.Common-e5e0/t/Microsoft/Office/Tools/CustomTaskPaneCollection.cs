// Type: Microsoft.Office.Tools.CustomTaskPaneCollection
// Assembly: Microsoft.Office.Tools.Common, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Program Files\Reference Assemblies\Microsoft\VSTO40\v4.0.Framework\Microsoft.Office.Tools.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Microsoft.Office.Tools
{
	/// <summary>
	/// Represents a collection of custom task panes in a Microsoft Office application.
	/// </summary>
	[Guid("c3a84bf1-e95b-4d23-952d-59e35673958e")]
	[ComImport]
	public interface CustomTaskPaneCollection : IEnumerable<CustomTaskPane>, IEnumerable, IDisposable
	{
		void BeginInit();
		void EndInit();

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> and adds it to the current <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>. The custom task pane is based on the specified <see cref="T:System.Windows.Forms.UserControl"/> and has the specified title.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> that represents the new custom task pane.
		/// </returns>
		/// <param name="control">A <see cref="T:System.Windows.Forms.UserControl"/> that provides the user interface for the new custom task pane.</param><param name="title">The text that appears in the title bar of the new custom task pane.</param><exception cref="T:System.ArgumentNullException"><paramref name="control"/> or <paramref name="title"/> is null.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPaneCollection.Dispose"/> method has already been called on the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.</exception>
		CustomTaskPane Add(UserControl control, string title);

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> and adds it to the current <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>. The custom task pane is based on the specified <see cref="T:System.Windows.Forms.UserControl"/>, has the specified title, and is associated with the specified application window.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> that represents the new custom task pane.
		/// </returns>
		/// <param name="control">A <see cref="T:System.Windows.Forms.UserControl"/> that provides the user interface for the new custom task pane.</param><param name="title">The text that appears in the title bar of the new custom task pane.</param><param name="window">An object that represents the application window to associate the new custom task pane with.</param><exception cref="T:System.ArgumentNullException"><paramref name="control"/> or <paramref name="title"/> is null.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPaneCollection.Dispose"/> method has already been called on the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.</exception>
		CustomTaskPane Add(UserControl control, string title, object window);

		/// <summary>
		/// Removes the specified <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> from the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> was successfully removed from the collection; false if the collection does not contain the specified <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/>.
		/// </returns>
		/// <param name="customTaskPane">The <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> to remove from the collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="customTaskPane"/> is null.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPaneCollection.Dispose"/> method has already been called on the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.</exception>
		bool Remove(CustomTaskPane customTaskPane);

		/// <summary>
		/// Removes the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> at the specified index of the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.
		/// </summary>
		/// <param name="index">The zero-based index of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> to remove.</param><exception cref="T:System.ArgumentOutOfRangeException">The collection does not contain a <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> at <paramref name="index"/>.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPaneCollection.Dispose"/> method has already been called on the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.</exception>
		void RemoveAt(int index);

		/// <summary>
		/// Gets the number of <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> objects in the current <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The number of <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> objects in the current <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.
		/// </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPaneCollection.Dispose"/> method has already been called on the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.</exception>
		int Count { get; }

		/// <summary>
		/// Gets the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> at the specified index.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> at the specified index.
		/// </returns>
		/// <param name="index">The zero-based index of the <see cref="T:Microsoft.Office.Tools.CustomTaskPane"/> to get.</param><exception cref="T:System.ObjectDisposedException">The <see cref="M:Microsoft.Office.Tools.CustomTaskPaneCollection.Dispose"/> method has already been called on the <see cref="T:Microsoft.Office.Tools.CustomTaskPaneCollection"/>.</exception>
		CustomTaskPane this[int index] { get; }
	}
}
