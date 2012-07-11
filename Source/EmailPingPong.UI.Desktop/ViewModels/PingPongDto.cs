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
	}
}