using System;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Commands
{
	public class MergeConversation : ICommand
	{
		public MergeConversation(Conversation conversation)
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