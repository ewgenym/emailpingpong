using System;
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
													 .WithId(new Guid("{D3EA3D93-B883-447A-8611-1FABCE521E86}"))
					                                 .WithAnswer(
						                                 Create.Comment()
															   .WithId(new Guid("{D0B486BC-0C52-4A7B-A820-B1EF1C560F59}"))
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

		[Fact]
		public void should_save_and_restore_state_for_comments_view_model()
		{
			var state = new TreeViewItemsState<string>();
			var viewModel1 = new CommentViewModel(null, Create.Comment()
			                                            .WithId(new Guid("(8246E99C-8E47-443A-B5F4-9BD35441BB05)"))
			                                            .Build())
				{
					IsExpanded = true, 
					IsSelected = true
				};

			state.SaveState("1", new[] { viewModel1 });

			var viewModel2 = new CommentViewModel(null, Create.Comment()
														.WithId(new Guid("(8246E99C-8E47-443A-B5F4-9BD35441BB05)"))
														.Build())
			{
				IsExpanded = false,
				IsSelected = false
			};

			state.RestoreState("1", new[] { viewModel2 });

			Console.Out.WriteLine("viewModel1 == viewModel2 = {0}", viewModel1 == viewModel2);
			viewModel2.IsSelected.Should().BeTrue();
			viewModel2.IsExpanded.Should().BeTrue();
		}
	}
}