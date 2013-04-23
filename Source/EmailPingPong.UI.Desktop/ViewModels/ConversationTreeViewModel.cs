using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EmailPingPong.Core.Commands;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Utils;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.UI.Desktop.Annotations;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using ICommand = System.Windows.Input.ICommand;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationTreeViewModel : ViewModelBase
	{
		private readonly ICommandDispatcher _commands;
		private ReadOnlyCollection<TreeViewItemViewModel> _items;
		private GroupBy _groupBy;
		private SearchIn _searchIn;
		private bool _showClosedConversations;
		private string _accountId;
		private IList<EmailItem> _emails;
		private EmailFolder _folder;
		private readonly IConversationTreeItemsBinder _treeViewItemsBinder;
		private readonly TreeViewItemsState<ConversationViewCriteria> _statePersister;
		private ConversationViewCriteria _latestCriteria;
		private readonly IEventAggregator _eventAggregator;

		public ConversationTreeViewModel(IConversationTreeItemsBinder treeViewItemsBinder,
										 IEventAggregator eventAggregator,
										 ICommandDispatcher commands)
		{
			_treeViewItemsBinder = treeViewItemsBinder;
			_eventAggregator = eventAggregator;
			_commands = commands;
			_statePersister = new TreeViewItemsState<ConversationViewCriteria>();
			OpenMailItem = new DelegateCommand<TreeViewItemViewModel>(OpenMailItemExecute);
			CloseConversation = new DelegateCommand<TreeViewItemViewModel>(CloseConversationExecute);
			ReopenConversation = new DelegateCommand<TreeViewItemViewModel>(ReopenConversationExecute);

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

			_emails = args.Emails != null ? args.Emails.ToList() : null;
			
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
		public ICommand CloseConversation { get; private set; }
		public ICommand ReopenConversation { get; private set; }

		private void OpenMailItemExecute(TreeViewItemViewModel itemViewModel)
		{
			if (itemViewModel == null)
			{
				return;
			}

			var emailItem = GetEmailItem((dynamic)itemViewModel);
			if (emailItem != null)
			{
				_eventAggregator.GetEvent<OpenMailItemEvent>().Publish(new OpenMailItemArgs(emailItem));
			}
		}

		private void CloseConversationExecute([NotNull] TreeViewItemViewModel itemViewModel)
		{
			if (itemViewModel == null) throw new ArgumentNullException("itemViewModel");

			var conversation = GetConversation((dynamic)itemViewModel);
			if (conversation != null)
			{
				_commands.Dispatch(new CloseConversation(conversation));
				if (!ShowClosedConversations)
				{
					new Timer(_ => BindData(), null, 2000, Timeout.Infinite);
				}
			}
		}

		private void ReopenConversationExecute([NotNull] TreeViewItemViewModel itemViewModel)
		{
			if (itemViewModel == null) throw new ArgumentNullException("itemViewModel");

			var conversation = GetConversation((dynamic)itemViewModel);
			if (conversation != null)
			{
				_commands.Dispatch(new ReopenConversation(conversation));
			}
		}

		private EmailItem GetEmailItem(CommentViewModel commentViewModel)
		{
			return GetConversation(commentViewModel).Return(c => c.LatestEmail);
		}

		private EmailItem GetEmailItem(ConversationViewModel conversationViewModel)
		{
			return GetConversation(conversationViewModel).LatestEmail;
		}

		private EmailItem GetEmailItem(FolderViewModel folderViewModel)
		{
			return null;
		}

		private Conversation GetConversation(CommentViewModel commentViewModel)
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

			return comment.Return(c => c.Conversation);
		}

		private Conversation GetConversation(ConversationViewModel conversationViewModel)
		{
			return conversationViewModel.Conversation;
		}

		private Conversation GetConversation(FolderViewModel folderViewModel)
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

		public bool ShowClosedConversations
		{
			get { return _showClosedConversations; }
			set
			{
				if (_showClosedConversations != value)
				{
					_showClosedConversations = value;
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
			return new ConversationViewCriteria(_groupBy, _searchIn, _accountId, _emails, _folder, _showClosedConversations);
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