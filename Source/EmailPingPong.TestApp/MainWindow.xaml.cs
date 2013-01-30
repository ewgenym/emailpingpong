using System.Collections.Generic;
using System.Windows;
using EmailPingPong.Core.Model;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Events;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.TestApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			var eventAggregator = ServiceLocator.Container.Resolve<IEventAggregator>();
			eventAggregator.GetEvent<MailFolderSwitchedEvent>()
						   .Publish(new MailFolderSwitchedArgs(AccountId.Text, new EmailFolder("1", FolderId.Text, "Inbox")));
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			var eventAggregator = ServiceLocator.Container.Resolve<IEventAggregator>();
			eventAggregator.GetEvent<EmailItemSwitchedEvent>()
						   .Publish(new EmailItemSwitchedArgs(AccountId.Text, new List<EmailItem>()
				               {
					               new EmailItem
						               {
							               AccountId = AccountId.Text,
							               ItemId = EmailId.Text,
							               Subject = "Some subject"
						               }
				               }));
		}
	}
}