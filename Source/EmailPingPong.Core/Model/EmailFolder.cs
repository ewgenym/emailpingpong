﻿using System.ComponentModel.DataAnnotations;

namespace EmailPingPong.Core.Model
{
	public class EmailFolder //: IValueObject
	{
		public EmailFolder()
		{
		}

		public EmailFolder(string storeId, string folderId, string folderName)
		{
			StoreId = storeId;
			FolderId = folderId;
			FolderName = folderName;
		}

		[Required]
		public virtual string StoreId { get; set; }

		[Required]
		public virtual string FolderId { get; set; }

		[Required]
		public virtual string FolderName { get; set; }

		public override int GetHashCode()
		{
			return (((StoreId.GetHashCode() << 5)
			         ^ FolderId.GetHashCode() << 5)
			        ^ FolderName.GetHashCode() << 5);
		}

		public override bool Equals(object other)
		{
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			if ((other == null) || !(other is EmailFolder))
			{
				return false;
			}

			var thisType = GetType();
			var otherType = other.GetType();

			if (thisType != otherType)
			{
				return false;
			}

			return StoreId == (other as EmailFolder).StoreId
				&& FolderId == (other as EmailFolder).FolderId
				&& FolderName == (other as EmailFolder).FolderName;
		}

		public static bool operator== (EmailFolder entity1, EmailFolder entity2)
		{
			var obj1 = (object) entity1;
			var obj2 = (object)entity2;
			if (obj1 == null && obj2 == null)
			{
				return true;
			}

			return !(obj1 == null) && entity1.Equals(entity2);
		}

		public static bool operator!= (EmailFolder entity1, EmailFolder entity2)
		{
			return !(entity1 == entity2);
		}
	}
}