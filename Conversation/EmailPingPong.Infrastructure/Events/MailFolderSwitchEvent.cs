using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class MailFolderSwitchEvent : CompositePresentationEvent<string>
	{
	}
}