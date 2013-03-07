namespace EmailPingPong.Outlook2010.Ribbons
{
	partial class MailCompose : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public MailCompose()
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
			this.GroupEmailPingPong = this.Factory.CreateRibbonGroup();
			this.btnQuestion = this.Factory.CreateRibbonButton();
			this.btnAnswer = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.GroupEmailPingPong.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.ControlId.OfficeId = "TabNewMailMessage";
			this.tab1.Groups.Add(this.GroupEmailPingPong);
			this.tab1.Label = "TabNewMailMessage";
			this.tab1.Name = "tab1";
			// 
			// GroupEmailPingPong
			// 
			this.GroupEmailPingPong.Items.Add(this.btnQuestion);
			this.GroupEmailPingPong.Items.Add(this.btnAnswer);
			this.GroupEmailPingPong.Label = "Email ping pong";
			this.GroupEmailPingPong.Name = "GroupEmailPingPong";
			this.GroupEmailPingPong.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupIncludeMainTab");
			// 
			// btnQuestion
			// 
			this.btnQuestion.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnQuestion.Image = global::EmailPingPong.Outlook2010.Properties.Resources.Question_icon;
			this.btnQuestion.Label = "Question";
			this.btnQuestion.Name = "btnQuestion";
			this.btnQuestion.ShowImage = true;
			this.btnQuestion.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnQuestion_Click);
			// 
			// btnAnswer
			// 
			this.btnAnswer.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnAnswer.Image = global::EmailPingPong.Outlook2010.Properties.Resources.Answer_Icon;
			this.btnAnswer.Label = "Answer";
			this.btnAnswer.Name = "btnAnswer";
			this.btnAnswer.ShowImage = true;
			this.btnAnswer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAnswer_Click);
			// 
			// MailCompose
			// 
			this.Name = "MailCompose";
			this.RibbonType = "Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mail.Read";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MailCompose_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.GroupEmailPingPong.ResumeLayout(false);
			this.GroupEmailPingPong.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupEmailPingPong;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnQuestion;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAnswer;
	}

	partial class ThisRibbonCollection
	{
		internal MailCompose MailCompose
		{
			get
			{
				return null;// this.GetRibbon<MailCompose>(); 
			}
		}
	}
}
