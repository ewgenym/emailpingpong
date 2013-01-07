using EmailPingPong.UI.Desktop.Utils;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public enum GroupBy
	{
		[DisplayString("None")]
		None = 0,
		[DisplayString("Mail subject")]
		Email = 1,
		[DisplayString("Folder")]
		Folder = 2,
	}
}