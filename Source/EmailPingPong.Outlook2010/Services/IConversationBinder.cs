using Microsoft.Office.Interop.Outlook;
using Conversation = EmailPingPong.Core.Model.Conversation;

namespace EmailPingPong.Outlook2010.Services
{
	public interface IConversationBinder
	{
		Conversation Bind(MailItem mailItem);
	}
}