using EmailPingPong.Core.Model;
using Microsoft.Office.Interop.Outlook;

namespace EmailPingPong.Outlook2010.Services
{
	public interface IFolderBinder
	{
		EmailFolder Bind(Folder folder);
	}
}