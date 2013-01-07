using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationTreeItemsBinder : IConversationTreeItemsBinder
	{
		private readonly IConversationRepository _conversationRepository;

		public ConversationTreeItemsBinder(IConversationRepository conversationRepository)
		{
			_conversationRepository = conversationRepository;
		}

		public async Task<IList<TreeViewItemViewModel>> BindTreeViewItems(GroupBy groupBy,
																		  SearchIn searchIn,
																		  string accountId, IEnumerable<EmailFolder> folders,
																		  IEnumerable<EmailItem> emails)
		{
			var conversations = await GetConversationsInScope(searchIn, accountId, folders, emails);
			IList<TreeViewItemViewModel> treeViewItems;
			switch (groupBy)
			{
				case GroupBy.Email:
					treeViewItems = BindByEmail(conversations);
					break;
				case GroupBy.Folder:
					treeViewItems = BindByFolder(conversations);
					break;
				default:
					treeViewItems = BindByDefault(conversations);
					break;
			}
			return treeViewItems;
		}

		private IList<TreeViewItemViewModel> BindByFolder(IEnumerable<Conversation> conversations)
		{
			return conversations
				.Select(c => new FolderViewModel(null, c))
				.Cast<TreeViewItemViewModel>()
				.ToList();
		}

		private IList<TreeViewItemViewModel> BindByEmail(IEnumerable<Conversation> conversations)
		{
			return conversations
				.Select(c => new ConversationViewModel(null, c))
				.Cast<TreeViewItemViewModel>()
				.ToList();
		}

		private IList<TreeViewItemViewModel> BindByDefault(IEnumerable<Conversation> conversations)
		{
			var comments = conversations.SelectMany(c => c.Comments);
			return comments.Select(c => new CommentViewModel(null, c))
						   .Cast<TreeViewItemViewModel>()
						   .ToList();
		}

		private Task<List<Conversation>> GetConversationsInScope(SearchIn searchIn, string accountId,
																 IEnumerable<EmailFolder> folders,
																 IEnumerable<EmailItem> emails)
		{
			switch (searchIn)
			{
				case SearchIn.AllFolders:
					return Task.Factory.StartNew(() => _conversationRepository.GetByAccountId(accountId).ToList());
				case SearchIn.CurrentFolder:
					return Task.Factory.StartNew(() => _conversationRepository.GetByAccountIdAndFolders(accountId, folders).ToList());
				case SearchIn.CurrentEmail:
					return Task.Factory.StartNew(() => _conversationRepository.GetByAccountIdAndEmails(accountId, emails).ToList());
				default:
					throw new NotSupportedException(string.Format("Search filter '{0}' is not supported.", searchIn.ToString()));
			}
		}
	}

	public interface IConversationTreeItemsBinder
	{
		Task<IList<TreeViewItemViewModel>> BindTreeViewItems(GroupBy groupBy,
															 SearchIn searchIn, string accountId,
															 IEnumerable<EmailFolder> folders, IEnumerable<EmailItem> emails);
	}
}