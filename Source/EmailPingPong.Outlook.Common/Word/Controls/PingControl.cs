using EmailPingPong.Outlook.Common.Word.Controls;
using Microsoft.Office.Interop.Word;

namespace EmailPingPong.UI.Word.Controls
{
	public class PingControl : PingPongControl
	{
		public PingControl(Document document, string conversationId)
			: base(document, conversationId)
		{
		}

		protected override string Tag
		{
			get { return "ping"; }
		}

		public void Render(string author, Range range)
		{
			var undoRecord = Document.Application.UndoRecord;
			undoRecord.StartCustomRecord("Ping tag");
			try
			{
				InternalRender(author, range);
			}
			finally
			{
				undoRecord.EndCustomRecord();
			}
		}
	}
}