using System;
using System.Linq;
using EmailPingPong.Core.Model;
using EmailPingPong.Core.Repositories;
using EmailPingPong.Core.Utils;

namespace EmailPingPong.Core.Services.Implementation
{
	public class MergeConversationService : IMergeConversationService
	{
		private readonly IRepository<EmailItem> _emailItemRepository;
		private readonly IRepository<Comment> _commentsRepository;

		public MergeConversationService(IRepository<EmailItem> emailItemRepository, IRepository<Comment> commentsRepository)
		{
			_emailItemRepository = emailItemRepository;
			_commentsRepository = commentsRepository;
		}

		public void Merge(Conversation original, Conversation proposed)
		{
			if (string.Compare(original.ConversationId, proposed.ConversationId, StringComparison.InvariantCultureIgnoreCase) != 0)
			{
				throw new InvalidOperationException("Can't merge conversations with different id's");
			}

			if (!proposed.IsNewerThanOrSame(original))
			{
				return;
			}

			if (original.NewestEmail.Return(e=>e.SameAs(proposed.NewestEmail)))
			{
				original.UpdateEmail(proposed.NewestEmail);
			}
			else if (proposed.NewestEmail != null)
			{
				original.AddEmail(proposed.NewestEmail);
				_emailItemRepository.Add(proposed.NewestEmail);
			}

			MergeComments(original, proposed);
		}

		private void MergeComments(Conversation original, Conversation proposed)
		{
			// Update
			var originalComments = new FlatCommentsIterator(original.Comments).ToList();
			var proposedComments = new FlatCommentsIterator(proposed.Comments).ToList();

			// save original emails for existing comments
			var commentsToUpdate = proposedComments.Join(originalComments, first => first.Guid, second => second.Guid,
													   (first, second) => new { First = first, Second = second });
			commentsToUpdate.ForEach(t => { t.First.OriginalEmail = t.Second.OriginalEmail; });
			
			// save newwest email (attached) for new comments
			var newComments = proposedComments.Where(p => originalComments.All(o => o.Guid != p.Guid));
			newComments.ForEach(c => c.OriginalEmail = original.NewestEmail);

			// Delete
			originalComments.ForEach(c => _commentsRepository.Remove(c));
			original.Comments.Clear();

			// Add
			proposed.Comments.ForEach(original.AddComment);
			proposedComments.ForEach(c => _commentsRepository.Add(c));
		}
	}
}