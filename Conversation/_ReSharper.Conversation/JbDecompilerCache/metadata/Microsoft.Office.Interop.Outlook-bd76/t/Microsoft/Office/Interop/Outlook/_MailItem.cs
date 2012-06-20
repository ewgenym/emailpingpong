// Type: Microsoft.Office.Interop.Outlook._MailItem
// Assembly: Microsoft.Office.Interop.Outlook, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// Assembly location: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Visual Studio Tools for Office\PIA\Office14\Microsoft.Office.Interop.Outlook.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	/// <summary>
	/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For information about the COM object, see <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/>.
	/// </summary>
	[TypeLibType(4160)]
	[Guid("00063034-0000-0000-C000-000000000046")]
	[ComImport]
	public interface _MailItem
	{
		/// <summary>
		/// Closes and optionally saves changes to the Outlook item.
		/// </summary>
		/// <param name="SaveMode">The close behavior. If the item displayed within the inspector has not been changed, this argument has no effect.</param>
		[DispId(61475)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Close([In] OlInspectorClose SaveMode);

		/// <summary>
		/// Creates another instance of an object.
		/// </summary>
		/// 
		/// <returns>
		/// Returns an <see cref="T:System.Object"/> that is a copy of the parent <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object.
		/// </returns>
		[DispId(61490)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object Copy();

		/// <summary>
		/// Deletes an object from the collection.
		/// </summary>
		[DispId(61514)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Delete();

		/// <summary>
		/// Displays a new <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/> object for the item.
		/// </summary>
		/// <param name="Modal">True to make the window modal. The default value is False.</param>
		[DispId(61606)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Display([MarshalAs(UnmanagedType.Struct), In, Optional] object Modal);

		/// <summary>
		/// Moves a Microsoft Outlook item to a new folder.
		/// </summary>
		/// 
		/// <returns>
		/// An Object value that represents the item which has been moved to the designated folder.
		/// </returns>
		/// <param name="DestFldr">An expression that returns a Folder object. The destination folder.</param>
		[DispId(61492)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object Move([MarshalAs(UnmanagedType.Interface), In] MAPIFolder DestFldr);

		/// <summary>
		/// Prints the Outlook item using all default settings. The PrintOut method is the only Outlook method that can be used for printing.
		/// </summary>
		[DispId(61491)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PrintOut();

		/// <summary>
		/// Saves the Microsoft Outlook item to the current folder or, if this is a new item, to the Outlook default folder for the item type.
		/// </summary>
		[DispId(61512)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Save();

		/// <summary>
		/// Saves the Microsoft Outlook item to the specified path and in the format of the specified file type. If the file type is not specified, the MSG format (.msg) is used.
		/// </summary>
		/// <param name="Path">The path in which to save the item.</param><param name="Type">The file type to save. Can be one of the following OlSaveAsType constants: olHTML, olMSG, olRTF, olTemplate, olDoc,olTXT, olVCal,  olVCard,  olICal, or olMSGUnicode.</param>
		[DispId(61521)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SaveAs([MarshalAs(UnmanagedType.BStr), In] string Path, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

		/// <summary>
		/// Clears the index of the conversation thread for the mail message.
		/// </summary>
		[DispId(63522)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ClearConversationIndex();

		/// <summary>
		/// Executes the Forward action for an item and returns the resulting copy as a  <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// A MailItem object that represents the new mail item.
		/// </returns>
		[DispId(63507)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MailItem Forward();

		/// <summary>
		/// Creates a reply, pre-addressed to the original sender, from the original message.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object that represents the reply.
		/// </returns>
		[DispId(63504)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MailItem Reply();

		/// <summary>
		/// Creates a reply to all original recipients from the original message.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object that represents the reply.
		/// </returns>
		[DispId(63505)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		MailItem ReplyAll();

		/// <summary>
		/// Sends the e-mail message.
		/// </summary>
		[DispId(61557)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Send();

		/// <summary>
		/// Displays the Show Categories dialog box, which allows you to select categories that correspond to the subject of the item.
		/// </summary>
		[DispId(64011)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ShowCategoriesDialog();

		/// <summary>
		/// Appends contact information based on the Electronic Business Card (EBC) associated with the specified <see cref="T:Microsoft.Office.Interop.Outlook.ContactItem"/> object to the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object.
		/// </summary>
		/// <param name="contact">The contact item from which to obtain the business card information.</param>
		[DispId(64406)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddBusinessCard([MarshalAs(UnmanagedType.Interface), In] ContactItem contact);

		/// <summary>
		/// Marks a <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object as a task and assigns a task interval for the object.
		/// </summary>
		/// <param name="MarkInterval">The task interval for the MailItem.</param>
		[DispId(64510)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void MarkAsTask([In] OlMarkInterval MarkInterval);

		/// <summary>
		/// Clears the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object as a task.
		/// </summary>
		[DispId(64521)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ClearTaskFlag();

		/// <summary>
		/// Obtains a <see cref="T:Microsoft.Office.Interop.Outlook.Conversation"/> object that represents the conversation to which this item belongs.
		/// </summary>
		/// 
		/// <returns>
		/// Returns a Conversation object that represents the conversation to which this item belongs.
		/// </returns>
		[DispId(64596)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Conversation GetConversation();

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Application"/>  object that represents the parent Outlook application for the  object. Read-only.
		/// </summary>
		[DispId(61440)]
		Application Application { [DispId(61440), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlObjectClass"/> constant indicating the object's class. Read-only.
		/// </summary>
		[DispId(61450)]
		OlObjectClass Class { [DispId(61450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.NameSpace"/>  object for the current session. Read-only.
		/// </summary>
		[DispId(61451)]
		NameSpace Session { [DispId(61451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the parent Object of the specified object. Read-only.
		/// </summary>
		[DispId(61441)]
		object Parent { [DispId(61441), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Actions"/>  collection that represents all the available actions for the item. Read-only.
		/// </summary>
		[DispId(63511)]
		Actions Actions { [DispId(63511), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Attachments"/>  object that represents all the attachments for the specified item. Read-only.
		/// </summary>
		[DispId(63509)]
		Attachments Attachments { [DispId(63509), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the billing information associated with the Outlook item. Read/write.
		/// </summary>
		[DispId(34101)]
		string BillingInformation { [DispId(34101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the clear-text body of the Outlook item. Read/write.
		/// </summary>
		[DispId(37120)]
		string Body { [DispId(37120), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(37120), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the categories assigned to the Outlook item. Read/write.
		/// </summary>
		[DispId(36865)]
		string Categories { [DispId(36865), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(36865), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the names of the companies associated with the Outlook item. Read/write.
		/// </summary>
		[DispId(34107)]
		string Companies { [DispId(34107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) representing the index of the conversation thread of the Outlook item. Read-only.
		/// </summary>
		[DispId(64192)]
		string ConversationIndex { [DispId(64192), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the topic of the conversation thread of the Outlook item. Read-only.
		/// </summary>
		[DispId(112)]
		string ConversationTopic { [DispId(112), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a DateTime indicating the creation time for the Outlook item. Read-only.
		/// </summary>
		[DispId(12295)]
		DateTime CreationTime { [DispId(12295), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the unique Entry ID of the object.  Read-only.
		/// </summary>
		[DispId(61470)]
		string EntryID { [DispId(61470), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.FormDescription"/>  object that represents the form description for the specified Outlook item. Read-only.
		/// </summary>
		[DispId(61589)]
		FormDescription FormDescription { [DispId(61589), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.Inspector"/>  object that represents an inspector initialized to contain the specified item. Read-only.
		/// </summary>
		[DispId(61502)]
		Inspector GetInspector { [DispId(61502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an <see cref="T:Microsoft.Office.Interop.Outlook.OlImportance"/> constant indicating the relative importance level for the Outlook item. Read/write.
		/// </summary>
		[DispId(23)]
		OlImportance Importance { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a DateTime specifying the date and time that the Outlook item was last modified.  Read-only.
		/// </summary>
		[DispId(12296)]
		DateTime LastModificationTime { [DispId(12296), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(61696)]
		object MAPIOBJECT { [TypeLibFunc(64), DispId(61696), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the message class for the Outlook item. Read/write.
		/// </summary>
		[DispId(26)]
		string MessageClass { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the mileage for an item. Read/write.
		/// </summary>
		[DispId(34100)]
		string Mileage { [DispId(34100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that is True to not age the Outlook item. Read/write.
		/// </summary>
		[DispId(34062)]
		bool NoAging { [DispId(34062), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34062), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns an Integer (int in C#) value representing the build number of the Outlook application for an Outlook item. Read-only.
		/// </summary>
		[DispId(34130)]
		int OutlookInternalVersion { [DispId(34130), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) indicating the major and minor version number of the Outlook application for an Outlook item. Read-only.
		/// </summary>
		[DispId(34132)]
		string OutlookVersion { [DispId(34132), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) value that is True if the Outlook item has not been modified since the last save. Read-only.
		/// </summary>
		[DispId(61603)]
		bool Saved { [DispId(61603), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a constant in the <see cref="T:Microsoft.Office.Interop.Outlook.OlSensitivity"/> enumeration indicating the sensitivity for the Outlook item. Read/write.
		/// </summary>
		[DispId(54)]
		OlSensitivity Sensitivity { [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns an Integer (int in C#) value indicating the size (in bytes) of the Outlook item. Read-only.
		/// </summary>
		[DispId(3592)]
		int Size { [DispId(3592), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a String (string in C#) indicating the subject for the Outlook item. Read/write.
		/// </summary>
		[DispId(55)]
		string Subject { [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that is True if the Outlook item has not been opened (read). Read/write.
		/// </summary>
		[DispId(61468)]
		bool UnRead { [DispId(61468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(61468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns the <see cref="T:Microsoft.Office.Interop.Outlook.UserProperties"/>  collection that represents all the user properties for the Outlook item. Read-only.
		/// </summary>
		[DispId(63510)]
		UserProperties UserProperties { [DispId(63510), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) that is True if the mail message can be forwarded. Read/write.
		/// </summary>
		[DispId(2)]
		bool AlternateRecipientAllowed { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// A Boolean (bool in C#) value that returns True if the item was automatically forwarded. Read/write.
		/// </summary>
		[DispId(5)]
		bool AutoForwarded { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) representing the display list of blind carbon copy (BCC) names for a <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/>. Read/write.
		/// </summary>
		[DispId(3586)]
		string BCC { [DispId(3586), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(3586), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) representing the display list of carbon copy (CC) names for a <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/>. Read/write.
		/// </summary>
		[DispId(3587)]
		string CC { [DispId(3587), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(3587), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a DateTime indicating the date and time the mail message is to be delivered.  Read/write.
		/// </summary>
		[DispId(15)]
		DateTime DeferredDeliveryTime { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that is True if a copy of the mail message is not saved upon being sent, and False if a copy is saved. Read/write.
		/// </summary>
		[DispId(3585)]
		bool DeleteAfterSubmit { [DispId(3585), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(3585), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a DateTime indicating the date and time at which the item becomes invalid and can be deleted. Read/write.
		/// </summary>
		[DispId(21)]
		DateTime ExpiryTime { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(48)]
		DateTime FlagDueBy { [TypeLibFunc(64), DispId(48), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(48), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) that indicates the requested action for a mail item. Read/write.
		/// </summary>
		[DispId(34096)]
		string FlagRequest { [DispId(34096), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34096), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(4240)]
		OlFlagStatus FlagStatus { [TypeLibFunc(64), DispId(4240), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(4240), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) representing the HTML body of the specified item.  Read/write.
		/// </summary>
		[DispId(62468)]
		string HTMLBody { [DispId(62468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(62468), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that determines whether the originator of the meeting item or mail message will receive a delivery report. Read/write.
		/// </summary>
		[DispId(35)]
		bool OriginatorDeliveryReportRequested { [DispId(35), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(35), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean (bool in C#) value that indicates True if a read receipt has been requested by the sender.
		/// </summary>
		[DispId(41)]
		bool ReadReceiptRequested { [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) representing the <see cref="P:Microsoft.Office.Interop.Outlook.Recipient.EntryID"/>  for the true recipient as set by the transport provider delivering the mail message. Read-only.
		/// </summary>
		[DispId(63)]
		string ReceivedByEntryID { [DispId(63), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the display name of the true recipient for the mail message. Read-only.
		/// </summary>
		[DispId(64)]
		string ReceivedByName { [DispId(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the <see cref="P:Microsoft.Office.Interop.Outlook.Recipient.EntryID"/>  of the user delegated to represent the recipient for the mail message. Read-only.
		/// </summary>
		[DispId(67)]
		string ReceivedOnBehalfOfEntryID { [DispId(67), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) representing the display name of the user delegated to represent the recipient for the mail message. Read-only.
		/// </summary>
		[DispId(68)]
		string ReceivedOnBehalfOfName { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a DateTime indicating the date and time at which the item was received. Read-only.
		/// </summary>
		[DispId(3590)]
		DateTime ReceivedTime { [DispId(3590), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) that indicates True if the recipient cannot forward the mail message. Read/write.
		/// </summary>
		[DispId(43)]
		bool RecipientReassignmentProhibited { [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Recipients"/>  collection that represents all the recipients for the Outlook item. Read-only.
		/// </summary>
		[DispId(63508)]
		Recipients Recipients { [DispId(63508), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that is True if the reminder overrides the default reminder behavior for the item. Read/write.
		/// </summary>
		[DispId(34076)]
		bool ReminderOverrideDefault { [DispId(34076), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34076), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that is True if the reminder should play a sound when it occurs for this item. Read/write.
		/// </summary>
		[DispId(34078)]
		bool ReminderPlaySound { [DispId(34078), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34078), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a Boolean (bool in C#) value that is True if a reminder has been set for this item. Read/write.
		/// </summary>
		[DispId(34051)]
		bool ReminderSet { [DispId(34051), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34051), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) indicating the path and file name of the sound file to play when the reminder occurs for the Outlook item. Read/write.
		/// </summary>
		[DispId(34079)]
		string ReminderSoundFile { [DispId(34079), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34079), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a DateTime indicating the date and time at which the reminder should occur for the specified item. Read/write.
		/// </summary>
		[DispId(34050)]
		DateTime ReminderTime { [DispId(34050), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34050), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an <see cref="T:Microsoft.Office.Interop.Outlook.OlRemoteStatus"/> constant specifying the remote status of the mail message. Read/write.
		/// </summary>
		[DispId(34065)]
		OlRemoteStatus RemoteStatus { [DispId(34065), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34065), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a semicolon-delimited String (string in C#) list of reply recipients for the mail message.  Read-only.
		/// </summary>
		[DispId(80)]
		string ReplyRecipientNames { [DispId(80), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Recipients"/>  collection that represents all the reply recipient objects for the Outlook item. Read-only.
		/// </summary>
		[DispId(61459)]
		Recipients ReplyRecipients { [DispId(61459), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a <see cref="T:Microsoft.Office.Interop.Outlook.Folder"/>  object that represents the folder in which a copy of the e-mail message will be saved after being sent. Read/write.
		/// </summary>
		[DispId(62465)]
		MAPIFolder SaveSentMessageFolder { [DispId(62465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(62465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) indicating the display name of the sender for the Outlook item.  Read-only.
		/// </summary>
		[DispId(3098)]
		string SenderName { [DispId(3098), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a Boolean (bool in C#) value that indicates if a message has been sent. Read-only.
		/// </summary>
		[DispId(62466)]
		bool Sent { [DispId(62466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a DateTime indicating the date and time on which the Outlook item was sent. Read-only.
		/// </summary>
		[DispId(57)]
		DateTime SentOn { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) indicating the display name for the intended sender of the mail message. Read/write.
		/// </summary>
		[DispId(66)]
		string SentOnBehalfOfName { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean (bool in C#) value that is True if the item has been submitted. Read-only.
		/// </summary>
		[DispId(62467)]
		bool Submitted { [DispId(62467), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets a semicolon-delimited String (string in C#) list of display names for the To recipients for the Outlook item. Read/write.
		/// </summary>
		[DispId(3588)]
		string To { [DispId(3588), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(3588), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) specifying a delimited string containing the voting options for the mail message. Read/write.
		/// </summary>
		[DispId(61467)]
		string VotingOptions { [DispId(61467), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(61467), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) specifying the voting response for the mail message. Read/write.
		/// </summary>
		[DispId(34084)]
		string VotingResponse { [DispId(34084), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34084), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.Links"/> collection that represents the contacts to which the item is linked. Read-only.
		/// </summary>
		[DispId(62469)]
		Links Links { [DispId(62469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns an <see cref="T:Microsoft.Office.Interop.Outlook.ItemProperties"/> collection that represents all standard and user-defined properties associated with the Outlook item. Read-only.
		/// </summary>
		[DispId(64009)]
		ItemProperties ItemProperties { [DispId(64009), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an <see cref="T:Microsoft.Office.Interop.Outlook.OlBodyFormat"/> constant indicating the format of the body text.  Read/write.
		/// </summary>
		[DispId(64073)]
		OlBodyFormat BodyFormat { [DispId(64073), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64073), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a constant that belongs to the <see cref="T:Microsoft.Office.Interop.Outlook.OlDownloadState"/> enumeration indicating the download state of the item. Read-only.
		/// </summary>
		[DispId(64077)]
		OlDownloadState DownloadState { [DispId(64077), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an Integer (int in C#) value that determines the Internet code page used by the item. Read/write.
		/// </summary>
		[DispId(16350)]
		int InternetCodepage { [DispId(16350), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(16350), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets an <see cref="T:Microsoft.Office.Interop.Outlook.OlRemoteStatus"/>  constant that determines the status of an item once it is received by a remote user. Read/write.
		/// </summary>
		[DispId(34161)]
		OlRemoteStatus MarkForDownload { [DispId(34161), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34161), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean (bool in C#) that determines if the item is in conflict. Read-only.
		/// </summary>
		[DispId(64164)]
		bool IsConflict { [DispId(64164), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(34203)]
		bool IsIPFax { [TypeLibFunc(64), DispId(34203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(34203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(64204)]
		OlFlagIcon FlagIcon { [DispId(64204), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64204), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(64176)]
		bool HasCoverSheet { [DispId(64176), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [TypeLibFunc(64), DispId(64176), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean (bool in C#) that determines if the item is a winner of an automatic conflict resolution. Read-only.
		/// </summary>
		[DispId(64186)]
		bool AutoResolvedWinner { [DispId(64186), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Return the <see cref="T:Microsoft.Office.Interop.Outlook.Conflicts"/> object that represents the items that are in conflict for any Outlook item object.  Read-only.
		/// </summary>
		[DispId(64187)]
		Conflicts Conflicts { [DispId(64187), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) that represents the e-mail address of the sender of the Outlook item.   Read-only.
		/// </summary>
		[DispId(3103)]
		string SenderEmailAddress { [DispId(3103), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) that represents the type of entry for the e-mail address of the sender of the Outlook item, such as 'SMTP' for Internet address, 'EX' for a Microsoft Exchange server address, etc. Read-only.
		/// </summary>
		[DispId(3102)]
		string SenderEmailType { [DispId(3102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
		/// </summary>
		[DispId(64196)]
		bool EnableSharedAttachments { [TypeLibFunc(64), DispId(64196), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64196), TypeLibFunc(64), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Sets or returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlPermission"/> constant that determines the permissions the recipients will have  on the e-mail item. Read/write.
		/// </summary>
		[DispId(64198)]
		OlPermission Permission { [DispId(64198), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64198), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Sets or returns an <see cref="T:Microsoft.Office.Interop.Outlook.OlPermissionService"/> constant that determines the permission service that will be used when sending a message protected by Information Rights Management (IRM). Read/write.
		/// </summary>
		[DispId(64203)]
		OlPermissionService PermissionService { [DispId(64203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a <see cref="T:Microsoft.Office.Interop.Outlook.PropertyAccessor"/> object that supports creating, getting, setting, and deleting properties of the parent <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object. Read-only.
		/// </summary>
		[DispId(64253)]
		PropertyAccessor PropertyAccessor { [DispId(64253), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an <see cref="T:Microsoft.Office.Interop.Outlook.Account"/> object that represents the account under which the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> is to be sent. Read/write.
		/// </summary>
		[DispId(64209)]
		Account SendUsingAccount { [DispId(64209), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64209), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) value that represents the subject of the task for the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object. Read/write.
		/// </summary>
		[DispId(64543)]
		string TaskSubject { [DispId(64543), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64543), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a DateTime value that represents the due date of the task for this <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/>. Read/write.
		/// </summary>
		[DispId(33029)]
		DateTime TaskDueDate { [DispId(33029), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(33029), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a DateTime value that represents the start date of the task for this <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object. Read/write.
		/// </summary>
		[DispId(33028)]
		DateTime TaskStartDate { [DispId(33028), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(33028), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a DateTime value that represents the completion date of the task for this <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/>. Read/write.
		/// </summary>
		[DispId(33039)]
		DateTime TaskCompletedDate { [DispId(33039), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(33039), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a DateTime value that represents the ordinal value of the task for the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/>. Read/write.
		/// </summary>
		[DispId(34208)]
		DateTime ToDoTaskOrdinal { [DispId(34208), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(34208), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a Boolean (bool in C#) value that indicates whether the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> is marked as a task. Read-only.
		/// </summary>
		[DispId(64522)]
		bool IsMarkedAsTask { [DispId(64522), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a String (string in C#) that uniquely identifies a <see cref="T:Microsoft.Office.Interop.Outlook.Conversation"/> object that the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object belongs to. Read-only.
		/// </summary>
		[DispId(64629)]
		string ConversationID { [DispId(64629), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns or sets an <see cref="T:Microsoft.Office.Interop.Outlook.AddressEntry"/> object that corresponds to the user of the account from which the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> is sent. Read/write.
		/// </summary>
		[DispId(64635)]
		AddressEntry Sender { [DispId(64635), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64635), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a String (string in C#) value that represents the GUID of the template file to apply to the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> in order to specify Information Rights Management (IRM) permissions. Read/write.
		/// </summary>
		[DispId(64637)]
		string PermissionTemplateGuid { [DispId(64637), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64637), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns or sets a byte array that represents the body of the Microsoft Outlook item in Rich Text Format. Read/write.
		/// </summary>
		[DispId(64644)]
		object RTFBody { [DispId(64644), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; [DispId(64644), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		set; }

		/// <summary>
		/// Returns a String (string in C#) that specifies the name of the retention policy. Read-only.
		/// </summary>
		[DispId(64651)]
		string RetentionPolicyName { [DispId(64651), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }

		/// <summary>
		/// Returns a <see cref="T:System.DateTime"/> value that specifies the date when the <see cref="T:Microsoft.Office.Interop.Outlook.MailItem"/> object expires, after which the Messaging Records Management (MRM) Assistant will delete the item. Read-only.
		/// </summary>
		[DispId(64650)]
		DateTime RetentionExpirationDate { [DispId(64650), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get; }
	}
}
