using EmailPingPong.Core.Comparers;
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
		public void should_report_empty_email_items_are_equal()
		{
			// arrange
			var email1 = new EmailItem();
			var email2 = new EmailItem();

			// act
			var result = new EmailItemComparer().Equals(email1, email2);

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_report_email_items_are_equal()
		{
			//TODO: remove this test. Duplicate
			// arrange
			var email1 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("1")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			var email2 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("1")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			// act
			var result = new EmailItemComparer().Equals(email1, email2);

			// assert
			result.Should().BeTrue();

		}

		[Fact]
		public void should_report_email_items_are_not_equal_by_account_id()
		{
			// arrange
			var email1 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("1")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			var email2 = Create.EmailItem()
			                   .WithAccountId("2")
			                   .WithItemId("1")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			// act
			var result = email1 == email2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_report_email_items_are_not_equal_by_item_id()
		{
			// arrange
			var email1 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("1")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			var email2 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("2")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			// act
			var result = email1 == email2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_report_email_items_are_not_equal_by_folder()
		{
			// arrange
			var email1 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("1")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			var email2 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("2")
			                   .WithFolder("2", "2", "2")
			                   .Build();

			// act
			var result = email1 == email2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_report_conversation_view_criteria_equals_by_folders()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("1", "1", "1");

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "1", null, folder1, false);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "1", null, folder2, false);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_report_empty_conversation_view_criteria_are_equal()
		{
			// arrange
			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, null, null, null, false);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, null, null, null, false);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_not_take_into_account_current_emails_if_search_in_higher_than_current_email()
		{
			// arrange
			var email1 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("1")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			var email2 = Create.EmailItem()
			                   .WithAccountId("1")
			                   .WithItemId("2")
			                   .WithFolder("1", "1", "1")
			                   .Build();

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentFolder, "account@mail.ru", new[] { email1 }, email1.Folder, false);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentFolder, "account@mail.ru", new[] { email2 }, email2.Folder, false);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_compare_current_emails_if_search_in_current_email()
		{
			// arrange
			var email1 = Create.EmailItem()
							   .WithAccountId("1")
							   .WithItemId("1")
							   .WithFolder("1", "1", "1")
							   .Build();

			var email2 = Create.EmailItem()
							   .WithAccountId("1")
							   .WithItemId("2")
							   .WithFolder("1", "1", "1")
							   .Build();

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "account@mail.ru", new[] { email1 }, email1.Folder, false);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "account@mail.ru", new[] { email2 }, email2.Folder, false);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_not_take_into_account_current_folder_if_search_in_higher_than_current_folder()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("2", "2", "2");

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "account@mail.ru", null, folder1, false);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.AllFolders, "account@mail.ru", null, folder2, false);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_compare_current_folder_if_search_in_current_folder()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("2", "2", "2");

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentFolder, "account@mail.ru", null, folder1, false);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentFolder, "account@mail.ru", null, folder2, false);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_compare_current_folder_if_search_in_current_email()
		{
			// arrange
			var folder1 = new EmailFolder("1", "1", "1");
			var folder2 = new EmailFolder("2", "2", "2");

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "account@mail.ru", null, folder1, false);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "account@mail.ru", null, folder2, false);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeFalse();
		}

		[Fact]
		public void should_not_compare_show_closed_conversations()
		{
			// arrange
			const bool showClosedTrue = true;
			const bool showClosedFalse = false;

			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "account@mail.ru", null, new EmailFolder("1", "1", "1"), showClosedTrue);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, "account@mail.ru", null, new EmailFolder("1", "1", "1"), showClosedFalse);

			// act
			var result = criteria1 == criteria2;

			// assert
			result.Should().BeTrue();
		}

		[Fact]
		public void should_report_equal_when_account_id_is_null()
		{
			var criteria1 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, null, null, new EmailFolder("1", "1", "1"), true);
			var criteria2 = new ConversationViewCriteria(GroupBy.None, SearchIn.CurrentEmail, null, null, new EmailFolder("1", "1", "1"), true);

			var result = criteria1 == criteria2;

			result.Should().BeTrue();

		}
	}
}