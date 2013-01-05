using System.Collections.ObjectModel;
using System.Linq;
using EmailPingPong.Core.Model;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationViewModel : TreeViewItemViewModel
	{
		private readonly Conversation _conversation;
		private readonly ReadOnlyCollection<CommentViewModel> _comments;

		public ConversationViewModel(TreeViewItemViewModel parent, Conversation conversation)
			: base(parent)
		{
			_conversation = conversation;
			_comments =
				new ReadOnlyCollection<CommentViewModel>(conversation.Comments.Select(c => new CommentViewModel(this, c)).ToList());
		}

		public string Topic
		{
			get { return _conversation.Topic; }
		}

		public ReadOnlyCollection<CommentViewModel> Comments
		{
			get { return _comments; }
		}
	}
}