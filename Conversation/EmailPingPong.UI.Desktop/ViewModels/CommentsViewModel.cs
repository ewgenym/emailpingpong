using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using DevExpress.Xpf.Grid;
using EmailPingPong.Core.Domain;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Infrastructure.Repositories;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class CommentsViewModel : NotificationObject
	{
		private readonly ICommentRepository _commentRepository;
		private readonly IEventAggregator _eventAggregator;

		public CommentsViewModel()
		{
			if (ServiceLocator.Container != null)
			{
				_commentRepository = ServiceLocator.Container.Resolve<ICommentRepository>();
				//TODO: piece of ugly workaround
				Comments = new List<Comment>(_commentRepository.Comments);

				_searchIn = SearchIn.CurrentFolder;

				_eventAggregator = ServiceLocator.Container.Resolve<IEventAggregator>();
				_eventAggregator.GetEvent<MailFolderSwitchEvent>().Subscribe(OnItemFolderChanged, ThreadOption.PublisherThread);
				_eventAggregator.GetEvent<MailItemAddedEvent>().Subscribe(OnItemAdded, ThreadOption.PublisherThread);
				_eventAggregator.GetEvent<MailItemSwitchEvent>().Subscribe(OnItemSwitched, ThreadOption.PublisherThread);

				ItemSelectedCommand =
					new DelegateCommand<TreeListNode>(
						node =>
							{
								var comment = (Comment) node.Content;
								var item = new PingPongMailItem
								           	{
								           		FolderId = comment.FolderId,
												ItemId = comment.ItemId,
												StoreId = comment.StoreId,
								           	};
								_eventAggregator.GetEvent<PingPongItemSelectedEvent>().Publish(item);
							}
						);
			}
		}

		private void BindComments()
		{
			Comments = new List<Comment>(GetComments());
		}

		private void OnItemAdded(PingPongMailItem obj)
		{
			BindComments();
		}

		private void OnItemSwitched(IEnumerable<PingPongMailItem> items)
		{
			_itemIds = new List<string>(items.Select(i => i.ItemId));
			if (_searchIn == SearchIn.CurrentEmail)
			{
				BindComments();
			}
		}

		public void OnItemFolderChanged(string folder)
		{
			_folderId = folder;
			if (_searchIn == SearchIn.CurrentFolder)
			{
				BindComments();
			}
		}

		private IList<Comment> _comments;
		public IList<Comment> Comments 
		{ 
			get { return _comments; }
			private set 
			{ 
				_comments = value;
				RaisePropertyChanged(() => Comments);
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
					_searchIn = value;
					BindComments();
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
					_groupBy = value;
					BindComments();
				}
			}
		}
		
		private List<string> _itemIds = new List<string>();
		private string _folderId;
		
		private GroupBy _groupBy = GroupBy.None;
		
		private IEnumerable<Comment> GetComments()
		{
			IEnumerable<Comment> comments = null;
			
			switch (_searchIn)
			{
				case SearchIn.CurrentEmail:
					comments = _commentRepository.Comments.Where(c => _itemIds.Contains(c.ItemId)).OrderBy(c => c.Order);
					break;
				case SearchIn.CurrentFolder:
					if (!string.IsNullOrEmpty(_folderId))
						comments = _commentRepository.Comments.Where(c => c.FolderId == _folderId).OrderBy(c => c.Order);
					break;
				default:
					comments = _commentRepository.Comments;
					break;
			}

			switch (_groupBy)
			{
				case GroupBy.EmailSuject:
					break;
			}

			return comments;
		}

		public void CommentsChanged()
		{
			RaisePropertyChanged(() => Comments);
		}
	}
}