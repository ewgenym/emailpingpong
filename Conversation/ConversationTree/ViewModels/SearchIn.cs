using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversationTree.ViewModels
{
	public enum SearchIn
	{
		[DisplayString("All folders")]
		AllFolders = 0,
		[DisplayString("Current folder")]
		CurrentFolder = 1,
		[DisplayString("Current e-mail")]
		CurrentEmail = 2,
	}
}