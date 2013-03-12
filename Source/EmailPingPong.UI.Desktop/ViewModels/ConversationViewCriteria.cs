using System.Collections.Generic;
using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Utils;
using EmailPingPong.UI.Desktop.Utils;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationViewCriteria
	{
		public readonly GroupBy GroupBy;
		public readonly SearchIn SearchIn;
		public readonly string AccountId;
		public readonly IList<EmailItem> Emails;
		public readonly EmailFolder Folder;

		public ConversationViewCriteria(GroupBy groupBy, SearchIn searchIn, string accountId, IList<EmailItem> emails, EmailFolder folder)
		{
			GroupBy = groupBy;
			SearchIn = searchIn;
			AccountId = accountId;
			Emails = emails;
			Folder = folder;
		}

		public override int GetHashCode()
		{
			return (((((GroupBy.GetHashCode() << 5)
			           ^ SearchIn.GetHashCode() << 5)
			          ^ AccountId.Return(a => a.GetHashCode()) << 5)
			         ^ GetEmailsHashCode() << 5)
			        ^ GetFolderHashCode() << 5);
		}

		private int GetFolderHashCode()
		{
			return SearchIn >= SearchIn.CurrentFolder
				       ? Folder.Return(f => f.GetHashCode())
				       : 0;
		}

		private int GetEmailsHashCode()
		{
			return SearchIn == SearchIn.CurrentEmail
				       ? Emails.Return(e => e.Aggregate(0, (current, email) => current ^ email.GetHashCode() << 5))
				       : 0;
		}

		public override bool Equals(object other)
		{
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			if ((other == null) || !(other is ConversationViewCriteria))
			{
				return false;
			}

			var thisType = GetType();
			var otherType = other.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			return GroupBy == ((ConversationViewCriteria) other).GroupBy
			       && SearchIn == ((ConversationViewCriteria) other).SearchIn
			       && AccountId == ((ConversationViewCriteria) other).AccountId
				   && EmailListsAreEqual(Emails, ((ConversationViewCriteria)other).Emails)
				   && FoldersAreEqual(((ConversationViewCriteria)other).Folder);
		}

		private bool FoldersAreEqual(EmailFolder other)
		{
			return SearchIn < SearchIn.CurrentFolder || Folder == other;
		}

		private bool EmailListsAreEqual(IEnumerable<EmailItem> list1, IEnumerable<EmailItem> list2)
		{
			return SearchIn != SearchIn.CurrentEmail || list1.ElementsEqual(list2);
		}

		public static bool operator ==(ConversationViewCriteria criteria1, ConversationViewCriteria criteria2)
		{
			var obj1 = (object)criteria1;
			if (obj1 == null && ((object)criteria2) == null)
			{
				return true;
			}

			return obj1 != null && criteria1.Equals(criteria2);
		}

		public static bool operator !=(ConversationViewCriteria criteria1, ConversationViewCriteria criteria2)
		{
			return !(criteria1 == criteria2);
		}
	}
}