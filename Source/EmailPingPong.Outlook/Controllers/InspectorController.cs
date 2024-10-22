﻿using System.Windows.Forms;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.Outlook.Common.Controllers;
using EmailPingPong.Outlook.Common.Utils;
using EmailPingPong.Outlook.Common.Word.Utils;
using EmailPingPong.Outlook2010.Services;
using EmailPingPong.UI.Desktop.Utils;
using EmailPingPong.UI.Word.Controls;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Outlook2010.Controllers
{
	public class InspectorController : IInspectorController
	{
		private readonly IConversationMetadataTracker _metadataTracker;

		public InspectorController(IConversationMetadataTracker metadataTracker,
								   IEventAggregator eventAggregator)
		{
			_metadataTracker = metadataTracker;
			eventAggregator.GetEvent<OpenMailItemEvent>().Subscribe(OnOpenMailItem, ThreadOption.PublisherThread);
		}

		public void HandleHotKey(object sender, KeyEventArgs keyData)
		{
			if (Functions.IsKeyDown(Keys.ControlKey))
			{
				if (Functions.IsKeyDown(Keys.D1))
				{
					Ping();
					keyData.SuppressKeyPress = true;
				}
				else if (Functions.IsKeyDown(Keys.D2))
				{
					Pong();
					keyData.SuppressKeyPress = true;
				}
			}
		}

		public void Ping()
		{
			var inspector = Globals.ThisAddIn.Application.ActiveInspector();
			if (inspector != null)
			{
				var item = (MailItem)inspector.CurrentItem;
				var document = (Document)inspector.WordEditor;

				Ping(item, document);
			}
			else
			{
				var explorer = Globals.ThisAddIn.Application.ActiveExplorer();
				if (explorer.ActiveInlineResponse != null && explorer.ActiveInlineResponseWordEditor != null)
				{
					Ping(explorer.ActiveInlineResponse, explorer.ActiveInlineResponseWordEditor);
				}
			}
		}

		public void Pong()
		{
			var inspector = Globals.ThisAddIn.Application.ActiveInspector();
			if (inspector != null)
			{
				var item = (MailItem)inspector.CurrentItem;
				var document = (Document)inspector.WordEditor;

				Pong(item, document);
			}
			else
			{
				var explorer = Globals.ThisAddIn.Application.ActiveExplorer();
				if (explorer.ActiveInlineResponse != null && explorer.ActiveInlineResponseWordEditor != null)
				{
					Pong(explorer.ActiveInlineResponse, explorer.ActiveInlineResponseWordEditor);
				}
			}
		}

		private void OnOpenMailItem(OpenMailItemArgs e)
		{
			var emailItem = e.EmailItem;
			var olns = Globals.ThisAddIn.Application.GetNamespace("MAPI");
			var explorer = Globals.ThisAddIn.Application.ActiveExplorer();
			// TODO: sometimes search fails. Should not be the case but handle it correctly
			var item = (MailItem)olns.GetItemFromID(emailItem.ItemId, emailItem.Folder.StoreId);
			try
			{
				if (explorer.IsItemSelectableInView(item))
				{
					var view = explorer.CurrentView as Microsoft.Office.Interop.Outlook.View;
					if (view == null || view.ViewType != OlViewType.olTableView)
					{
						return;
					}
					
					explorer.ClearSelection();
					explorer.AddToSelection(item);
					explorer.ScrollToSelection();
					//Marshal.ReleaseComObject(item);
				}
				else
				{
					//TODO: that magic doesn't work for Office 2013
					ExplorerEvents_10_ViewSwitchEventHandler viewSwitchHandler = () => explorer.AddToSelection(item);
					ExplorerEvents_10_FolderSwitchEventHandler folderSwitchHandler = () => explorer.ViewSwitch += viewSwitchHandler;

					explorer.ClearSelection();
					var folder = (Folder)item.Parent;
					explorer.FolderSwitch += folderSwitchHandler;
					explorer.SelectFolder(folder);
					explorer.FolderSwitch -= folderSwitchHandler;
					explorer.ViewSwitch -= viewSwitchHandler;
				}
			}
			finally
			{
				//Marshal.ReleaseComObject(olns);
			}
		}

		private void Ping(MailItem item, Document document)
		{
			EnsureTracking(document, item);

			var range = document.Application.Selection.Range;

			var pingPongControl = range.PingPongControl();
			var qr = new PingControl(document);
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
				var qp = new PongControl(document);
				qp.Undo(pingPongControl);
			}
		}

		private void Pong(MailItem item, Document document)
		{
			EnsureTracking(document, item);

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

		private void EnsureTracking(Document document, MailItem item)
		{
			int start = document.Application.Selection.Range.Start;
			int end = document.Application.Selection.Range.End;
			try
			{
				_metadataTracker.Track(item);
			}
			finally
			{
				document.Application.Selection.SetRange(start, end);
			}
		}
	}
}