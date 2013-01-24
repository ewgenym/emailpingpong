using System;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Commands
{
	public class UpdateMailItem : ICommand
	{
		public UpdateMailItem(Conversation conversation)
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