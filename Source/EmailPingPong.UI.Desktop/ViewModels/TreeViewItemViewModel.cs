using System.Collections.Generic;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public abstract class TreeViewItemViewModel : ViewModelBase
	{
		private readonly TreeViewItemViewModel _parent;
		private bool _isExpanded;
		private bool _isSelected;
		private bool _isUnread;

		protected TreeViewItemViewModel(TreeViewItemViewModel parent)
		{
			_parent = parent;
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
	}
}