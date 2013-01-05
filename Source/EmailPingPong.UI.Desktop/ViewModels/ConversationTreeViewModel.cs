using System.Collections.ObjectModel;
using System.Linq;
using EmailPingPong.Core.Repositories;

namespace EmailPingPong.UI.Desktop.ViewModels
{
	public class ConversationTreeViewModel : ViewModelBase
	{
		private readonly IConversationRepository _conversationRepository;
		private ReadOnlyCollection<TreeViewItemViewModel> _items;

		public ConversationTreeViewModel(IConversationRepository conversationRepository)
		{
			_conversationRepository = conversationRepository;
			Bind();
		}

		private void Bind()
		{
			Items = new ReadOnlyCollection<TreeViewItemViewModel>(
				_conversationRepository.GetAll()
									   .Select(c => new ConversationViewModel(null, c))
									   .Cast<TreeViewItemViewModel>()
									   .ToList());
		}

		public ReadOnlyCollection<TreeViewItemViewModel> Items
		{
			get { return _items; }
			set
			{
				_items = value;
				OnPropertyChanged("Items");
			}
		}
	}
}