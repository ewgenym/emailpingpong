using System;
using System.ComponentModel.DataAnnotations;

namespace EmailPingPong.Core.Model
{
	public class EmailItem : ModelEntityWithLongId
	{
		[Required]
		public string AccountId { get; set; }

		[Required]
		public string ItemId { get; set; }

		[Required]
		public string Subject { get; set; }

		public EmailFolder Folder { get; set; }

		//TODO: consider using MessageDeliveryTime (PR_MESSAGE_DELIVERY_TIME)
		[Required]
		public DateTime CreationTime { get; set; }

		[Required]
		public bool IsUnread { get; set; }
	}
}