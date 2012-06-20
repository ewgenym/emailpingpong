using System.Collections.Generic;
using Conversation.Core.Domain;
using Microsoft.Practices.Prism.Events;

namespace Conversation.Infrastructure.Events
{
	public class MailItemSwitchEvent : CompositePresentationEvent<IEnumerable<PingPongMailItem>>
	{
	}
}