using System.Collections.Generic;
using EmailPingPong.Core.Commands;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Outlook.Common.Conversation.Implementation;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Outlook2010.Services
{
	public class Outlook2010ConversationMonitor : ConversationMonitorBase
	{
		private readonly ICommandDispatcher _commands;
		private Dictionary<Folder, Items> _folderItems;
		private readonly IConversationBinder _conversationBinder;
		private readonly IEventAggregator _eventAggregator;

		public Outlook2010ConversationMonitor(ICommandDispatcher commands,
											  IConversationBinder conversationBinder,
											  IEventAggregator eventAggregator)
		{
			_commands = commands;
			_conversationBinder = conversationBinder;
			_eventAggregator = eventAggregator;
		}

		public override void StartWatch()
		{
			// Synchronization should be done when:
			// TODO:
			// -E-mail was moved from one folder to another
			// -The scope of monitoring is all accounts->all mail folders

			// -New e-mail is received (monitor all the mail folders, including subfolders of course)

			_folderItems = new Dictionary<Folder, Items>();

			foreach (Account account in Globals.ThisAddIn.Application.Session.Accounts)
			{
				var inbox = (Folder)account.DeliveryStore.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
				GetFoldersWithChilds(inbox);

				foreach (var folderItem in _folderItems)
				{
					var folder = folderItem.Key;
					folder.BeforeItemMove += MailItemRemoved;

					var items = folderItem.Value;
					items.ItemAdd += MailItemAdded;
					items.ItemChange += MailItemChanged;
				}

				// -E-mail was created but not sent. It was saved to draft folders instead.
				var draft = (Folder)account.DeliveryStore.GetDefaultFolder(OlDefaultFolders.olFolderDrafts);
				_folderItems.Add(draft, draft.Items);
				var draftItems = draft.Items;
				draftItems.ItemAdd += MailItemAdded;
				draftItems.ItemChange += MailItemAdded; //MailItemChanged

				// -New e-mail is sent. When there is no connection with server as well. (Two options here: 1) monitor Sent folder 2) monitor Application.ItemSend event)
				//var sent = this.Application.Session.GetDefaultFolder(OlDefaultFolders.olFolderSentMail);
				//_sentItems = sent.Items;
				//_sentItems.ItemAdd += SyncConversation;
			}
		}

		private void GetFoldersWithChilds(Folder root)
		{
			_folderItems.Add(root, root.Items);
			foreach (Folder folder in root.Folders)
			{
				GetFoldersWithChilds(folder);
			}
		}

		private void MailItemAdded(object item)
		{
			var conversation = _conversationBinder.Bind((MailItem)item);
			_commands.Dispatch(new MergeConversation(conversation));
			_eventAggregator.GetEvent<ConversationAddedEvent>().Publish(conversation);
		}

		private void MailItemChanged(object item)
		{
			//Occurs when mail item is changes. For instance when it was unread and becomes read.
			//Event is usefull to sych the tree with read\unread value

			//var mailItem = (MailItem)item;
			//var ppItem = new PingPongMailItem
			//	{
			//		ItemId = mailItem.EntryID,
			//		StoreId = ((Folder)mailItem.Parent).StoreID,
			//		FolderId = ((Folder)mailItem.Parent).EntryID,
			//	};
			//_bus.GetEvent<MailItemChangedEvent>().Publish(ppItem);
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
			throw new System.NotImplementedException();
		}
	}
}