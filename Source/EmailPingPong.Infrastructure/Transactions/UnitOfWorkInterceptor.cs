using System.Linq;
using Castle.Core;
using Castle.DynamicProxy;
using Castle.MicroKernel.Proxy;
using EmailPingPong.Core.Commands;
using EmailPingPong.Infrastructure.Repositories;

namespace EmailPingPong.Infrastructure.Transactions
{
	public class UnitOfWorkInterceptor : IInterceptor
	{
		private readonly ConversationContext _context;

		public UnitOfWorkInterceptor(ConversationContext context)
		{
			_context = context;
		}

		public void Intercept(IInvocation invocation)
		{
			using (new UnitOfWork(_context))
			{
				invocation.Proceed();
			}
		}
	}

	public class ConsumerUnitOfWorkInterceptorSelector : IModelInterceptorsSelector
	{
		public bool HasInterceptors(ComponentModel model)
		{
			return model.Services.Any(service => service != typeof(UnitOfWorkInterceptor) 
				&& service.IsGenericType 
				&& service.GetGenericTypeDefinition() == typeof (ICommandHandler<>));
		}

		public InterceptorReference[] SelectInterceptors(ComponentModel model, InterceptorReference[] interceptors)
		{
			if (HasInterceptors(model))
			{
				return new[]
					{
						InterceptorReference.ForType<UnitOfWorkInterceptor>()
					};
			}
			return null;
		}
	}
}