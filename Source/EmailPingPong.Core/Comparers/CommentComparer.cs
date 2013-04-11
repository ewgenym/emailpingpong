using EmailPingPong.Core.Model;

namespace EmailPingPong.Core.Comparers
{
	public class CommentComparer : EntityComparer<Comment>
	{
		protected override int GetEntityHashCode(Comment entity)
		{
			return entity.Guid.GetHashCode();
		}

		protected override bool EntitiesEqual(Comment x, Comment y)
		{
			return x.Guid == y.Guid;
		}
	}
}