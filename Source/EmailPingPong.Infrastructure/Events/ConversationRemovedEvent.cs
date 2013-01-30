using EmailPingPong.Core.Model;
using Microsoft.Practices.Prism.Events;

namespace EmailPingPong.Infrastructure.Events
{
	public class ConversationRemovedEvent : CompositePresentationEvent<ConversationRemovedArgs>
	{
	}

	public class ConversationRemovedArgs
	{
		public ConversationRemovedArgs(Conversation conversation)
		{
			Conversation = conversation;
		}

		public Conversation Conversation { get; private set; }
	}
}