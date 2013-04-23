using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Comparers
{
	public class EmailItemComparer : EntityComparer<EmailItem>
	{
		protected override int GetEntityHashCode(EmailItem entity)
		{
			return (((entity.AccountId.GetHashCode() << 5)
			         ^ entity.ItemId.GetHashCode() << 5)
			        ^ entity.Folder.GetHashCode() << 5);
		}

		protected override bool EntitiesEqual(EmailItem x, EmailItem y)
		{
			return x.AccountId == y.AccountId
			       && x.ItemId == y.ItemId
			       && x.Folder == y.Folder;
		}
	}
}