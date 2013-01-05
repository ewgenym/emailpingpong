using System.ComponentModel.DataAnnotations;

namespace EmailPingPong.Core.Model
{
	public class EmailFolder : IValueObject
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
		public string StoreId { get; set; }

		[Required]
		public string FolderId { get; set; }

		[Required]
		public string FolderName { get; set; }
	}
}