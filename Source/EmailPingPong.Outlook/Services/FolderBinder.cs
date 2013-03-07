using EmailPingPong.Core.Model;
using Microsoft.Office.Interop.Outlook;

namespace EmailPingPong.Outlook2010.Services
{
	public class FolderBinder : IFolderBinder
	{
		public EmailFolder Bind(Folder folder)
		{
			return new EmailFolder(folder.StoreID, folder.EntryID, folder.Name);
		}
	}
}