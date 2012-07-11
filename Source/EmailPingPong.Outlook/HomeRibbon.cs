using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace EmailPingPong.Outlook
{
	public partial class HomeRibbon
	{
		private void HomeRibbon_Load(object sender, RibbonUIEventArgs e)
		{
			toggleConversationButton.Checked = Globals.ThisAddIn.ConversationChecked;
		}

		private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.ToggleConversation();
		}
	}
}
