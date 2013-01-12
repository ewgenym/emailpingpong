using System.Collections.Generic;
using System.Linq;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.UI
{
	public class TreeViewItemsStateTests
	{
		[Fact]
		public void should_save_simple_tree_view_items_state()
		{
			// arrange
			var statePersister = new TreeViewItemsState<string>();
			var items = new List<TreeViewItemViewModel>
				{
					new CommentViewModel(null, Create.Comment().Build())
						{
							IsExpanded = true
						},
				};

			// act
			statePersister.SaveState("key1", items);

			items[0].IsExpanded = false;

			statePersister.SaveState("key2", items);

			// assert
			items[0].IsExpanded.Should().BeFalse();
			statePersister.RestoreState("key1", items);
			items[0].IsExpanded.Should().BeTrue();
		}

		[Fact]
		public void should_save_state_for_tree_view_items_with_childs()
		{
			// arrange
			var statePersister = new TreeViewItemsState<string>();
			var items = new List<TreeViewItemViewModel>
				{
					new CommentViewModel(null, Create.Comment()
					                                 .WithAnswer(
						                                 Create.Comment()
						                                       .Build())
					                                 .Build()),
				};
			items[0].Childs.ElementAt(0).IsExpanded = true;

			// act
			statePersister.SaveState("key1", items);

			items[0].Childs.ElementAt(0).IsExpanded = false;

			statePersister.SaveState("key2", items);

			// assert
			items[0].Childs.ElementAt(0).IsExpanded.Should().BeFalse();
			statePersister.RestoreState("key1", items);
			items[0].Childs.ElementAt(0).IsExpanded.Should().BeTrue();
		}
	}
}