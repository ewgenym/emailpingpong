namespace EmailPingPong.Tests.Builders
{
	public class Create
	{
		public static CommentBuilder Comment()
		{
			return new CommentBuilder();
		}

		public static EmailItemBuilder EmailItem()
		{
			return new EmailItemBuilder();
		}

		public static ConversationBuilder Conversation()
		{
			return new ConversationBuilder();
		}
	}
}