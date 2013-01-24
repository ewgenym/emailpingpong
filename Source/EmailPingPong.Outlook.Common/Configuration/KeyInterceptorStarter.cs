using EmailPingPong.Outlook.Common.Controllers;
using EmailPingPong.Outlook.Common.Utils;

namespace EmailPingPong.Outlook.Common.Configuration
{
	public class KeyInterceptorStarter : IKeyInterceptorStarter
	{
		private readonly IInspectorController _inspectorController;

		public KeyInterceptorStarter(IInspectorController inspectorController)
		{
			_inspectorController = inspectorController;
		}

		public void Start()
		{
			InterceptKeys.SetHook();
			InterceptKeys.KeyDown += _inspectorController.HandleHotKey;
		}

		public void Stop()
		{
			InterceptKeys.ReleaseHook();
		}
	}

	public interface IKeyInterceptorStarter
	{
		void Start();
		void Stop();
	}
}