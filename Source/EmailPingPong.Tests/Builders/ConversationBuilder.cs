using EmailPingPong.Core.Model;

namespace EmailPingPong.Tests.Builders
{
	public class ConversationBuilder : EntityBuilderBase<Conversation>
	{
		protected override void InitWithValidValues()
		{
		}

		public ConversationBuilder WithConversationId(string id)
		{
			EntityToBuild.ConversationId = id;
			return this;
		}

		public ConversationBuilder WithComment(Comment comment)
		{
			EntityToBuild.AddComment(comment);
			return this;
		}

		public ConversationBuilder WithEmail(EmailItem email)
		{
			EntityToBuild.AddEmail(email);
			return this;
		}

		public ConversationBuilder WithTopic(string topic)
		{
			EntityToBuild.Topic = topic;
			return this;
		}

		public ConversationBuilder WithFolderInfo(string accountId, string storeId, string folderId)
		{
			EntityToBuild.AccountId = accountId;
			EntityToBuild.StoreId = storeId;
			EntityToBuild.FolderId = folderId;
			return this;
		}
	}
}