using Microsoft.Office.Interop.Word;

namespace Conversation.Word.Ui.Controls
{
	public class PingControl : PingPongControl
	{
		public PingControl(Document document)
			: base(document)
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