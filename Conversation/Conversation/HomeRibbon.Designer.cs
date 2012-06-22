namespace Conversation
{
	partial class HomeRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public HomeRibbon()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Home = this.Factory.CreateRibbonTab();
			this.Conversation = this.Factory.CreateRibbonGroup();
			this.toggleConversationButton = this.Factory.CreateRibbonToggleButton();
			this.Home.SuspendLayout();
			this.Conversation.SuspendLayout();
			// 
			// Home
			// 
			this.Home.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.Home.ControlId.OfficeId = "TabMail";
			this.Home.Groups.Add(this.Conversation);
			this.Home.Label = "TabMail";
			this.Home.Name = "Home";
			// 
			// Conversation
			// 
			this.Conversation.Items.Add(this.toggleConversationButton);
			this.Conversation.Label = "Email ping pong";
			this.Conversation.Name = "Conversation";
			// 
			// toggleConversationButton
			// 
			this.toggleConversationButton.Checked = true;
			this.toggleConversationButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.toggleConversationButton.Image = global::Conversation.Properties.Resources.Actions_view_conversation_balloon_icon;
			this.toggleConversationButton.Label = "Find Conversation";
			this.toggleConversationButton.Name = "toggleConversationButton";
			this.toggleConversationButton.ShowImage = true;
			this.toggleConversationButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButton1_Click);
			// 
			// HomeRibbon
			// 
			this.Name = "HomeRibbon";
			this.RibbonType = "Microsoft.Outlook.Explorer";
			this.Tabs.Add(this.Home);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.HomeRibbon_Load);
			this.Home.ResumeLayout(false);
			this.Home.PerformLayout();
			this.Conversation.ResumeLayout(false);
			this.Conversation.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab Home;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup Conversation;
		internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleConversationButton;
	}

	partial class ThisRibbonCollection
	{
		internal HomeRibbon HomeRibbon
		{
			get { return this.GetRibbon<HomeRibbon>(); }
		}
	}
}
