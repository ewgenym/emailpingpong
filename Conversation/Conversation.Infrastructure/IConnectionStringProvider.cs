using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversation.Infrastructure
{
	public interface IConnectionStringProvider
	{
		string ConnectionString { get; }
	}
}