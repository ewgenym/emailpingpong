using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using Castle.Windsor;
using Castle.Windsor.Installer;
using EmailPingPong.Core.Domain;
using EmailPingPong.Infrastructure;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Infrastructure.Repositories;
using EmailPingPong.UI.Desktop.Views;
using EmailPingPong.UI.Word;
using EmailPingPong.UI.Word.Controls;
using EmailPingPong.UI.Word.Utils;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Practices.Prism.Events;

namespace Conversation
{
    public partial class ThisAddIn
    {
    	private Items _inboxItems;
    	private Dictionary<Folder, Items> _folderItems;
		private Items _sentItems;
    	private Items _draftItems;
    	private Explorer _explorer;
    	private ICommentRepository _commentRepository;
    	private Microsoft.Office.Tools.CustomTaskPane _conversationPane;
    	private WindsorContainer _container;
    	private IEventAggregator _eventAggregator;

		private void ThisAddIn_Startup(object sender, EventArgs e)
		{
			BootsrtrapPersistanceStorage();

			BootstrapContainer();

			_eventAggregator = _container.Resolve<IEventAggregator>();
			_commentRepository = _container.Resolve<ICommentRepository>();

			BootstrapSynchronization();

			AddConversationTree();

			_explorer = this.Application.ActiveExplorer();
			_explorer.FolderSwitch += ThisAddIn_FolderSwitch;
			_explorer.SelectionChange += _explorer_SelectionChange;
			_eventAggregator.GetEvent<PingPongItemSelectedEvent>().Subscribe((mailItem) =>
			                                                         	{
			                                                         		_explorer.ClearSelection(); 
																			var olns = Application.GetNamespace("MAPI");
																			var item = (MailItem)olns.GetItemFromID(mailItem.ItemId, mailItem.StoreId);
			                                                         		_explorer.AddToSelection(item);

			                                                         	}, ThreadOption.PublisherThread);

			//Key board shorcuts
			InterceptKeys.SetHook();
			InterceptKeys.KeyDown += HotKeys;
		}

    	private void BootsrtrapPersistanceStorage()
    	{
    		Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ConversationContext>());
    	}

    	void HotKeys(object sender, KeyEventArgs keyData)
		{
			if (Functions.IsKeyDown(Keys.ControlKey))
			{
				var ping = Functions.IsKeyDown(Keys.D1);
				var pong = Functions.IsKeyDown(Keys.D2);
				if (ping || pong)
				{
					var inspector = Globals.ThisAddIn.Application.ActiveInspector();
					if (inspector != null)
					{
						if (ping)
						{
							Globals.ThisAddIn.Ping(inspector);
							keyData.SuppressKeyPress = true;
						}
						else if (pong)
						{
							Globals.ThisAddIn.Pong(inspector);
							keyData.SuppressKeyPress = true;
						}
					}
				}
			}
		}

    	private void AddConversationTree()
    	{
			var conversationHost = new ConversationHost();

			_conversationPane = this.CustomTaskPanes.Add(conversationHost, "Conversations");
    		_conversationPane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionRight;
    		_conversationPane.Width = 350;
			_conversationPane.Visible = true;
    	}

    	private void BootstrapContainer()
    	{
    		_container = new WindsorContainer();
    		ServiceLocator.Container = _container;
    		_container.Install(FromAssembly.This());
    	}

    	void ThisAddIn_FolderSwitch()
    	{
			_eventAggregator.GetEvent<MailFolderSwitchEvent>().Publish(_explorer.CurrentFolder.EntryID);
    	}

		private void _explorer_SelectionChange()
		{
			var mailItem = GetCurrentPingPongMailItem();
			_eventAggregator.GetEvent<MailItemSwitchEvent>().Publish(mailItem);
		}

		private void BootstrapSynchronization()
		{
			// Synchronization should be done when:
			// TODO:
			// -E-mail was moved from one folder to another
			// -The scope of monitoring is all accounts->all mail folders

			// -New e-mail is received (monitor all the mail folders, including subfolders of course)

			_folderItems = new Dictionary<Folder, Items>();
			var inbox = (Folder)this.Application.Session.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
			GetFolderWithChild(inbox);

			foreach (var folderItem in _folderItems)
			{
				var folder = folderItem.Key;
				var items = folderItem.Value;

				items.ItemAdd += SyncConversation;
				items.ItemChange += ItemChange;
				//items.ItemRemove += RemoveConversation;
				folder.BeforeItemMove += ItemRemove;
			}

			// -New e-mail is sent. When there is no connection with server as well. (Two options here: 1) monitor Sent folder 2) monitor Application.ItemSend event)
			//var sent = this.Application.Session.GetDefaultFolder(OlDefaultFolders.olFolderSentMail);
			//_sentItems = sent.Items;
			//_sentItems.ItemAdd += SyncConversation;

			// -E-mail was created but not sent. It was saved to draft folders instead.
			var draft = this.Application.Session.GetDefaultFolder(OlDefaultFolders.olFolderDrafts);
			_draftItems = draft.Items;
			_draftItems.ItemAdd += SyncConversation;
			_draftItems.ItemChange += SyncConversation;
		}

