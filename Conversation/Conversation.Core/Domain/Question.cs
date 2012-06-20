using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversation.Core.Domain
{
	public class Question : Comment
	{
		public bool Closed { get; set; }
	}
}
