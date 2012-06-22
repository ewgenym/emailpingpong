using System.Collections.Generic;
using EmailPingPong.Core.Domain;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class MailItemSwitchEvent : CompositePresentationEvent<IEnumerable<PingPongMailItem>>
	{
	}
}