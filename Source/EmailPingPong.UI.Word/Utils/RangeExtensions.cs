using Microsoft.Office.Interop.Word;

namespace EmailPingPong.UI.Word.Utils
{
	public static class RangeExtensions
	{
		public static ContentControl PingPongControl(this Range range)
		{
			ContentControl pingPongControl = null;
			var parentControl = range.ParentContentControl;
			while (parentControl != null)
			{
				if (parentControl.IsPing() || parentControl.IsPong())
				{
					pingPongControl = parentControl;
					break;
				}

				parentControl = parentControl.ParentContentControl;
			}

			return pingPongControl;
		}
	}
}
