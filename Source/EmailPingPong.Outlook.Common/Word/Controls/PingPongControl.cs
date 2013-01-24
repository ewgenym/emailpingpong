using System;
using EmailPingPong.Outlook.Common.Word.Utils;
using Microsoft.Office.Interop.Word;

namespace EmailPingPong.Outlook.Common.Word.Controls
{
	public abstract class PingPongControl
	{
		private readonly Document _document;
		private readonly string _conversationId;

		public PingPongControl(Document document, string conversationId)
		{
			_document = document;
			_conversationId = conversationId;

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
			var authorControl = RenderAuthor(author, authorRange);

			// Separate author from ping body
			authorControl.Range.InsertAfter(" ");

			var bodyRange = Document.Range(authorControl.Range.Start - 1, Math.Max(range.End, authorControl.Range.End + 1));
			var bodyControl = RenderBody(bodyRange);

			// Move cursor at the end of the ping body
			var selectionRange = Document.Range(bodyControl.Range.End, bodyControl.Range.End);

			selectionRange.Select();
		}

		protected virtual ContentControl RenderAuthor(string author, Range authorRange)
		{
			authorRange.Text = "[" + author + "]:";

			var rng = (object)authorRange;
			var authorControl = _document.ContentControls.Add(WdContentControlType.wdContentControlRichText, ref rng);
			authorControl.Tag = "author";

			//var textStyle = (object)"Quote";
			//authorControl.set_DefaultTextStyle(ref textStyle);

			return authorControl;
		}

		protected virtual ContentControl RenderBody(Range range)
		{
			var rng = (object)range;
			var bodyControl = _document.ContentControls.Add(WdContentControlType.wdContentControlRichText, ref rng);
			bodyControl.Title = Tag;
			//TODO: at least introduce PingPongMetadat class and searialize it to tag property instead. Include original author
			var creationDate = DateTime.UtcNow.ToString("u");
			bodyControl.Tag = Tag + ";" + creationDate + ";" + _conversationId;
			
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
				foreach (ContentControl control in pingPongControl.Range.ContentControls)
				{
					if (control.IsAuthor())
					{
						control.Delete(true);
					}
				}
				var range = pingPongControl.Range;
				pingPongControl.Delete();
				range.Select();
			}
			finally
			{
				undoRecord.EndCustomRecord();
			}
		}
	}
}
