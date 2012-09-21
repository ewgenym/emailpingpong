using System;

namespace EmailPingPong.Core.Model
{
	public class EmailItem
	{
		public string AccountId { get; set; }

		public string ItemId { get; set; }

		public string Subject { get; set; }

		public EmailFolder Folder { get; set; }

		public DateTime CreationTime { get; set; }
	}
}