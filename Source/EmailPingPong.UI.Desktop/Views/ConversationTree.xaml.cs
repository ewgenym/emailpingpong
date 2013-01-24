using System.Windows.Controls;
using EmailPingPong.Infrastructure;
using EmailPingPong.UI.Desktop.ViewModels;

namespace EmailPingPong.UI.Desktop.Views
{
	/// <summary>
	/// Interaction logic for ConversationTree.xaml
	/// </summary>
	public partial class ConversationTree : UserControl
	{
		public ConversationTree()
		{
			InitializeComponent();

			DataContext = ServiceLocator.Container.Resolve<ConversationTreeViewModel>();
		}
	}
}
