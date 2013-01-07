using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EmailPingPong.Core.Model;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class CommentViewModel : TreeViewItemViewModel
	{
		private readonly Comment _comment;
		private readonly ReadOnlyCollection<CommentViewModel> _answers;

		public CommentViewModel(TreeViewItemViewModel parent,
								Comment comment)
			: base(parent)
		{
			_comment = comment;
			_answers = new ReadOnlyCollection<CommentViewModel>(comment
																	.Answers
																	.Select(a => new CommentViewModel(this, a))
																	.ToList());
		}

		public override IEnumerable<TreeViewItemViewModel> Childs
		{
			get
			{
				return _answers;
			}
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

		public ReadOnlyCollection<CommentViewModel> Answers
		{
			get { return _answers; }
		}
	}
}