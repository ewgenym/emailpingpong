using EmailPingPong.Infrastructure;
using EmailPingPong.Outlook.Common.Controllers;
using Microsoft.Office.Tools.Ribbon;

namespace EmailPingPong.Outlook2010.Ribbons
{
	public partial class MailCompose
	{
		private void MailCompose_Load(object sender, RibbonUIEventArgs e)
		{
		}

		private void btnQuestion_Click(object sender, RibbonControlEventArgs e)
		{
			var controller = ServiceLocator.Container.Resolve<IInspectorController>();
			controller.Ping();
		}

		private void btnAnswer_Click(object sender, RibbonControlEventArgs e)
		{
			var controller = ServiceLocator.Container.Resolve<IInspectorController>();
			controller.Pong();
		}
	}
}
