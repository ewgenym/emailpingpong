using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Office.Interop.Outlook;

namespace EmailPingPong.Outlook2010.Services
{
	public class ConversationMetadataTracker : IConversationMetadataTracker
	{
		private const string EmailpingpongMetadataXml = "EmailPingPong.Metadata.xml";

		public void Track(MailItem mailItem)
		{
			if (TracksConversation(mailItem))
			{
				return;
			}

			var metadata = new ConversationMetadata { ConversationId = Guid.NewGuid().ToString("N") };
			Write(mailItem, metadata);
		}

		private static void Write(MailItem mailItem, ConversationMetadata metadata)
		{
			var metadataFilePath = Path.Combine(Path.GetTempPath(), EmailpingpongMetadataXml);

			using (var writer = File.CreateText(metadataFilePath))
			{
				var doc = new XDocument(new XElement("conversation", new XAttribute("id", metadata.ConversationId)));
				doc.Save(writer);
			}
			
			var attachmentsToRemove = mailItem.Attachments
			                                  .Cast<Attachment>()
											  .Where(attachment => attachment.FileName == EmailpingpongMetadataXml);
			foreach (var attachment in attachmentsToRemove)
			{
				mailItem.Attachments.Remove(attachment.Index);
			}

			mailItem.Attachments.Add(metadataFilePath, OlAttachmentType.olByValue, 0, null);
		}

		public ConversationMetadata Read(MailItem mailItem)
		{
			var metadataAttachment = ReadMetadataAttachment(mailItem);
			if (metadataAttachment == null)
			{
				throw new NotSupportedException();
			}

			var data = (byte[])metadataAttachment.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x37010102");
			var metadata = Encoding.Default.GetString(data);
			using (var reader = new StringReader(metadata))
			{
				var doc = XDocument.Load(reader);
				var xElement = doc.Element("conversation");
				if (xElement == null)
				{
					throw new NotSupportedException();
				}
				return new ConversationMetadata
					{
						ConversationId = xElement.Attribute("id").Value
					};
			}
		}

		public bool TracksConversation(MailItem mailItem)
		{
			var metadataAttachment = ReadMetadataAttachment(mailItem);
			return (metadataAttachment != null);
		}

		public void PreserveMetadata(MailItem original, MailItem proposed)
		{
			var originalMetadata = Read(original);
			Write(proposed, originalMetadata);
		}

		private static Attachment ReadMetadataAttachment(MailItem mailItem)
		{
			var metadataAttachment = mailItem.Attachments
			                                 .Cast<Attachment>()
			                                 .SingleOrDefault(attachment => attachment.FileName == EmailpingpongMetadataXml);
			return metadataAttachment;
		}
	}

	public interface IConversationMetadataTracker
	{
		void Track(MailItem mailItem);

		ConversationMetadata Read(MailItem mailItem);

		bool TracksConversation(MailItem mailItem);

		void PreserveMetadata(MailItem original, MailItem proposed);
	}

	public class ConversationMetadata
	{
		public string ConversationId { get; set; }
	}
}