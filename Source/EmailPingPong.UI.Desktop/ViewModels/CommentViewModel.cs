using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EmailPingPong.Core.Comparers;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class CommentViewModel : TreeViewItemViewModel
	{
		private readonly Comment _comment;
		private readonly ReadOnlyCollection<CommentViewModel> _answers;
		private readonly CommentComparer _comparer;

		public CommentViewModel(TreeViewItemViewModel parent,
								Comment comment)
			: base(parent)
		{
			_comment = comment;
			_comparer = new CommentComparer();
			_answers = new ReadOnlyCollection<CommentViewModel>(comment
																	.Answers
																	.Select(a => new CommentViewModel(this, a))
																	.ToList());
			var conversation = _comment.Conversation ?? _comment.Parent.Return(c => c.Conversation);
			_isClosed = conversation.Return(c => c.IsClosed);
			IsUnread = comment.With(c => c.OriginalEmail).Return(e => e.IsUnread);
		}

		public override IEnumerable<TreeViewItemViewModel> Childs
		{
			get { return _answers; }
		}

		public string Author
		{
			get { return _comment.Author; }
		}

		public string Body
		{
			get { return _comment.Body; }
		}

		public DateTime CreatedOn
		{
			get { return _comment.CreatedOn; }
		}

		public bool IsOdd
		{
			get { return _comment.Index % 2 == 0; }
		}

		public ReadOnlyCollection<CommentViewModel> Answers
		{
			get { return _answers; }
		}

		public Comment Comment
		{
			get { return _comment; }
		}

		public override int GetHashCode()
		{
			return _comparer.GetHashCode(_comment);
		}

		public override bool Equals(object other)
		{
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			if ((other == null) || !(other is CommentViewModel))
			{
				return false;
			}

			var thisType = GetType();
			var otherType = other.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			return _comparer.Equals(Comment, (other as CommentViewModel).Comment);
		}
	}
}