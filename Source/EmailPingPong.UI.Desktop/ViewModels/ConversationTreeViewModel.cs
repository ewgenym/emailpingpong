using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Utils;
using EmailPingPong.Infrastructure.Events;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationTreeViewModel : ViewModelBase
	{
		private ReadOnlyCollection<TreeViewItemViewModel> _items;
		private GroupBy _groupBy;
		private SearchIn _searchIn;
		private string _accountId;
		private IList<EmailItem> _emails;
		private EmailFolder _folder;
		private readonly IConversationTreeItemsBinder _treeViewItemsBinder;
		private readonly TreeViewItemsState<ConversationViewCriteria> _statePersister;
		private ConversationViewCriteria _latestCriteria;
		private readonly IEventAggregator _eventAggregator;

		public ConversationTreeViewModel(IConversationTreeItemsBinder treeViewItemsBinder,
										 IEventAggregator eventAggregator)
		{
			_treeViewItemsBinder = treeViewItemsBinder;
			_eventAggregator = eventAggregator;
			_statePersister = new TreeViewItemsState<ConversationViewCriteria>();
			OpenMailItem = new DelegateCommand<TreeViewItemViewModel>(OpenMailItemExecute);

			ListenToEvents();
		}

		private void ListenToEvents()
		{
			_eventAggregator.GetEvent<MailFolderSwitchedEvent>().Subscribe(OnMailFolderSwitched, ThreadOption.PublisherThread);
			_eventAggregator.GetEvent<EmailItemSwitchedEvent>().Subscribe(OnEmailItemSwitched, ThreadOption.PublisherThread);
			_eventAggregator.GetEvent<ConversationMergedEvent>().Subscribe(OnConversationAdded, ThreadOption.PublisherThread);
			_eventAggregator.GetEvent<EmailItemChangedEvent>().Subscribe(OnEmailItemChanged, ThreadOption.PublisherThread);
			_eventAggregator.GetEvent<ConversationRemovedEvent>().Subscribe(OnConversationRemoved, ThreadOption.PublisherThread);
		}

		private void OnEmailItemSwitched(EmailItemSwitchedArgs args)
		{
			_accountId = args.AccountId;
			_emails = args.Emails.Return(e => e.ToList());
			if (_searchIn == SearchIn.CurrentEmail)
			{
				BindData();
			}
		}

		private void OnMailFolderSwitched(MailFolderSwitchedArgs args)
		{
			_accountId = args.AccountId;
			_folder = args.Folder;
			BindData();
		}

		private void OnConversationAdded(Conversation args)
		{
			BindData();
		}

		private void OnEmailItemChanged(EmailItemChangedArgs args)
		{
			BindData();
		}

		private void OnConversationRemoved(ConversationRemovedArgs args)
		{
			BindData();
		}

		public ICommand OpenMailItem { get; private set; }

		private void OpenMailItemExecute(TreeViewItemViewModel itemViewModel)
		{
			if (itemViewModel == null)
			{
				return;
			}

			var emailItem = GetEmailItem((dynamic) itemViewModel);
			if (emailItem != null)
			{
				_eventAggregator.GetEvent<OpenMailItemEvent>().Publish(new OpenMailItemArgs(emailItem));
			}
		}

		private EmailItem GetEmailItem(CommentViewModel commentViewModel)
		{
			var comment = commentViewModel.Comment;
			while (comment.Conversation == null)
			{
				comment = comment.Parent;
				if (comment == null)
				{
					break;
				}
			}

			return comment.With(c => c.Conversation).Return(c => c.LatestEmail);
		}

		private EmailItem GetEmailItem(ConversationViewModel conversationViewModel)
		{
			return conversationViewModel.Conversation.LatestEmail;
		}

		private EmailItem GetEmailItem(FolderViewModel folderViewModel)
		{
			return null;
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
			return new ConversationViewCriteria(_groupBy, _searchIn, _accountId, _emails, _folder, false);
		}

		public ReadOnlyCollection<TreeViewItemViewModel> Items
		{
			get { return _items; }
			private set
			{
				_items = value;
				OnPropertyChanged("Items");
			}
		}
	}
}