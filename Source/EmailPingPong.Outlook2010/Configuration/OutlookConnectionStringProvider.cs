using System.IO;
using EmailPingPong.Infrastructure;
using EmailPingPong.Outlook2010;

namespace EmailPingPong.Outlook.Common.Configuration
{
	public class OutlookConnectionStringProvider : IConnectionStringProvider
	{
		public string ConnectionString
		{
			get
			{
				var databaseDirPath = Path.GetDirectoryName(Globals.ThisAddIn.Application.Session.DefaultStore.FilePath);
				var databaseFilePath = Path.Combine(databaseDirPath, string.Format("{0}.sdf", Globals.ThisAddIn.Application.Session.CurrentProfileName));
				return string.Format("Data Source={0}", databaseFilePath);
			}
		}
	}
}