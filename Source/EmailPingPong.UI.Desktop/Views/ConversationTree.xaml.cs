using System.Windows;
using System.Windows.Input;
using EmailPingPong.Infrastructure;
using EmailPingPong.UI.Desktop.ViewModels;

namespace EmailPingPong.UI.Desktop.Views
{
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

		private void CloseConversationMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
			var viewModel = ((FrameworkElement)sender).DataContext;
			var itemViewModel = viewModel as TreeViewItemViewModel;
			if (itemViewModel != null)
			{
				_viewModel.CloseConversation.Execute(itemViewModel);
				itemViewModel.IsClosed = true;
			}
		}

		private void ReopenConversationMenuItem_OnClick(object sender, RoutedEventArgs e)
		{
			var viewModel = ((FrameworkElement)sender).DataContext;
			var itemViewModel = viewModel as TreeViewItemViewModel;
			if (itemViewModel != null)
			{
				_viewModel.ReopenConversation.Execute(itemViewModel);
				itemViewModel.IsClosed = false;
			}
		}
	}
}
