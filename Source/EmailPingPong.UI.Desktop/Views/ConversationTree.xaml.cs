using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Repositories;
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

			//var simple = new SimpleConnectionStringProvider();
			//var conversationContext = new ConversationContext(simple);
			//var repository = new ConversationRepository(conversationContext);
			//var viewModel = new ConversationTreeViewModel(repository);
			DataContext = ServiceLocator.Container.Resolve<ConversationTreeViewModel>();
		}
	}
}
