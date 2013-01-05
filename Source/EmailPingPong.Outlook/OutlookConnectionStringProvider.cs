using System.IO;
using Conversation;
using EmailPingPong.Infrastructure;

namespace EmailPingPong.Outlook
{
	public class OutlookConnectionStringProvider : IConnectionStringProvider
	{
		private readonly string _connectionString;

		public OutlookConnectionStringProvider()
		{
			var databaseDirPath = Path.GetDirectoryName(Globals.ThisAddIn.Application.Session.DefaultStore.FilePath);
			if (databaseDirPath != null)
			{
				var databaseFilePath = Path.Combine(databaseDirPath, "EmailPingPong.sdf");
				_connectionString = string.Format("Data Source={0}", databaseFilePath);
			}
		}

		public string ConnectionString
		{
			get { return _connectionString; }
		}
	}
}
