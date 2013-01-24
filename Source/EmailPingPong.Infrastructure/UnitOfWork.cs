using System;
using EmailPingPong.Infrastructure.Repositories;

namespace EmailPingPong.Infrastructure
{
	public class UnitOfWork : IDisposable
	{
		private bool _isDisposed;
		private readonly ConversationContext _context;

		public UnitOfWork(ConversationContext context)
		{
			_context = context;
		}

		public void Dispose()
		{
			if (!_isDisposed)
				Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			_isDisposed = true;
			if (disposing)
			{
				Commit();
			}
		}

		private void Commit()
		{
			_context.SaveChanges();
		}
	}
}
