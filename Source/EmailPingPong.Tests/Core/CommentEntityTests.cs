using System;
using EmailPingPong.Core.Model;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Core
{
	public class CommentEntityTests
	{
		[Fact]
		public void comments_with_the_same_guid_but_differ_ids_should_be_equal()
		{
			// arrange
			var guid = Guid.NewGuid();
			var comment1 = new Comment
				{
					Id = 1,
					Guid = guid
				};
			var comment2 = new Comment
				{
					Id = 2,
					Guid = guid
				};

			// act
			var result = comment1 == comment2;

			// assert
			result.Should().BeTrue();
		}
	}
}