using System;
using EmailPingPong.Core.Model;

namespace EmailPingPong.Tests.Builders
{
	public class EmailItemBuilder : EntityBuilderBase<EmailItem>
	{
		protected override void InitWithValidValues()
		{
			if (EntityToBuild.CreationTime == default(DateTime))
			{
				EntityToBuild.CreationTime = DateTime.Now;
			}
		}

		public EmailItemBuilder WithAccountId(string accountId)
		{
			EntityToBuild.AccountId = accountId;
			return this;
		}

		public EmailItemBuilder WithItemId(string itemId)
		{
			EntityToBuild.ItemId = itemId;
			return this;
		}

		public EmailItemBuilder WithSubject(string subject)
		{
			EntityToBuild.Subject = subject;
			return this;
		}

		public EmailItemBuilder WithFolder(string storeId, string folderId, string folderName)
		{
			EntityToBuild.Folder = new EmailFolder(storeId, folderId, folderName);
			return this;
		}

		public EmailItemBuilder WithCreationTime(DateTime dateTime)
		{
			EntityToBuild.CreationTime = dateTime;
			return this;
		}

		public EmailItemBuilder WithIsUnread(bool isUnread)
		{
			EntityToBuild.IsUnread = isUnread;
			return this;
		}
	}
} 