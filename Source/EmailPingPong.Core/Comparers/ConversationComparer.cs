using EmailPingPong.Core.Model;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.Core.Comparers
{
	public class ConversationComparer : EntityComparer<Conversation>
	{
		protected override int GetEntityHashCode(Conversation entity)
		{
			return entity.ConversationId.Return(s=>s.GetHashCode());
		}

		protected override bool EntitiesEqual(Conversation x, Conversation y)
		{
			return x.ConversationId == y.ConversationId;
		}
	}
}