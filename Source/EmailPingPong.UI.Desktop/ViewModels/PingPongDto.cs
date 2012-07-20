using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class PingPongDto
	{
		public long Id { get; set; }

		public long? ParentId { get; set; }

		public string Author { get; set; }

		public string Body { get; set; }

		public DateTime Created { get; set; }

		public override int GetHashCode()
		{
			return (int)Id;
		}

		public override bool Equals(object obj)
		{
			return this.Id == ((PingPongDto) obj).Id;
		}

		public string ItemId { get; set; }
		public string StoreId { get; set; }
		public string FolderId { get; set; }
	}
}