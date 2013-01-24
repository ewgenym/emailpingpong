using System;
using System.Linq;
using System.Windows.Forms;
using EmailPingPong.Outlook.Common.Controllers;
using EmailPingPong.Outlook.Common.Utils;
using EmailPingPong.Outlook.Common.Word.Utils;
using EmailPingPong.UI.Word.Controls;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using EmailPingPong.Outlook.Common.Word.Utils;

namespace EmailPingPong.Outlook2010.Controllers
{
	public class InspectorController : IInspectorController
	{
		private const string EmailpingpongConversationIdKey = "_EmailPingPong.ConversationId";

		public void HandleHotKey(object sender, KeyEventArgs keyData)
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
							Ping(inspector);
							keyData.SuppressKeyPress = true;
						}
						else if (pong)
						{
							Pong(inspector);
							keyData.SuppressKeyPress = true;
						}
					}
				}
			}
		}

		private void Ping(Inspector inspector)
		{
			var item = (MailItem)inspector.CurrentItem;
			var document = (Document)inspector.WordEditor;

			var conversationId = EnsureConversationTracking(item, document);

			var range = document.Application.Selection.Range;
			var pingPongControl = range.PingPongControl();
			var qr = new PingControl(inspector.WordEditor, conversationId);
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
				var qp = new PongControl(inspector.WordEditor, conversationId);
				qp.Undo(pingPongControl);
			}
		}

		private string EnsureConversationTracking(MailItem mailItem, Document document)
		{
			foreach (ContentControl contentControl in document.ContentControls)
			{
				if (contentControl.IsPingPong())
				{
					var conversationId = contentControl.ConversationId();
					Guid value;
					if (Guid.TryParse(conversationId, out value))
					{
						return conversationId;
					}
				}
			}

			return Guid.NewGuid().ToString("N");
		}

		public void Pong(Inspector inspector)
		{
			var item = (MailItem)inspector.CurrentItem;
			var document = (Document)inspector.WordEditor;

			var conversationId = EnsureConversationTracking(item, document);

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

			var pongControl = new PongControl(document, conversationId);
			pongControl.Render(author, range);
		}
	}
}