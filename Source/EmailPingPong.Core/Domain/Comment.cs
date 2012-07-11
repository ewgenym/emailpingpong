using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmailPingPong.Core.Domain
{
	public class Comment
	{
		public Comment()
		{
			Comments = new List<Comment>();
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public long Id { get; set; }

		public long? ParentId { get; set; }
		public Comment Parent { get; set; }
		public ICollection<Comment> Comments { get; set; }

		//TODO: move the entire region to separate entity
		#region Outlook specifics 

		public string ItemId { get; set; }

		public string StoreId { get; set; }

		// Group by
		public string ItemSubject { get; set; }

		// Filter by
		public string FolderId { get; set; }

		// Group by
		public string FolderName { get; set; }

		public string FakeFieldToRecreateModel2 { get; set; }

		#endregion

		public string Author { get; set; }

		public string Body { get; set; }

		public DateTime Created { get; set; }

		public int Order { get; set; }
	}
}
