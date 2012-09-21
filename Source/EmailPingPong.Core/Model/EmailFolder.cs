namespace EmailPingPong.Core.Model
{
	public class EmailFolder
	{
		private readonly string _storeId;
		private readonly string _folderId;
		private readonly string _folderName;

		public EmailFolder(string storeId, string folderId, string folderName)
		{
			_storeId = storeId;
			_folderId = folderId;
			_folderName = folderName;
		}

		public string StoreId
		{
			get { return _storeId; }
		}

		public string FolderId
		{
			get { return _folderId; }
		}

		public string FolderName
		{
			get { return _folderName; }
		}
	}
}