using System;
using EmailPingPong.Core.Model;
using EmailPingPong.UI.Desktop.ViewModels;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.ViewModel
{
	public class CommentViewModelTests
	{
		[Fact]
		public void comment_view_models_should_be_equal_when_underlying_comments_are_equal()
		{
			// arrange
			var guid = Guid.NewGuid();
			var comment1 = new Comment
				{
					Id = 1,
					Guid = guid
				};
			var commentView1 = new CommentViewModel(null, comment1);


			var comment2 = new Comment
				{
					Id = 2,
					Guid = guid
				};
			var commentView2 = new CommentViewModel(null, comment2);

			// act
			var result = commentView1 == commentView2;

			// assert
			result.Should().BeTrue();
		}
	}
}