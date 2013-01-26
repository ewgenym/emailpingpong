using System.Collections.Generic;
using EmailPingPong.Core.Commands;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Infrastructure.Repositories;
using EmailPingPong.Outlook.Common.Conversation.Implementation;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Outlook2010.Services
{
	public class Outlook2010ConversationMonitor : ConversationMonitorBase
	{
		private readonly ConversationContext _context;
		private readonly ICommandDispatcher _commands;
		private Dictionary<Folder, Items> _folderItems;
		private readonly IConversationBinder _conversationBinder;
		private readonly IEventAggregator _eventAggregator;
		private Explorer _explorer;

		public Outlook2010ConversationMonitor(ConversationContext context,
											  ICommandDispatcher commands,
											  IConversationBinder conversationBinder,
											  IEventAggregator eventAggregator)
		{
			_context = context;
			_commands = commands;
			_conversationBinder = conversationBinder;
			_eventAggregator = eventAggregator;
		}

		public override void StartWatch()
		{
			_explorer = Globals.ThisAddIn.Application.ActiveExplorer();
			_explorer.FolderSwitch += OnFolderSwitch;
			_explorer.SelectionChange += OnSelectionChange;

			// Synchronization should be done when:
			// TODO:
			// -E-mail was moved from one folder to another
			// -The scope of monitoring is all accounts->all mail folders

			// -New e-mail is received (monitor all the mail folders, including subfolders of course)

			_folderItems = new Dictionary<Folder, Items>();

			foreach (Account account in Globals.ThisAddIn.Application.Session.Accounts)
			{
				var store = account.DeliveryStore;
				if (!store.IsOpen)
				{
					continue;
				}

				var inbox = (Folder)store.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
				EnumerateFoldersHierarchy(inbox, _folderItems);

				// E-mail was created but not sent. It was saved to draft folders instead.
				var draft = (Folder)store.GetDefaultFolder(OlDefaultFolders.olFolderDrafts);
				_folderItems.Add(draft, draft.Items);
				break;
				
			}

			foreach (var folderItem in _folderItems)
			{
				var folder = folderItem.Key;
				var items = folderItem.Value;

				items.ItemAdd += OnMailItemAdded;
				items.ItemChange += OnMailItemChanged;

				//folder.BeforeItemMove += MailItemRemoved;
			}


			// -New e-mail is sent. When there is no connection with server as well. (Two options here: 1) monitor Sent folder 2) monitor Application.ItemSend event)
			//var sent = this.Application.Session.GetDefaultFolder(OlDefaultFolders.olFolderSentMail);
			//_sentItems = sent.Items;
			//_sentItems.ItemAdd += SyncConversation;

			//break;

		}

		private void OnFolderSwitch()
		{
			_eventAggregator.GetEvent<MailFolderSwitchedEvent>().Publish(new MailFolderSwitchedArgs("", null));
		}

		private void OnSelectionChange()
		{
			//throw new System.NotImplementedException();
		}

		private void EnumerateFoldersHierarchy(Folder root, Dictionary<Folder, Items> folderItems)
		{
			if (root.DefaultItemType == OlItemType.olMailItem)
			{
				folderItems.Add(root, root.Items);

				if (root.Folders.Count <= 0)
				{
					return;
				}

				foreach (Folder folder in root.Folders)
				{
					EnumerateFoldersHierarchy(folder, folderItems);
				}
			}
		}

		private void OnMailItemAdded(object item)
		{
			var conversation = _conversationBinder.Bind((MailItem)item);
			if (conversation == null)
			{
				return;
			}

			using (new UnitOfWork(_context))
			{
				_commands.Dispatch(new MergeConversation(conversation));
			}
			_eventAggregator.GetEvent<ConversationMergedEvent>().Publish(conversation);
		}

		private void OnMailItemChanged(object item)
		{
			var mailItem = item as MailItem;
			if (mailItem == null)
			{
				return;
			}

			var conversation = _conversationBinder.Bind(mailItem);
			if (conversation == null)
			{
				return;
			}

			using (new UnitOfWork(_context))
			{
				_commands.Dispatch(new UpdateMailItem(conversation));
			}
			_eventAggregator.GetEvent<EmailItemChangedEvent>().Publish(new EmailItemChangedArgs(conversation.NewestEmail));
		}

		private void MailItemRemoved(object item, MAPIFolder to, ref bool cancel)
		{
			//var mailItem = (MailItem)item;
			//var inspector = mailItem.GetInspector;
			//var document = (Microsoft.Office.Interop.Word.Document)inspector.WordEditor;

			//var questions = ParseQuestions(mailItem, to.StoreID, to.EntryID, document);

			////TODO: move this logic to ConversationSyncService
			////_commentRepository.Delete(questions);
			////_commentRepository.SaveChanges();

			//var ppItem = new PingPongMailItem
			//	{
			//		ItemId = mailItem.EntryID,
			//		StoreId = ((Folder)mailItem.Parent).StoreID,
			//		FolderId = ((Folder)mailItem.Parent).EntryID,
			//	};
			//_bus.GetEvent<MailItemRemovedEvent>().Publish(ppItem);
		}

		private void RemoveConversation()
		{
			//_bus.GetEvent<MailItemRemovedEvent>().Publish(null);
		}

		public override void StopWatch()
		{
			//TODO: release objects from _folderItems
			throw new System.NotImplementedException();
		}
	}
}