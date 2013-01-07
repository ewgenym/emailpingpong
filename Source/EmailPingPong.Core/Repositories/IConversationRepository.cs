using System.Collections.Generic;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Repositories
{
	public interface IConversationRepository : IRepository<Conversation>
	{
		Conversation GetByConversationId(string conversationId);
		IEnumerable<Conversation> GetByAccountId(string accountId);
		IEnumerable<Conversation> GetByAccountIdAndFolders(string accountId, IEnumerable<EmailFolder> folders);
		IEnumerable<Conversation> GetByAccountIdAndEmails(string accountId, IEnumerable<EmailItem> emails);
	}
}