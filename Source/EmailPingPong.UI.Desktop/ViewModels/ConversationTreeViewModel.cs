using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Infrastructure.Events;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationTreeViewModel : ViewModelBase
	{
		private readonly IConversationRepository _conversationRepository;
		private ReadOnlyCollection<TreeViewItemViewModel> _items;
		private GroupBy _groupBy;
		private SearchIn _searchIn;
		private string _accountId;
		private IEnumerable<EmailItem> _emails;
		private IEnumerable<EmailFolder> _folders;
		private readonly IConversationTreeItemsBinder _treeViewItemsBinder;

		public ConversationTreeViewModel(IConversationRepository conversationRepository, IEventAggregator eventAggregator, IConversationTreeItemsBinder treeViewItemsBinder)
		{
			_conversationRepository = conversationRepository;
			_treeViewItemsBinder = treeViewItemsBinder;

			eventAggregator.GetEvent<MailFolderSwitchedEvent>().Subscribe(OnMailFolderSwitched, ThreadOption.PublisherThread);
			eventAggregator.GetEvent<EmailItemSwitchedEvent>().Subscribe(OnEmailItemSwitched, ThreadOption.PublisherThread);
		}

		private void OnEmailItemSwitched(EmailItemSwitchedArgs args)
		{
			_accountId = args.AccountId;
			_emails = args.Emails;
			BindData();
		}

		private void OnMailFolderSwitched(MailFolderSwitchedArgs args)
		{
			_accountId = args.AccountId;
			_folders = args.Folders;
			BindData();
		}

		public GroupBy GroupBy
		{
			get { return _groupBy; }
			set
			{
				if (_groupBy != value)
				{
					_groupBy = value;
					BindData();
				}
			}
		}

		public SearchIn SearchIn
		{
			get { return _searchIn; }
			set
			{
				if (_searchIn != value)
				{
					_searchIn = value;
					BindData();
				}
			}
		}

		private async void BindData()
		{
			var treeViewItems = await _treeViewItemsBinder.BindTreeViewItems(_groupBy, _searchIn, _accountId, _folders, _emails);
			Items = new ReadOnlyCollection<TreeViewItemViewModel>(treeViewItems);
		}


		public ReadOnlyCollection<TreeViewItemViewModel> Items
		{
			get { return _items; }
			set
			{
				_items = value;
				OnPropertyChanged("Items");
			}
		}
	}
}