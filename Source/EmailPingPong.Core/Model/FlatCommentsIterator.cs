using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EmailPingPong.Core.Model
{
	public class FlatCommentsIterator : IEnumerator<Comment>, IEnumerable<Comment>
	{
		private readonly Comment _startNode;
		private readonly IEnumerable<Comment> _startNodes;
		private readonly Stack<Comment> _stack = new Stack<Comment>();
		private Comment _current;

		public Comment Current
		{
			get { return _current; }
		}

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public FlatCommentsIterator(Comment startNode)
		{
			_startNode = startNode;
		}

		public FlatCommentsIterator(IEnumerable<Comment> startNodes)
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
				TraverseChildNodes(_current.Answers);
				UpdateCurrent();
			}
			return _current != null;
		}

		public void Reset()
		{
			_stack.Clear();
			_current = null;
		}

		private void TraverseChildNodes(IEnumerable<Comment> nodes)
		{
			var itemViewModels = nodes as Comment[] ?? nodes.ToArray();
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

		IEnumerator<Comment> IEnumerable<Comment>.GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}
	}
}