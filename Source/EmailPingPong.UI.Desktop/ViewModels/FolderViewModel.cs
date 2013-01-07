using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EmailPingPong.Core.Model;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class FolderViewModel : TreeViewItemViewModel
	{
		private readonly Conversation _conversation;
		private readonly ReadOnlyCollection<CommentViewModel> _comments;

		public FolderViewModel(TreeViewItemViewModel parent, Conversation conversation) : base(parent)
		{
			_conversation = conversation;
			_comments =
				new ReadOnlyCollection<CommentViewModel>(conversation.Comments.Select(c => new CommentViewModel(this, c)).ToList());
		}

		public override IEnumerable<TreeViewItemViewModel> Childs
		{
			get
			{
				return _comments;
			}
		}

		public string Folder
		{
			get { return _conversation.NewestEmail.Folder.FolderName; }
		}

		public ReadOnlyCollection<CommentViewModel> Comments
		{
			get { return _comments; }
		}
	}
}