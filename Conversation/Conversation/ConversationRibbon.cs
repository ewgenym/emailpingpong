using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Conversation
{
	public partial class ConversationRibbon
	{
		private void ConversationRibbon_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void QuestionButton_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.Ping(Globals.ThisAddIn.Application.ActiveInspector());
		}

		private void AnswerButton_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.Pong(Globals.ThisAddIn.Application.ActiveInspector());
		}
	}
}
