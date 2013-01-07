using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class TreeViewItemsIterator : IEnumerator<TreeViewItemViewModel>, IEnumerable<TreeViewItemViewModel>
	{
		private readonly TreeViewItemViewModel _startNode;
		private readonly IEnumerable<TreeViewItemViewModel> _startNodes;
		private readonly Stack<TreeViewItemViewModel> _stack = new Stack<TreeViewItemViewModel>();
		private TreeViewItemViewModel _current;

		public TreeViewItemViewModel Current
		{
			get
			{
				return _current;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}

		public TreeViewItemsIterator(TreeViewItemViewModel startNode)
		{
			_startNode = startNode;
		}

		public TreeViewItemsIterator(IEnumerable<TreeViewItemViewModel> startNodes)
		{
			_startNodes = startNodes;
		}

		public bool MoveNext()
		{
			if (_current == null)
			{
				_current = _startNode;
				if (_current == null && _startNodes != null)
				{
					TraverseChildNodes(_startNodes);
					UpdateCurrent();
				}
			}
			else
			{
				TraverseChildNodes(_current.Childs);
				UpdateCurrent();
			}
			return _current != null;
		}

		public void Reset()
		{
			_stack.Clear();
			_current = null;
		}

		private void TraverseChildNodes(IEnumerable<TreeViewItemViewModel> nodes)
		{
			var itemViewModels = nodes as TreeViewItemViewModel[] ?? nodes.ToArray();
			var count = itemViewModels.Count();
			for (var i = 0; i < count; i++)
			{
				var item = itemViewModels[count - 1 - i];
				_stack.Push(item);
			}
		}
		private void UpdateCurrent()
		{
			_current = ((_stack.Count > 0) ? _stack.Pop() : null);
		}
		void IDisposable.Dispose()
		{
			Reset();
		}

		IEnumerator<TreeViewItemViewModel> IEnumerable<TreeViewItemViewModel>.GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}
	}
}
