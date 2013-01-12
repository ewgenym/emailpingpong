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
		public readonly IEnumerable<EmailItem> Emails;
		public readonly IEnumerable<EmailFolder> Folders;

		public ConversationViewCriteria(GroupBy groupBy, SearchIn searchIn, string accountId, IEnumerable<EmailItem> emails, IEnumerable<EmailFolder> folders)
		{
			GroupBy = groupBy;
			SearchIn = searchIn;
			AccountId = accountId;
			Emails = emails;
			Folders = folders;
		}

		public override int GetHashCode()
		{
			return (((((GroupBy.GetHashCode() << 5)
			           ^ SearchIn.GetHashCode() << 5)
			          ^ AccountId.Return(a => a.GetHashCode()) << 5)
			         ^ GetEmailsHashCode() << 5)
			        ^ GetFoldersHashCode() << 5);
		}

		private int GetEmailsHashCode()
		{
			return Emails.Return(e => e.Aggregate(0, (current, email) => current ^ email.GetHashCode() << 5));
		}

		private int GetFoldersHashCode()
		{
			return Folders.Return(f => f.Aggregate(0, (current, folder) => current ^ folder.GetHashCode() << 5));
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
				   && FolderListsAreEqual(Folders, ((ConversationViewCriteria)other).Folders);
		}

		private bool FolderListsAreEqual(IEnumerable<EmailFolder> list1, IEnumerable<EmailFolder> list2)
		{
			return list1.ElementsEqual(list2);
		}

		private bool EmailListsAreEqual(IEnumerable<EmailItem> list1, IEnumerable<EmailItem> list2)
		{
			return list1.ElementsEqual(list2);
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