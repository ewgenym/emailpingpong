// Type: System.Windows.Controls.UserControl
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\PresentationFramework.dll

using System.Windows.Automation.Peers;

namespace System.Windows.Controls
{
	/// <summary>
	/// Provides a simple way to create a control.
	/// </summary>
	public class UserControl : ContentControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Controls.UserControl"/> class.
		/// </summary>
		public UserControl();

		/// <summary>
		/// Creates and returns an <see cref="T:System.Windows.Automation.Peers.AutomationPeer"/> for this <see cref="T:System.Windows.Controls.UserControl"/>.
		/// </summary>
		/// 
		/// <returns>
		/// A new <see cref="T:System.Windows.Automation.Peers.UserControlAutomationPeer"/> for this <see cref="T:System.Windows.Controls.UserControl"/>.
		/// </returns>
		protected override AutomationPeer OnCreateAutomationPeer();
	}
}
