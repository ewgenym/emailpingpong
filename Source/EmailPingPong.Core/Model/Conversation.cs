using System;
using System.Collections.Generic;
using System.Linq;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.Core.Model
{
	public class Conversation : ModelEntityWithLongId
	{
		public string ConversationId { get; set; }

		//TODO: this is e-mail subject but normalized using PR_SUBJECT_PREFIX_W property
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
			if (sourceConversation == null) 
				throw new ArgumentNullException("sourceConversation");

			if (sourceConversation.IsNewerThan(this))
			{
				Comments.Clear();
				Comments.AddRange(sourceConversation.Comments);

				Emails.Add(sourceConversation.NewestEmail);
			}
		}

		private bool IsNewerThan(Conversation conversation)
		{
			if (conversation == null) 
				throw new ArgumentNullException("conversation");

			if (conversation.NewestEmail == null)
				throw new ArgumentException("Newest email for the source conversation can not be empty.", "conversation");

			if (NewestEmail == null)
			{
				return false;
			}

			return NewestEmail.CreationTime.LaterThen(conversation.NewestEmail.CreationTime);
		}
	}
}