using System;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Commands
{
	public class ReopenConversation : ICommand
	{
		public ReopenConversation(Conversation conversation)
		{
			if (conversation == null)
			{
				throw new ArgumentNullException("conversation");
			}

			Conversation = conversation;

		}

		public Conversation Conversation { get; private set; }
	}
}