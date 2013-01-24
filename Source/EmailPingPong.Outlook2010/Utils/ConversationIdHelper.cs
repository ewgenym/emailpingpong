using System;
using EmailPingPong.Outlook.Common.Word.Utils;
using Microsoft.Office.Interop.Word;

namespace EmailPingPong.Outlook2010.Utils
{
	public class ConversationIdHelper
	{
		public static string GetConversationId(Document document)
		{
			foreach (ContentControl contentControl in document.ContentControls)
			{
				if (contentControl.IsPingPong())
				{
					var conversationId = contentControl.ConversationId();
					Guid value;
					if (Guid.TryParse(conversationId, out value))
					{
						return conversationId;
					}
				}
			}

			return null;
		}
	}
}