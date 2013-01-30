using EmailPingPong.Core.Model;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class MailFolderSwitchedEvent : CompositePresentationEvent<MailFolderSwitchedArgs>
	{
	}

	public class MailFolderSwitchedArgs
	{
		public MailFolderSwitchedArgs(string accountId, EmailFolder folder)
		{
			AccountId = accountId;
			Folder = folder;
		}

		public string AccountId { get; private set; }
		public EmailFolder Folder { get; private set; }
	}
}