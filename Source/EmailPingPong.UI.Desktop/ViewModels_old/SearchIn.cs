using EmailPingPong.UI.Desktop.Utils;

namespace EmailPingPong.UI.Desktop.ViewModels_old
{
	public enum SearchIn
	{
		[DisplayString("All folders")]
		AllFolders = 0,
		[DisplayString("Current folder")]
		CurrentFolder = 1,
		[DisplayString("Current e-mail")]
		CurrentEmail = 2,
	}
}