using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Castle.Windsor;
using Conversation;
using EmailPingPong.Core.Domain;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Infrastructure.Repositories;
using EmailPingPong.Outlook.Utils;
using EmailPingPong.UI.Desktop.Views;
using EmailPingPong.UI.Word.Controls;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Outlook
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
			_eventAggregator = _container.Resolve<IEventAggregator>();
			_commentRepository = _container.Resolve<ICommentRepository>();

			AddConversationTree();

			_explorer = this.Application.ActiveExplorer();
			_explorer.FolderSwitch += ThisAddIn_FolderSwitch;
			_explorer.SelectionChange += _explorer_SelectionChange;
			_eventAggregator.GetEvent<PingPongItemSelectedEvent>().Subscribe(mailItem =>
				{
					var olns = Application.GetNamespace("MAPI");
					var item = (MailItem)olns.GetItemFromID(mailItem.ItemId, mailItem.StoreId);
					try
					{
						if (_explorer.IsItemSelectableInView(item))
						{
							_explorer.ClearSelection();
							_explorer.AddToSelection(item);
							_explorer.ScrollToSelection();
						}
						else
						{
							_explorer.ClearSelection();

							var folder = (Folder)item.Parent;
							_explorer.SelectFolder(folder);
							_explorer.FolderSwitch += () =>
													  Application.ActiveExplorer().AddToSelection(item);
						}
					}
					finally
					{
						Marshal.ReleaseComObject(olns);
						if (item != null)
							Marshal.ReleaseComObject(item);
					}
				}, ThreadOption.PublisherThread);

			//Key board shorcuts
			InterceptKeys.SetHook();
			InterceptKeys.KeyDown += HotKeys;
		}

		private void HotKeys(object sender, KeyEventArgs keyData)
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

		private void ThisAddIn_FolderSwitch()
		{
			if (_explorer.CurrentFolder != null)
			{
				_eventAggregator.GetEvent<MailFolderSwitchEvent>().Publish(_explorer.CurrentFolder.EntryID);
			}
		}

		private void _explorer_SelectionChange()
		{
			var mailItem = GetCurrentPingPongMailItem();
			_eventAggregator.GetEvent<MailItemSwitchEvent>().Publish(mailItem);
		}

		private IEnumerable<PingPongMailItem> GetCurrentPingPongMailItem()
		{
			var items = new List<PingPongMailItem>();

			if (_explorer.CurrentFolder == null || _explorer.CurrentFolder.DefaultItemType != OlItemType.olMailItem)
			{
				return items;
			}

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