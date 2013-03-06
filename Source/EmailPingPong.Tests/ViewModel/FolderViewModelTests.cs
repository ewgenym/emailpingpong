using System.Threading.Tasks;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.ViewModel
{
	public class FolderViewModelTests : ConversationTreeViewTestsBase
	{
		[Fact]
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