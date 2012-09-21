using EmailPingPong.Tests.Builders;

namespace EmailPingPong.Tests
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
	}
}