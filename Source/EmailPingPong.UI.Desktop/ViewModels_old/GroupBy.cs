using EmailPingPong.UI.Desktop.Utils;

namespace EmailPingPong.UI.Desktop.ViewModels_old
{
	public enum GroupBy
	{
		[DisplayString("None")]
		None,
		[DisplayString("Mail subject")]
		EmailSuject,
		[DisplayString("Folder")]
		Folder,
	}
}