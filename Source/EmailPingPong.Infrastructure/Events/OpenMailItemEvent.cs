using EmailPingPong.Core.Model;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class OpenMailItemEvent : CompositePresentationEvent<OpenMailItemArgs>
	{
	}

	public class OpenMailItemArgs
	{
		public OpenMailItemArgs(EmailItem emailItem)
		{
			EmailItem = emailItem;
		}

		public EmailItem EmailItem { get; private set; } 
	}
}