namespace EmailPingPong.Outlook.Common.Conversation.Implementation
{
	public abstract class ConversationMonitorBase : IOutlookConversationMonitor
	{
		public abstract void StartWatch();

		public abstract void StopWatch();
	}
}