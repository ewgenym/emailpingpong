using System.Threading.Tasks;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;

namespace EmailPingPong.Tests.ViewModel
{
	public class FolderViewModelTests : ConversationTreeViewTestsBase
	{
		public async Task should_group_conversations_by_folder()
		{
			// act
			ViewModel.GroupBy = GroupBy.Folder;
			await ViewModel.BindData();

			// assert
			ViewModel.Items[0].Should().BeAssignableTo<FolderViewModel>();
		}
	}
}