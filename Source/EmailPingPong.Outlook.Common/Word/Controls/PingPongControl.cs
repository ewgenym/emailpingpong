using System;
using System.Text.RegularExpressions;
using EmailPingPong.Outlook.Common.Word.Utils;
using Microsoft.Office.Interop.Word;

namespace EmailPingPong.Outlook.Common.Word.Controls
{
	public abstract class PingPongControl
	{
		private readonly Document _document;

		protected PingPongControl(Document document)
		{
			_document = document;

			if (!_document.FormsDesign)
			{
				//_document.ToggleFormsDesign();
			}
		}

		protected abstract string Tag { get; }

		protected Document Document
		{
			get { return _document; }
		}

		protected virtual void InternalRender(string author, Range range)
		{
			var authorRange = Document.Range(range.Start, range.Start);
			RenderAuthor(author, authorRange);

			var bodyRange = Document.Range(authorRange.Start, Math.Max(range.End, authorRange.End));
			var bodyControl = RenderBody(bodyRange);

			// Move cursor at the end of the ping body
			var selectionRange = Document.Range(bodyControl.Range.End, bodyControl.Range.End);

			selectionRange.Select();
		}

		private void RenderAuthor(string author, Range authorRange)
		{
			var authorText = string.Format("[{0}]: ", author);
			authorRange.Text = authorText;
		}

		protected virtual ContentControl RenderBody(Range range)
		{
			var rng = (object)range;
			var bodyControl = _document.ContentControls.Add(WdContentControlType.wdContentControlRichText, ref rng);
			bodyControl.Title = Tag;
			//TODO: at least introduce PingPongMetadat class and searialize it to tag property instead. Include original author
			var creationDate = DateTime.UtcNow.ToString("u");
			var commentId = Guid.NewGuid().ToString("N");
			bodyControl.Tag = Tag + ";" + creationDate + ";" + commentId;
			
			return bodyControl;
		}

		public void Undo(ContentControl pingPongControl)
		{
			if (pingPongControl == null)
				throw new ArgumentNullException("pingPongControl");

			if (!pingPongControl.IsPingPong())
				throw new ArgumentException("Ping-pong control is expected.");

			var undoRecord = Document.Application.UndoRecord;
			undoRecord.StartCustomRecord("Ping-pong tag removal");
			try
			{
				RemoveAuthor(pingPongControl.Range);
				RemoveBodyControl(pingPongControl);
			}
			finally
			{
				undoRecord.EndCustomRecord();
			}
		}

		private static void RemoveBodyControl(ContentControl pingPongControl)
		{
			var range = pingPongControl.Range;
			pingPongControl.Delete();
			range.Select();
		}

		private static void RemoveAuthor(Range pingPongControlRange)
		{
			var text = pingPongControlRange.Text;
			var regexp = new Regex(@"^\[.*\]:\s?");
			text = regexp.Replace(text, string.Empty, 1);
			pingPongControlRange.Text = text;
		}
	}
}
