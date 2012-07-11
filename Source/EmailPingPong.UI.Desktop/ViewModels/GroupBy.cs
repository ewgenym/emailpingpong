using EmailPingPong.UI.Desktop.Utils;

namespace EmailPingPong.UI.Desktop.ViewModels
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