using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conversation.Core.Domain;
using Microsoft.Practices.Prism.Events;

namespace Conversation.Infrastructure.Events
{
	public class MailItemAddedEvent : CompositePresentationEvent<PingPongMailItem>
	{
	}
}