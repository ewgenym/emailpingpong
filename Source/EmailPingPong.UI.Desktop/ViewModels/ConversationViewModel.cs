using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EmailPingPong.Core.Comparers;
using EmailPingPong.Core.Model;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationViewModel : TreeViewItemViewModel
	{
		private readonly Conversation _conversation;
		private readonly ConversationComparer _comparer;
		private readonly ReadOnlyCollection<CommentViewModel> _comments;

		public ConversationViewModel(TreeViewItemViewModel parent, Conversation conversation)
			: base(parent)
		{
			_conversation = conversation;
			_comparer = new ConversationComparer();
			_comments =
				new ReadOnlyCollection<CommentViewModel>(conversation.Comments.Select(c => new CommentViewModel(this, c)).ToList());
			IsUnread = conversation.Emails.Any(e => e.IsUnread);
			_isClosed = _conversation.IsClosed;
		}

		public override IEnumerable<TreeViewItemViewModel> Childs
		{
			get
			{
				return _comments;
			}
		}

		public string Topic
		{
			get { return _conversation.Topic; }
		}

		public ReadOnlyCollection<CommentViewModel> Comments
		{
			get { return _comments; }
		}

		public  Conversation Conversation
		{
			get { return _conversation; }
		}

		public override int GetHashCode()
		{
			return _comparer.GetHashCode(_conversation);
		}

		public override bool Equals(object other)
		{
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			if ((other == null) || !(other is ConversationViewModel))
			{
				return false;
			}

			var thisType = GetType();
			var otherType = other.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			return _comparer.Equals(Conversation, (other as ConversationViewModel).Conversation);
		}
	}
}