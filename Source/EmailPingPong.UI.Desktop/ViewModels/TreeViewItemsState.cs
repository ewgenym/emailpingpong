using System.Collections.Generic;
using System.Linq;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class TreeViewItemsState<TKey>
	{
		private readonly Dictionary<TKey, IDictionary<TreeViewItemViewModel, ItemState>> _itemsState;

		public TreeViewItemsState()
		{
			_itemsState = new Dictionary<TKey, IDictionary<TreeViewItemViewModel, ItemState>>();
		}

		public void SaveState(TKey key, IEnumerable<TreeViewItemViewModel> items)
		{
			if (_itemsState.ContainsKey(key))
			{
				_itemsState[key] = GetState(items);
			}
			else
			{
				_itemsState.Add(key, GetState(items));
			}
		}

		private IDictionary<TreeViewItemViewModel, ItemState> GetState(IEnumerable<TreeViewItemViewModel> items)
		{
			return new TreeViewItemsIterator(items)
				.ToDictionary(item => item, item => new ItemState
				{
					IsExpanded = item.IsExpanded,
					IsSelected = item.IsSelected
				});
		}

		public void RestoreState(TKey key, IEnumerable<TreeViewItemViewModel> items)
		{
			IDictionary<TreeViewItemViewModel, ItemState> state;
			if (_itemsState.TryGetValue(key, out state))
			{
				SetState(items, state);
			}
		}

		private void SetState(IEnumerable<TreeViewItemViewModel> items,
		                      IDictionary<TreeViewItemViewModel, ItemState> itemsState)
		{
			foreach (var item in new TreeViewItemsIterator(items))
			{
				ItemState state;
				if (itemsState.TryGetValue(item, out state))
				{
					item.IsExpanded = state.IsExpanded;
					item.IsSelected = state.IsSelected;
				}
			}
		}
	}
}