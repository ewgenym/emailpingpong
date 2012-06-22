using Castle.Windsor;

namespace EmailPingPong.Infrastructure
{
	public static class ServiceLocator
	{
		public static IWindsorContainer Container { get; set; }
	}
}
