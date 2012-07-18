using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Controls;
using System.Xml;
using DevExpress.Xpf.Grid.TreeList;
using EmailPingPong.UI.Desktop.Utils;
using EmailPingPong.UI.Desktop.ViewModels;
using TreeListNodesStateRepo = System.Collections.Generic.Dictionary<string, DevExpress.Xpf.Grid.TreeList.TreeListNodesState>;

namespace EmailPingPong.UI.Desktop.Views
{
	/// <summary>
	/// Interaction logic for ConversationTree.xaml
	/// </summary>
	public partial class ConversationTree : UserControl
	{
		private CommentsViewModel ViewModel
		{
			get { return (CommentsViewModel)this.ConversationTreeListView.DataContext; }
		}

		public ConversationTree()
		{
			InitializeComponent();
			this.ConversationTreeListView.DataContextChanged += (_, __) =>
				{
					ViewModel.OnSaveState += (sender, e) => SaveNodesState(e.Key);
					ViewModel.OnRestoreState += (sender, e) => RestoreNodesState(e.Key);
				};
		}

		private readonly Dictionary<string, TreeListNodesState> _treeListNodesStateRepo = new Dictionary<string, TreeListNodesState>();

		private void SaveNodesState(string key)
		{
			//TODO: move to view model
			var nodesState = new TreeListNodesState(ConversationTreeListView.GetTreeListDataProvider());
			nodesState.SaveNodesState();
			nodesState.SaveCurrentFocus();
			_treeListNodesStateRepo[key] = nodesState;
		}

		private void RestoreNodesState(string key)
		{
			//TODO: move to view model
			TreeListNodesState nodesState;
			if (_treeListNodesStateRepo.TryGetValue(key, out nodesState))
			{
				nodesState.RestoreNodesState();
				nodesState.RestoreCurrentFocus();
				SaveNodesState(key);
			}
		}
	}
}