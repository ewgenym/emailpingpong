using System;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Commands
{
	public class RemoveConversation : ICommand
	{
		private readonly Conversation _conversation;

		public RemoveConversation(Conversation conversation)
		{
			if (conversation == null)
			{
				throw new ArgumentNullException("conversation");
			}

			_conversation = conversation;
		}

		public Conversation Conversation
		{
			get { return _conversation; }
		}
	}
}