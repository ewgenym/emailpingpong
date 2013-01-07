using System.Collections.Generic;

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
			_itemsState[key] = GetState(items);
		}

		private IDictionary<TreeViewItemViewModel, ItemState> GetState(IEnumerable<TreeViewItemViewModel> items)
		{
			var result = new Dictionary<TreeViewItemViewModel, ItemState>();
			foreach (var item in new TreeViewItemsIterator(items))
			{
				result.Add(item, new ItemState
					{
						IsExpanded = item.IsExpanded,
						IsSelected = item.IsSelected
					});
			}
			return result;
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
				var state = itemsState[item];
				item.IsExpanded = state.IsExpanded;
				item.IsSelected = state.IsSelected;
			}
		}
	}
}