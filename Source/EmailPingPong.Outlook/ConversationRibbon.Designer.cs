using Conversation;

namespace EmailPingPong.Outlook
{
	partial class ConversationRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ConversationRibbon()
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
			this.ConversationGroup = this.Factory.CreateRibbonGroup();
			this.QuestionButton = this.Factory.CreateRibbonButton();
			this.AnswerButton = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.ConversationGroup.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.ConversationGroup);
			this.tab1.Label = "Conversation";
			this.tab1.Name = "tab1";
			// 
			// ConversationGroup
			// 
			this.ConversationGroup.Items.Add(this.QuestionButton);
			this.ConversationGroup.Items.Add(this.AnswerButton);
			this.ConversationGroup.Label = "Conversation";
			this.ConversationGroup.Name = "ConversationGroup";
			// 
			// QuestionButton
			// 
			this.QuestionButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.QuestionButton.Image = global::EmailPingPong.Outlook.Properties.Resources.Question_icon;
			this.QuestionButton.Label = "Question";
			this.QuestionButton.Name = "QuestionButton";
			this.QuestionButton.ShowImage = true;
			this.QuestionButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.QuestionButton_Click);
			// 
			// AnswerButton
			// 
			this.AnswerButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.AnswerButton.Image = global::EmailPingPong.Outlook.Properties.Resources.Answer_Icon;
			this.AnswerButton.Label = "Answer";
			this.AnswerButton.Name = "AnswerButton";
			this.AnswerButton.ShowImage = true;
			this.AnswerButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AnswerButton_Click);
			// 
			// ConversationRibbon
			// 
			this.Name = "ConversationRibbon";
			this.RibbonType = "Microsoft.Outlook.Mail.Compose";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ConversationRibbon_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.ConversationGroup.ResumeLayout(false);
			this.ConversationGroup.PerformLayout();

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup ConversationGroup;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton QuestionButton;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton AnswerButton;
	}

	partial class ThisRibbonCollection
	{
		internal ConversationRibbon ConversationRibbon
		{
			get
			{
				return null; //this.GetRibbon<ConversationRibbon>(); 
			}
		}
	}
}
