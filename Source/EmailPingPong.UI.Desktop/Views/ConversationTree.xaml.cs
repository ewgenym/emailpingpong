using System.Windows;
using System.Windows.Input;
using EmailPingPong.Infrastructure;
using EmailPingPong.UI.Desktop.ViewModels;

namespace EmailPingPong.UI.Desktop.Views
{
	/// <summary>
	/// Interaction logic for ConversationTree.xaml
	/// </summary>
	public partial class ConversationTree
	{
		private readonly ConversationTreeViewModel _viewModel;
		public ConversationTree()
		{
			InitializeComponent();
			
			_viewModel = ServiceLocator.Container.Resolve<ConversationTreeViewModel>();
			DataContext = _viewModel;
		}

		private void TreeView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount > 1)
			{
				var clickPoint = e.GetPosition(conversationTree);
				var node = conversationTree.InputHitTest(clickPoint) as FrameworkElement;
				if (node != null)
				{
					var viewModel = node.DataContext as TreeViewItemViewModel;
					_viewModel.OpenMailItem.Execute(viewModel);
					e.Handled = true;
				}
			}
		}
	}
}
