using EmailPingPong.Core.Repositories;
using EmailPingPong.Infrastructure.Events;
using EmailPingPong.UI.Desktop.ViewModels;
using Microsoft.Practices.Prism.Events;
using NSubstitute;

namespace EmailPingPong.Tests.ViewModel
{
	public class ConversationTreeViewTestsBase
	{
		protected ConversationTreeViewModel _viewModel;
		protected IConversationRepository _conversationRepository;
		protected IEventAggregator _eventAggregator;
		protected MailFolderSwitchedEvent _mailFolderSwitchedEvent;
		protected EmailItemSwitchedEvent _emailItemSwitchedEvent;
		protected EmailItemChangedEvent _emailItemChangedEvent;
		protected ConversationMergedEvent ConversationMergedEvent;

		public ConversationTreeViewTestsBase()
		{
			_conversationRepository = Substitute.For<IConversationRepository>();

			_eventAggregator = Substitute.For<IEventAggregator>();

			_mailFolderSwitchedEvent = new MailFolderSwitchedEvent();
			_emailItemSwitchedEvent = new EmailItemSwitchedEvent();
			_emailItemChangedEvent = new EmailItemChangedEvent();
			ConversationMergedEvent = new ConversationMergedEvent();

			_eventAggregator.GetEvent<MailFolderSwitchedEvent>().Returns(_mailFolderSwitchedEvent);
			_eventAggregator.GetEvent<EmailItemSwitchedEvent>().Returns(_emailItemSwitchedEvent);
			_eventAggregator.GetEvent<EmailItemChangedEvent>().Returns(_emailItemChangedEvent);
			_eventAggregator.GetEvent<ConversationMergedEvent>().Returns(ConversationMergedEvent);

			var treeViewItemsBinder = new ConversationTreeItemsBinder(_conversationRepository);

			_viewModel = new ConversationTreeViewModel(treeViewItemsBinder, _eventAggregator);
		}
	}
}