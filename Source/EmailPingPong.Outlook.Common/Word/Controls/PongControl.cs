using EmailPingPong.Outlook.Common.Word.Controls;
using EmailPingPong.Outlook.Common.Word.Utils;
using Microsoft.Office.Interop.Word;

namespace EmailPingPong.UI.Word.Controls
{
	public class PongControl : PingPongControl
	{
		public PongControl(Document document, string conversationId)
			: base(document, conversationId)
		{
		}

		protected override string Tag
		{
			get { return "pong"; }
		}

		public void Render(string author, Range range)
		{
			var undoRecord = Document.Application.UndoRecord;
			undoRecord.StartCustomRecord("Pong tag");
			try
			{
				var pingPongControl = range.PingPongControl();
				Range pongRange = null;
				
				if (pingPongControl != null)
				{
					pongRange = Document.Range(pingPongControl.Range.End + 1, pingPongControl.Range.End + 1);
					pongRange.InsertParagraph();
					pongRange.InsertAfter("	");
					pongRange = Document.Range(pongRange.End, pongRange.End);
				}
				else
				{
					//TODO: is this behaviour correct? User has selected text and pressed pong (or just pressed pong in cursor position).
					// We could create a pong but what ping will it be related? We can create ping, but is this what he really wants?
					pongRange = Document.Application.Selection.Range;
				}

				if (pongRange != null)
				{
					InternalRender(author, pongRange);
				}
			}
			finally
			{
				undoRecord.EndCustomRecord();
			}
		}
	}
}