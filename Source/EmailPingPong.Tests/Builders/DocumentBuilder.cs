using System;
using EmailPingPong.UI.Word.Controls;
using Microsoft.Office.Interop.Word;

namespace EmailPingPong.Tests.Builders
{
	public class DocumentBuilder
	{
		private readonly Document _entityToBuild;

		public DocumentBuilder()
		{
			_entityToBuild = new Document();
		}

		protected Document EntityToBuild
		{
			get { return _entityToBuild; }
		}

		public Document Build()
		{
			CompleteBuilding();

			return _entityToBuild;
		}

		private void CompleteBuilding()
		{
			InitWithValidValues();
		}

		private void InitWithValidValues()
		{
		}

		public DocumentBuilder WithText(string text)
		{
			EntityToBuild.Application.Selection.Range.InsertAfter(text);
			return this;
		}

		public DocumentBuilder WithSelectedText(string text)
		{
			EntityToBuild.Application.Selection.Range.InsertAfter(text);
			var range = EntityToBuild.Range(EntityToBuild.Application.Selection.Range.Start, EntityToBuild.Content.End);
			range.Select();
			return this;
		}

		public DocumentBuilder WithPing(string author)
		{
			var ping = new PingControl(EntityToBuild);
			ping.Render(author, EntityToBuild.Application.Selection.Range);
			return this;
		}

		public DocumentBuilder WithPong(string author)
		{
			var pong = new PongControl(EntityToBuild);
			var range = EntityToBuild.Application.Selection.Range;
			pong.Render(author, range);
			return this;
		}

		public DocumentBuilder WithParagraph()
		{
			var range = EntityToBuild.Application.Selection.Range;
			if (range.ParentContentControl != null)
			{
				object start = range.ParentContentControl.Range.End + 1; //this could work without adding +1
				var range2 = EntityToBuild.Range(start, start);
				range2.Text = Environment.NewLine;

				start = range2.End;
				var range3 = EntityToBuild.Range(start, start);
				range3.Select();
			}
			
			return this;
		}
	}
}