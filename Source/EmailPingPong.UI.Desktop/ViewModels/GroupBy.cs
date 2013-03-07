using EmailPingPong.UI.Desktop.Utils;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public enum GroupBy
	{
		[DisplayString("None")]
		None = 0,
		[DisplayString("Topic")]
		Email = 1,
		[DisplayString("Folder")]
		Folder = 2,
	}
}