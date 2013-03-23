using System.Collections.Generic;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public abstract class TreeViewItemViewModel : ViewModelBase
	{
		protected readonly TreeViewItemViewModel _parent;
		private bool _isExpanded;
		private bool _isSelected;
		private bool _isUnread;
		protected bool _isClosed;

		protected TreeViewItemViewModel(TreeViewItemViewModel parent)
		{
			_parent = parent;
			_isClosed = false;
		}

		public abstract IEnumerable<TreeViewItemViewModel> Childs { get; }

		public bool IsExpanded
		{
			get { return _isExpanded; }
			set
			{
				if (value != _isExpanded)
				{
					_isExpanded = value;
					OnPropertyChanged("IsExpanded");
				}

				if (_isExpanded && _parent != null)
				{
					_parent.IsExpanded = true;
				}
			}
		}

		public bool IsSelected
		{
			get { return _isSelected; }
			set
			{
				if (value != _isSelected)
				{
					_isSelected = value;
					OnPropertyChanged("IsSelected");
				}
			}
		}

		public bool IsUnread
		{
			get { return _isUnread; }
			set
			{
				if (value != _isUnread)
				{
					_isUnread = value;
					OnPropertyChanged("IsUnread");
				}
			}
		}

		public bool IsClosed
		{
			get { return _isClosed; }
			set
			{
				if (value != _isClosed)
				{
					_isClosed = value;
					if (_parent != null)
					{
						_parent.IsClosed = value;
					}
					foreach (var itemViewModel in Childs)
					{
						itemViewModel.IsClosed = value;
					}
					OnPropertyChanged("IsClosed");
					OnPropertyChanged("IsOpened");
				}
			}
		}

		public bool IsOpened
		{
			get { return !_isClosed; }
		}
	}
}