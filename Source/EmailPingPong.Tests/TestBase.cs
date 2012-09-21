using NUnit.Framework;

namespace EmailPingPong.Tests
{
	public class TestBase
	{
		[TestFixtureSetUp]
		public virtual void TestFixtureSetUp()
		{
		}

		[TestFixtureTearDown]
		public virtual void TestFixtureTearDown()
		{
		}

		[SetUp]
		public virtual void TestSetup()
		{
		}

		[TearDown]
		public virtual void TestTearDown()
		{
		}
	}
}