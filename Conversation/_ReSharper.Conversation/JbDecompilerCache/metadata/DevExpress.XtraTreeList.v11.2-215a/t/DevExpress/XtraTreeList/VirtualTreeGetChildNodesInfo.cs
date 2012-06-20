// Type: DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo
// Assembly: DevExpress.XtraTreeList.v11.2, Version=11.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a
// Assembly location: C:\Program Files (x86)\DevExpress 2011.2\Components\Bin\Framework\DevExpress.XtraTreeList.v11.2.dll

using System;
using System.Collections;

namespace DevExpress.XtraTreeList
{
	/// <summary>
	/// 
	/// <para>
	/// Provides data for the <see cref="E:DevExpress.XtraTreeList.TreeList.VirtualTreeGetChildNodes"/> event.
	/// 
	/// </para>
	/// 
	/// </summary>
	public class VirtualTreeGetChildNodesInfo : EventArgs
	{
		/// <summary>
		/// 
		/// <para>
		/// Initializes a new instance of the VirtualTreeGetChildNodesInfo class.
		/// 
		/// </para>
		/// 
		/// </summary>
		/// <param name="node">A business object to be processed. This value is assigned to the <see cref="P:DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo.Node"/> property.
		/// 
		///             </param>
		public VirtualTreeGetChildNodesInfo(object node);

		/// <summary>
		/// 
		/// <para>
		/// Gets or sets the collection of children for the currently processed business object.
		/// 
		/// </para>
		/// 
		/// </summary>
		/// 
		/// <value>
		/// Initially this property is set to a null reference. Use this property to assign a list of children for the currently processed object.
		/// 
		/// </value>
		public IList Children { get; set; }

		/// <summary>
		/// 
		/// <para>
		/// Gets an instance of the business object being currently processed.
		/// 
		/// </para>
		/// 
		/// </summary>
		/// 
		/// <value>
		/// An object being currently processed.
		/// 
		/// </value>
		public object Node { get; }
	}
}
