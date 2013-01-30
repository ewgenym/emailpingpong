using EmailPingPong.Core.Model;
using EmailPingPong.Tests.Builders;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

namespace EmailPingPong.Tests.ViewModel
{
	public class ConversationViewCriteriaTests
	{
		[Fact]
		public void should_report_email_folders_are_equal()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("1", "1", "1");

			// act
			var result = folder1 == folder2;

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_report_email_folders_are_not_equal_with_storeid()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("2", "1", "1");

			// act
			var result = folder1 == folder2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_report_email_folders_are_not_equal_with_folderid()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("1", "2", "1");

			// act
			var result = folder1 == folder2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_report_email_folders_are_not_equal_with_folder_name()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("1", "1", "2");

			// act
			var result = folder1 == folder2;

			// assert
			result.Should().BeFalse();
		}
		
		[Fact]
		public void should_report_conversation_view_criteria_equals_by_folders()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("1", "1", "1");

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "1", null, folder1);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "1", null, folder2);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_report_empty_conversation_view_criteria_are_equal()
		{
			// arrange
			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, null, null, null);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, null, null, null);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeTrue();
		}
	}
}