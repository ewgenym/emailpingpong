using NUnit.Framework;

namespace EmailPingPong.Tests
{
	public class Specification
	{
		[SetUp]
		public virtual void Setup()
		{
			Context();
			Because();
		}

		[TearDown]
		public virtual void TearDown()
		{

		}

		public virtual void Context()
		{
		}

		public virtual void Because()
		{
		}
	}
}