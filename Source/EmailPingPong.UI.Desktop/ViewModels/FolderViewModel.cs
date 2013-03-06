using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EmailPingPong.Core.Model;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class FolderViewModel : TreeViewItemViewModel
	{
		private readonly EmailFolder _folder;
		private readonly IEnumerable<Conversation> _conversations;
		private readonly ReadOnlyCollection<ConversationViewModel> _conversationViews;

		public FolderViewModel(TreeViewItemViewModel parent, EmailFolder folder, IEnumerable<Conversation> conversations) 
			: base(parent)
		{
			_folder = folder;
			_conversations = conversations.ToList();
			_conversationViews = new ReadOnlyCollection<ConversationViewModel>(_conversations.Select(c => new ConversationViewModel(this, c)).ToList());
			IsUnread = _conversations.SelectMany(c => c.Emails).Any(e => e.IsUnread);
		}

		public override IEnumerable<TreeViewItemViewModel> Childs
		{
			get
			{
				return _conversationViews;
			}
		}

		public EmailFolder Folder
		{
			get { return _folder; }
		}

		public string FolderName
		{
			get { return _folder.FolderName; }
		}

		public ReadOnlyCollection<ConversationViewModel> Conversations 
		{
			get { return _conversationViews; }
		}

		public override int GetHashCode()
		{
			return _folder.GetHashCode();
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

			return Folder == (other as FolderViewModel).Folder;
		}
	}
}