    	private void GetFolderWithChild(Folder root)
    	{
    		_folderItems.Add(root, root.Items);
    		foreach (Folder folder in root.Folders)
    		{
    			GetFolderWithChild(folder);
    		}
    	}

    	private void ItemChange(object item)
		{
			//Occurs when mail item is changes. For instance when it was unread and becomes read.
			//Event is usefull to sych the tree with read\unread value
			var mailItem = (MailItem)item;
			var ppItem = new PingPongMailItem
			{
				ItemId = mailItem.EntryID,
				StoreId = ((Folder)mailItem.Parent).StoreID,
				FolderId = ((Folder)mailItem.Parent).EntryID,
			};
			_eventAggregator.GetEvent<MailItemChangedEvent>().Publish(ppItem);
		}

		private void ItemRemove(object item, MAPIFolder to, ref bool cancel)
		{
			var mailItem = (MailItem)item;
			var inspector = mailItem.GetInspector;
			var document = (Microsoft.Office.Interop.Word.Document)inspector.WordEditor;
			
			var questions = ParseQuestions(mailItem,to.StoreID, to.EntryID, document);

			_commentRepository.Delete(questions);
			_commentRepository.SaveChanges();

			var ppItem = new PingPongMailItem
			{
				ItemId = mailItem.EntryID,
				StoreId = ((Folder)mailItem.Parent).StoreID,
				FolderId = ((Folder)mailItem.Parent).EntryID,
			};
			_eventAggregator.GetEvent<MailItemRemovedEvent>().Publish(ppItem);
		}

    	private void SyncConversation(object item)
		{
			var mailItem = (MailItem)item;
			var inspector = mailItem.GetInspector;
			var document = (Microsoft.Office.Interop.Word.Document)inspector.WordEditor;

    		var folder = (Folder) mailItem.Parent;
			var questions = ParseQuestions(mailItem, folder.StoreID, folder.EntryID, document);

			_commentRepository.AddOrUpdate(questions);
			_commentRepository.SaveChanges();

			var ppI = new PingPongMailItem
			               	{
								ItemId = mailItem.EntryID,
								StoreId = ((Folder)mailItem.Parent).StoreID,
								FolderId = ((Folder)mailItem.Parent).EntryID,
			               	};
			_eventAggregator.GetEvent<MailItemAddedEvent>().Publish(ppI);
		}

    	private IEnumerable<PingPongMailItem> GetCurrentPingPongMailItem()
    	{
    		var items = new List<PingPongMailItem>();
			foreach (MailItem item in _explorer.Selection)
    		{
				var mailItem = new PingPongMailItem
				{
					ItemId = item.EntryID,
					StoreId = ((Folder)item.Parent).StoreID,
					FolderId = ((Folder)item.Parent).EntryID,
				};
				items.Add(mailItem);
    		}

    		return items;
    	}

    	private void RemoveConversation()
    	{
			_eventAggregator.GetEvent<MailItemRemovedEvent>().Publish(null);
    	}

		private IEnumerable<Question> ParseQuestions(MailItem mailItem, string storeId, string folderId, Microsoft.Office.Interop.Word.Document document)
		{
			var parser = new PingPongParser();
			var folder = (Folder)mailItem.Parent;


			return parser.Parse(document, mailItem.EntryID, storeId/*folder.StoreID*/, folderId/*folder.EntryID*/);
    	}

    	private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
			InterceptKeys.ReleaseHook();
        }

		public void Ping(Inspector inspector)
		{
			var item = (MailItem)inspector.CurrentItem;
			var document = (Microsoft.Office.Interop.Word.Document)inspector.WordEditor;

			var range = document.Application.Selection.Range;
			var pingPongControl = range.PingPongControl();
			var qr = new PingControl(inspector.WordEditor);
			if (pingPongControl == null)
			{
				var author = item.SendUsingAccount.CurrentUser.Name;
				qr.Render(author, range);
			}
			else if (pingPongControl.IsPing())
			{
				qr.Undo(pingPongControl);
			}
			else
			{
				// We are in pong control, but uses pressed ping. WTF he wants?
				var qp = new PongControl(inspector.WordEditor);
				qp.Undo(pingPongControl);
			}
		}

		public void Pong(Inspector inspector)
		{
			var item = (MailItem)inspector.CurrentItem;
			var document = (Microsoft.Office.Interop.Word.Document)inspector.WordEditor;
			
			var range = document.Application.Selection.Range;
			var author = string.Empty;
			if (item.SendUsingAccount != null)
			{
				author = item.SendUsingAccount.CurrentUser.Name;
			}
			else if (item.Session.CurrentUser != null)
			{
				author = item.Session.CurrentUser.Name;
			}
			
			var pongControl = new PongControl(document);
			pongControl.Render(author, range);
		}

    	#region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion

    	public void ToggleConversation()
    	{
			_conversationPane.Visible = !_conversationPane.Visible;
    	}

		public bool ConversationChecked
		{
			get { return _conversationPane.Visible; }
    	}
    }
}
