using EmailPingPong.Core.Domain;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class MailItemRemovedEvent : CompositePresentationEvent<PingPongMailItem>
	{
	}
}