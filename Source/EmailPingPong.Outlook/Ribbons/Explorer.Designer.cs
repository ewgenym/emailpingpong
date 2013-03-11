using EmailPingPong.Outlook2010;

namespace OutlookAddIn1
{
	partial class Explorer : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Explorer()
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
			this.tab1 = this.Factory.CreateRibbonTab();
			this.emailPingPongGroup = this.Factory.CreateRibbonGroup();
			this.conversationsButton = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.emailPingPongGroup.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.ControlId.OfficeId = "TabMail";
			this.tab1.Groups.Add(this.emailPingPongGroup);
			this.tab1.Label = "TabMail";
			this.tab1.Name = "tab1";
			// 
			// emailPingPongGroup
			// 
			this.emailPingPongGroup.Items.Add(this.conversationsButton);
			this.emailPingPongGroup.Label = "Email ping pong";
			this.emailPingPongGroup.Name = "emailPingPongGroup";
			// 
			// conversationsButton
			// 
			this.conversationsButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.conversationsButton.Description = "Toggle conversation panel";
			this.conversationsButton.Image = global::EmailPingPong.Outlook2010.Properties.Resources.emailpingpong;
			this.conversationsButton.Label = "Conversations";
			this.conversationsButton.Name = "conversationsButton";
			this.conversationsButton.ShowImage = true;
			this.conversationsButton.SuperTip = "Toggle conversation panel";
			this.conversationsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.conversationsButton_Click);
			// 
			// Explorer
			// 
			this.Name = "Explorer";
			this.RibbonType = "Microsoft.Outlook.Explorer";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Explorer_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.emailPingPongGroup.ResumeLayout(false);
			this.emailPingPongGroup.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup emailPingPongGroup;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton conversationsButton;
	}

	partial class ThisRibbonCollection
	{
		internal Explorer Explorer
		{
			get { return null; }
		}
	}
}
