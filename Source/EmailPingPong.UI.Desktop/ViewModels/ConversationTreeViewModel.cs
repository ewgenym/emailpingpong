using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Infrastructure.Events;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationTreeViewModel : ViewModelBase
	{
		private ReadOnlyCollection<TreeViewItemViewModel> _items;
		private GroupBy _groupBy;
		private SearchIn _searchIn;
		private string _accountId;
		private IEnumerable<EmailItem> _emails;
		private IEnumerable<EmailFolder> _folders;
		private readonly IConversationTreeItemsBinder _treeViewItemsBinder;
		private readonly TreeViewItemsState<ConversationViewCriteria> _statePersister;
		private ConversationViewCriteria _latestCriteria;

		public ConversationTreeViewModel(IConversationTreeItemsBinder treeViewItemsBinder,
										 IEventAggregator eventAggregator)
		{
			_treeViewItemsBinder = treeViewItemsBinder;
			_statePersister = new TreeViewItemsState<ConversationViewCriteria>();

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

		public async Task BindData()
		{
			var currentCriteria = GetViewCriteria();
			_statePersister.SaveState(_latestCriteria ?? currentCriteria, Items);

			var treeViewItems = await _treeViewItemsBinder.BindTreeViewItems(currentCriteria);
			var items = new ReadOnlyCollection<TreeViewItemViewModel>(treeViewItems);

			_statePersister.RestoreState(currentCriteria, items);
			Items = items;

			_latestCriteria = currentCriteria;
		}

		private ConversationViewCriteria GetViewCriteria()
		{
			return new ConversationViewCriteria(_groupBy, _searchIn, _accountId, _emails, _folders);
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