using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using EmailPingPong.Infrastructure.Configuration.Implementation;

namespace Conversation.Configuration
{
	public class EmailPingPongAddInConfigurator : GenericApplicationConfigurator
	{
		public EmailPingPongAddInConfigurator(IWindsorContainer container)
			: base(container)
		{
		}

		public override void Configure()
		{
			base.Configure();
		}
	}
}