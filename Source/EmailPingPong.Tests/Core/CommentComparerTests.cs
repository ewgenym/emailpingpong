using System;
using EmailPingPong.Core.Comparers;
using EmailPingPong.Core.Model;
using FluentAssertions;
using Xunit;

namespace EmailPingPong.Tests.Core
{
	public class CommentComparerTests
	{
		[Fact]
		public void comments_with_the_same_guid_but_differ_ids_should_be_equal()
		{
			// arrange
			var guid1 = new Guid("{7B190E08-AE41-4A27-9E58-6995A4BD2E65}");
			var guid2 = new Guid("{7B190E08-AE41-4A27-9E58-6995A4BD2E65}");
			var comment1 = new Comment
				{
					Id = 1,
					Guid = guid1
				};
			var comment2 = new Comment
				{
					Id = 2,
					Guid = guid2
				};

			var commentComparer = new CommentComparer();
			
			// act
			var result = commentComparer.Equals(comment1, comment2); ;

			// assert
			result.Should().BeTrue();
		}
	}
}