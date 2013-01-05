using System.ComponentModel;
using EmailPingPong.UI.Desktop.Annotations;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class TreeViewItemViewModel : ViewModelBase
	{
		private readonly TreeViewItemViewModel _parent;
		private bool _isExpanded;
		private bool _isSelected;

		public TreeViewItemViewModel(TreeViewItemViewModel parent)
		{
			_parent = parent;
		}

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
	}
}