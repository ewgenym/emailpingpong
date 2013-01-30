using EmailPingPong.Core.Repositories;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.UI.Desktop.ViewModels;
using Microsoft.Practices.Prism.Events;
using NSubstitute;

namespace EmailPingPong.Tests.ViewModel
{
	public class ConversationTreeViewTestsBase
	{
		protected readonly ConversationTreeViewModel ViewModel;
		protected readonly IConversationRepository ConversationRepository;
		protected readonly IEventAggregator EventAggregator;
		protected readonly MailFolderSwitchedEvent MailFolderSwitchedEvent;
		protected readonly EmailItemSwitchedEvent EmailItemSwitchedEvent;
		protected readonly EmailItemChangedEvent EmailItemChangedEvent;
		protected readonly ConversationMergedEvent ConversationMergedEvent;
		protected readonly ConversationRemovedEvent ConversationRemovedEvent;

		public ConversationTreeViewTestsBase()
		{
			ConversationRepository = Substitute.For<IConversationRepository>();

			EventAggregator = Substitute.For<IEventAggregator>();

			MailFolderSwitchedEvent = new MailFolderSwitchedEvent();
			EmailItemSwitchedEvent = new EmailItemSwitchedEvent();
			EmailItemChangedEvent = new EmailItemChangedEvent();
			ConversationMergedEvent = new ConversationMergedEvent();
			ConversationRemovedEvent = new ConversationRemovedEvent();

			EventAggregator.GetEvent<MailFolderSwitchedEvent>().Returns(MailFolderSwitchedEvent);
			EventAggregator.GetEvent<EmailItemSwitchedEvent>().Returns(EmailItemSwitchedEvent);
			EventAggregator.GetEvent<EmailItemChangedEvent>().Returns(EmailItemChangedEvent);
			EventAggregator.GetEvent<ConversationMergedEvent>().Returns(ConversationMergedEvent);
			EventAggregator.GetEvent<ConversationRemovedEvent>().Returns(ConversationRemovedEvent);
			
			var treeViewItemsBinder = new ConversationTreeItemsBinder(ConversationRepository);

			ViewModel = new ConversationTreeViewModel(treeViewItemsBinder, EventAggregator);
		}
	}
}