using EmailPingPong.Core.Model;
using Microsoft.Office.Interop.Outlook;

namespace EmailPingPong.Outlook2010.Services
{
	public interface IEmailItemBinder
	{
		EmailItem Bind(MailItem mailItem);
	}

	public class EmailItemBinder : IEmailItemBinder
	{
		public EmailItem Bind(MailItem mailItem)
		{
			var folder = (Folder)mailItem.Parent;

			var email = new EmailItem
			{
				AccountId = folder.Store.DisplayName,
				ItemId = mailItem.EntryID,
				Subject = mailItem.Subject,
				CreationTime = mailItem.ReceivedTime,
				Folder = new EmailFolder(folder.StoreID, folder.EntryID, folder.Name),
				IsUnread = mailItem.UnRead
			};
			return email;
		}
	}
}