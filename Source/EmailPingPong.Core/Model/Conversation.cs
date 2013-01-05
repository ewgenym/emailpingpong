using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.Core.Model
{
	public class Conversation : ModelEntityWithLongId
	{
		public Conversation()
		{
			Comments = new List<Comment>();
			Emails = new List<EmailItem>();
		}

		[Required]
		public string ConversationId { get; set; }

		[Required]
		public string Topic { get; set; }

		public IList<Comment> Comments { get; set; }

		public IList<EmailItem> Emails { get; set; }

		public EmailItem NewestEmail
		{
			get
			{
				return Emails.OrderByDescending(e => e.CreationTime).FirstOrDefault();
			}
		}

		public void Merge(Conversation sourceConversation)
		{
			if (string.Compare(ConversationId, sourceConversation.ConversationId, StringComparison.InvariantCultureIgnoreCase) != 0)
			{
				throw new InvalidOperationException("Can't merge conversations with different id's");
			}

			if (sourceConversation.IsNewerThan(this))
			{
				Comments.Clear();
				Comments.AddRange(sourceConversation.Comments);

				Emails.Add(sourceConversation.NewestEmail);
			}
		}

		private bool IsNewerThan(Conversation conversation)
		{
			if (NewestEmail == null)
			{
				return false;
			}

			return NewestEmail.CreationTime.LaterThen(conversation.NewestEmail.CreationTime);
		}
	}
}