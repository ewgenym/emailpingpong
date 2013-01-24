using System.Windows.Forms;

namespace EmailPingPong.Outlook.Common.Controllers
{
	public interface IInspectorController
	{
		void HandleHotKey(object sender, KeyEventArgs keyData);
	}

}