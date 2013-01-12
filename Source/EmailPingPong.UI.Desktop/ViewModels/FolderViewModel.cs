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
			_comments = new ReadOnlyCollection<CommentViewModel>(conversation.Comments.Select(c => new CommentViewModel(this, c)).ToList());
			IsUnread = conversation.Emails.Any(e => e.IsUnread);
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

		public Conversation Conversation
		{
			get { return _conversation; }
		}

		public override int GetHashCode()
		{
			return _conversation.GetHashCode();
		}

		public override bool Equals(object other)
		{
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			if ((other == null) || !(other is FolderViewModel))
			{
				return false;
			}

			var thisType = GetType();
			var otherType = other.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			return Conversation == (other as FolderViewModel).Conversation;
		}
	}
}