using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmailPingPong.Outlook2010;
using Microsoft.Office.Tools.Ribbon;

namespace OutlookAddIn1
{
	public partial class Explorer
	{
		private void Explorer_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void conversationsButton_Click(object sender, RibbonControlEventArgs e)
		{
			var conversationPane = Globals.ThisAddIn.CustomTaskPanes.SingleOrDefault(p=>p.Title == "Conversations");
			if (conversationPane != null)
			{
				conversationPane.Visible = !conversationPane.Visible;
			}
		}
	}
}
