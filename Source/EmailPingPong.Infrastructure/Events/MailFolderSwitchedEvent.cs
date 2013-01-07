using System.Collections.Generic;
using EmailPingPong.Core.Model;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class MailFolderSwitchedEvent : CompositePresentationEvent<MailFolderSwitchedArgs>
	{
	}

	public class MailFolderSwitchedArgs
	{
		public MailFolderSwitchedArgs(string accountId, IEnumerable<EmailFolder> folders)
		{
			AccountId = accountId;
			Folders = folders;
		}

		public string AccountId { get; private set; }
		public IEnumerable<EmailFolder> Folders { get; private set; }
	}
}