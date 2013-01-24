using System.Windows.Forms;
using System.Windows.Forms.Integration;
using EmailPingPong.UI.Desktop.Views;

namespace EmailPingPong.Outlook.Common.Configuration
{
	public abstract class ConversationTreeStarter : IConversationTreeStarter
	{
		public void Start()
		{
			var conversationTree = CreateConversationTree();
			AddConversationTreePane(conversationTree);
		}

		protected abstract void AddConversationTreePane(UserControl control);

		private UserControl CreateConversationTree()
		{
			var userControl = new UserControl();

			var conversationTree = new ConversationTree();
			var elementHost = new ElementHost();

			userControl.SuspendLayout();

			elementHost.Dock = DockStyle.Fill;
			elementHost.Location = new System.Drawing.Point(0, 0);
			elementHost.Child = conversationTree;

			userControl.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			userControl.AutoScaleMode = AutoScaleMode.Font;
			userControl.Controls.Add(elementHost);
			userControl.ResumeLayout(false);

			return userControl;
		}
	}

	public interface IConversationTreeStarter
	{
		void Start();
	}
}