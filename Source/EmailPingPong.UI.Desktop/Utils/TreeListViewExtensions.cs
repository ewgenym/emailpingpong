using System.Reflection;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.TreeList;

namespace EmailPingPong.UI.Desktop.Utils
{
	public static class TreeListViewExtensions
	{
		public static TreeListDataProvider GetTreeListDataProvider(this TreeListView treeListView)
		{
			var treeListViewType = treeListView.GetType();
			var propertyInfo = treeListViewType.GetProperty("TreeListDataProvider",
															BindingFlags.GetProperty | BindingFlags.Instance |
															BindingFlags.NonPublic);
			return (TreeListDataProvider)propertyInfo.GetValue(treeListView, null);
		}
	}
}