namespace EmailPingPong.Outlook.Common.Conversation
{
	public interface IOutlookConversationMonitor
	{
		void StartWatch();
		void StopWatch();
	}
}