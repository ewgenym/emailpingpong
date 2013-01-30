using System.Windows.Forms;
using EmailPingPong.Outlook.Common.Controllers;
using EmailPingPong.Outlook.Common.Utils;
using EmailPingPong.Outlook.Common.Word.Utils;
using EmailPingPong.Outlook2010.Services;
using EmailPingPong.UI.Word.Controls;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using Exception = System.Exception;

namespace EmailPingPong.Outlook2010.Controllers
{
	public class InspectorController : IInspectorController
	{
		private readonly IConversationMetadataTracker _metadataTracker;

		public InspectorController(IConversationMetadataTracker metadataTracker)
		{
			_metadataTracker = metadataTracker;
		}

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
			
			EnsureTracking(document, item);

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

		private void Pong(Inspector inspector)
		{
			var item = (MailItem)inspector.CurrentItem;
			var document = (Document)inspector.WordEditor;

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