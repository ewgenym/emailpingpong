using System.Collections.Generic;
using EmailPingPong.Core.Model;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class EmailItemSwitchedEvent : CompositePresentationEvent<EmailItemSwitchedArgs>
	{
	}

	public class EmailItemSwitchedArgs
	{
		public EmailItemSwitchedArgs(string accountId, IEnumerable<EmailItem> emails)
		{
			AccountId = accountId;
			Emails = emails;
		}

		public string AccountId { get; private set; }
		public IEnumerable<EmailItem> Emails { get; private set; }
	}
}