using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Outlook;

namespace EmailPingPong.Outlook.Utils
{
	public static class ExplorerExtensions
	{
		public static void ScrollToSelection(this Explorer explorer)
		{
			//This is to scroll down the selected e-mails
			var currentFolder = explorer.CurrentFolder;
			var sentFolder = explorer.Session.GetDefaultFolder(OlDefaultFolders.olFolderSentMail);
			try
			{
				explorer.CurrentFolder = sentFolder;
				explorer.CurrentFolder = currentFolder;			
			}
			finally
			{
				Marshal.ReleaseComObject(sentFolder);
			}
		}
	}
}