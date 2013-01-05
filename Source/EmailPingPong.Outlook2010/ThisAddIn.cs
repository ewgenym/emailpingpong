using System;
using System.Diagnostics;
using EmailPingPong.Outlook.Common;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace EmailPingPong.Outlook2010
{
	public partial class ThisAddIn
	{
		private IAddInBootstrapper _addInBootstrapper;

		private void ThisAddIn_Startup(object sender, EventArgs e)
		{
			try
			{
				_addInBootstrapper = new OutlookAddInBootstrapper();
				_addInBootstrapper.Startup();
			}
			catch (Exception ex)
			{
				LogErrorInApplicationEventLog(ex);
				throw;
			}
		}

		private void ThisAddIn_Shutdown(object sender, EventArgs e)
		{
			try
			{
				_addInBootstrapper.Shutdown();
			}
			catch (Exception ex)
			{
				LogErrorInApplicationEventLog(ex);
				throw;
			}
		}

		private void LogErrorInApplicationEventLog(Exception exception)
		{
			var errorMessage = string.Format("Failed to start add-in. {0}{1}",
											 Environment.NewLine,
											 exception);

			var eventSource = AppDomain.CurrentDomain.SetupInformation.ApplicationName;
			EventLog.WriteEntry(eventSource, errorMessage, EventLogEntryType.Error);
		}

		#region VSTO generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(ThisAddIn_Startup);
			this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
		}

		#endregion
	}
}