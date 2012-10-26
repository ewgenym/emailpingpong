using System;

namespace EmailPingPong.Core.Model
{
	public class EmailItem
	{
		public string AccountId { get; set; }

		public string ItemId { get; set; }

		public string Subject { get; set; }

		public EmailFolder Folder { get; set; }

		//TODO: consider using MessageDeliveryTime (PR_MESSAGE_DELIVERY_TIME)
		public DateTime CreationTime { get; set; }
	}
}