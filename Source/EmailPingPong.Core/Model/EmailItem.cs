using System;
using System.ComponentModel.DataAnnotations;

namespace EmailPingPong.Core.Model
{
	public class EmailItem : ModelEntityWithLongId
	{
		[Required]
		public virtual string AccountId { get; set; }

		[Required]
		public virtual string ItemId { get; set; }

		public virtual string Subject { get; set; }

		public virtual EmailFolder Folder { get; set; }

		//TODO: consider using MessageDeliveryTime (PR_MESSAGE_DELIVERY_TIME)
		[Required]
		public virtual DateTime CreationTime { get; set; }

		[Required]
		public virtual bool IsUnread { get; set; }

		public virtual bool SameAs(EmailItem other)
		{
			if (other == null)
			{
				return false;
			}

			return AccountId == other.AccountId
				   && Folder == other.Folder
				   && ItemId == other.ItemId;
		}
	}
}