using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.TreeList;
using EmailPingPong.Core.Domain;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Infrastructure.Repositories;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class CommentsViewModel : NotificationObject, INotifyPropertyChanging
	{
		private readonly ICommentRepository _commentRepository;
		private readonly IEventAggregator _eventAggregator;

		public CommentsViewModel()
		{
			if (ServiceLocator.Container != null)
			{
				_commentRepository = ServiceLocator.Container.Resolve<ICommentRepository>();
				_searchIn = SearchIn.CurrentFolder;
				_eventAggregator = ServiceLocator.Container.Resolve<IEventAggregator>();

				_eventAggregator.GetEvent<MailFolderSwitchEvent>().Subscribe(OnItemFolderChanged, ThreadOption.PublisherThread);
				_eventAggregator.GetEvent<MailItemAddedEvent>().Subscribe(OnItemAdded, ThreadOption.PublisherThread);
				_eventAggregator.GetEvent<MailItemSwitchEvent>().Subscribe(OnItemSwitched, ThreadOption.PublisherThread);

				ItemSelectedCommand =
					new DelegateCommand<TreeListNode>(
						node =>
							{
								var dto = (PingPongDto) node.Content;
								var item = new PingPongMailItem
								           	{
												FolderId = dto.FolderId,
												ItemId = dto.ItemId,
												StoreId = dto.StoreId,
								           	};
								_eventAggregator.GetEvent<PingPongItemSelectedEvent>().Publish(item);
							}
						);
			}
		}

		//TODO: these events are piece of shit. Learn MVVM pattern!
		public event EventHandler<StateEventArgs> OnSaveState;

		private void RaiseOnSaveState(string key)
		{
			if (key == null) return;
			
			if (OnSaveState != null)
				OnSaveState(this, new StateEventArgs(key));
		}

		public event EventHandler<StateEventArgs> OnRestoreState;

		private void RaiseOnRestoreState(string key)
		{
			if (key == null) return;

			if (OnRestoreState != null)
			{
				OnRestoreState(this, new StateEventArgs(key));
			}
		}

		private void OnItemAdded(PingPongMailItem obj)
		{
			var key = CalculateLayoutKey();
			RaiseOnSaveState(key);
			BindEmailPingPong();
		}

		private void OnItemSwitched(IEnumerable<PingPongMailItem> items)
		{
			var key = CalculateLayoutKey();
			_itemIds = new List<string>(items.Select(i => i.ItemId));
			if (_searchIn == SearchIn.CurrentEmail)
			{
				RaiseOnSaveState(key);
				BindEmailPingPong();
			}
		}

		public void OnItemFolderChanged(string folder)
		{
			var key = CalculateLayoutKey();
			_folderId = folder;
			if (_searchIn == SearchIn.CurrentFolder)
			{
				RaiseOnSaveState(key);
				BindEmailPingPong();
			}
		}

		private IList<PingPongDto> _emailPingPong;
		public IList<PingPongDto> EmailPingPong 
		{
			get { return _emailPingPong; }
			private set 
			{
				RaisePropertyChanging(() => EmailPingPong);
				_emailPingPong = value;
				RaisePropertyChanged(() => EmailPingPong);
			}
		}

		public ICommand ItemSelectedCommand { get; set; }

		private SearchIn _searchIn;
		public SearchIn SearchIn
		{
			get { return _searchIn; }
			set
			{
				if (_searchIn != value)
				{
					var key = CalculateLayoutKey();
					RaiseOnSaveState(key);
					_searchIn = value;
					BindEmailPingPong();
				}
			}
		}

		public GroupBy GroupBy
		{
			get { return _groupBy; }
			set
			{
				if (_groupBy != value)
				{
					var key = CalculateLayoutKey();
					RaiseOnSaveState(key);
					_groupBy = value;
					BindEmailPingPong();
				}
			}
		}

		private string CalculateLayoutKey()
		{
			//var items = _itemIds.Aggregate(string.Empty, (current, itemId) => current + ("_" + itemId));
			return SearchIn + "_" + GroupBy + "_" + _folderId;
		}

		private List<string> _itemIds = new List<string>();

		//TODO: accept list of folders (that actually could include child folders in case of search in == current folder + childs)
		private string _folderId;
		
		private GroupBy _groupBy = GroupBy.None;
		
		private void BindEmailPingPong()
		{
			// TODO: refactor the entire method. This is fucking mess
			// TODO: must be asynch
			// TODO: what about grouping by means of built-in feature of the treeList control

			IEnumerable<Comment> comments = null;
			
			switch (_searchIn)
			{
				case SearchIn.CurrentEmail:
					comments = _commentRepository.Comments
						.Where(c => _itemIds.Contains(c.ItemId))
						.OrderBy(c => c.Order);
					break;
				case SearchIn.CurrentFolder:
					if (!string.IsNullOrEmpty(_folderId))
						comments = _commentRepository.Comments
							.Where(c => c.FolderId == _folderId)
							.OrderBy(c => c.Order);
					break;
				default:
					comments = _commentRepository.Comments;
					break;
			}

			IEnumerable<IGrouping<string, Comment>> commentGroups = null;
			switch (_groupBy)
			{
				case GroupBy.EmailSuject:
					commentGroups = comments.GroupBy(c => c.ItemSubject);
					break;
				case GroupBy.Folder:
					commentGroups = comments.GroupBy(c => c.FolderName);
					break;
			}

			var nodes = new List<PingPongDto>();
			if (commentGroups != null)
			{
				int groupId = -1;
				foreach (var @group in commentGroups)
				{
					var groupDto = new PingPongGroupDto {GroupName = group.Key, Id = groupId};
					nodes.Add(groupDto);
					foreach (var comment in group)
					{
						var pingPongDto = new PingPongDto()
							{
								Author = comment.Author,
								Body = comment.Body,
								Created = comment.Created,
								Id = comment.Id,
								ParentId = comment.ParentId.HasValue ? comment.ParentId.Value : groupId,

								FolderId = comment.FolderId,
								ItemId = comment.ItemId,
								StoreId = comment.StoreId,
							};
						nodes.Add(pingPongDto);
					}

					groupId--;
				}
			}
			else
			{
				nodes.AddRange(comments.Select(comment => new PingPongDto()
					{
						Author = comment.Author,
						Body = comment.Body,
						Created = comment.Created,
						Id = comment.Id,
						ParentId = comment.ParentId,

						FolderId = comment.FolderId,
						ItemId = comment.ItemId,
						StoreId = comment.StoreId,
					}));
			}

			EmailPingPong = nodes;

			RaiseOnRestoreState(CalculateLayoutKey());
		}

		public event PropertyChangingEventHandler PropertyChanging;

		protected virtual void RaisePropertyChanging(string propertyName)
		{
			var handler = this.PropertyChanging;
			if (handler != null)
			{
				handler(this, new PropertyChangingEventArgs(propertyName));
			}
		}

		protected void RaisePropertyChanging<T>(Expression<Func<T>> propertyExpression)
		{
			var propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
			RaisePropertyChanging(propertyName);
		}
	}

	public class ObjectTemplateSelector : DataTemplateSelector
	{
		public DataTemplate PingPongGroupTemplate { get; set; }
		public DataTemplate PingPongTemplate { get; set; }
		
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			var rowData = item as TreeListRowData;
			if (rowData != null)
			{
				if (rowData.Row is PingPongGroupDto)
					return PingPongGroupTemplate;
				if (rowData.Row is PingPongDto)
					return PingPongTemplate;
			}
			return null;			
		}
	}

	public class StateEventArgs : EventArgs
	{
		public StateEventArgs(string key)
		{
			Key = key;
		}

		public string Key { get; private set; }
	}

}