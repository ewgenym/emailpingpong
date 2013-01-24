using System.Windows.Forms;
using EmailPingPong.Outlook.Common.Configuration;
using Microsoft.Office.Core;

namespace EmailPingPong.Outlook2010.Configuration
{
	public class Outlook2010ConversationTreeStarter : ConversationTreeStarter
	{
		protected override void AddConversationTreePane(UserControl control)
		{
			var conversationPane = Globals.ThisAddIn.CustomTaskPanes.Add(control, "Conversations");
			conversationPane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionRight;
			conversationPane.Width = 350;
			conversationPane.Visible = true;
		}
	}
}