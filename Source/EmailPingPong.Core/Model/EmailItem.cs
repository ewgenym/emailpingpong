using System;
using System.ComponentModel.DataAnnotations;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.Core.Model
{
	public class EmailItem : ModelEntityWithLongId
	{
		[Required]
		public virtual string AccountId { get; set; }

		[Required]
		public virtual string ItemId { get; set; }

		public virtual string Subject { get; set; }

		public virtual EmailFolder Folder { get; set; }

		//TODO: consider using MessageDeliveryTime (PR_MESSAGE_DELIVERY_TIME)
		[Required]
		public virtual DateTime CreationTime { get; set; }

		[Required]
		public virtual bool IsUnread { get; set; }

		public override int GetHashCode()
		{
			return (((AccountId.GetHashCode() << 5)
					 ^ ItemId.GetHashCode() << 5)
					^ Folder.GetHashCode() << 5);
		}

		public override bool Equals(object other)
		{
			if ((other == null) || !(other is EmailItem))
			{
				return false;
			}

			var thisType = GetType();
			var otherType = other.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			return AccountId == (other as EmailItem).AccountId
				&& ItemId == (other as EmailItem).ItemId
				&& Folder == (other as EmailItem).Folder;
		}

		public static bool operator ==(EmailItem entity1, EmailItem entity2)
		{
			var obj1 = (object)entity1;
			var obj2 = (object)entity2;
			if (obj1 == null && obj2 == null)
			{
				return true;
			}

			return !(obj1 == null) && entity1.Equals(entity2);
		}

		public static bool operator !=(EmailItem entity1, EmailItem entity2)
		{
			return !(entity1 == entity2);
		}
	}
}