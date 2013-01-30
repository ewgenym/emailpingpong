using System.Collections.Generic;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Repositories
{
	public interface IConversationRepository : IRepository<Conversation>
	{
		IEnumerable<Conversation> GetByAccountId(string accountId);
		Conversation GetByAccountIdAndConversationId(string accountId, string conversationId);
		IEnumerable<Conversation> GetByAccountIdAndFolder(string accountId, EmailFolder folder);
		IEnumerable<Conversation> GetByAccountIdAndEmails(string accountId, IEnumerable<EmailItem> emails);
	}
}