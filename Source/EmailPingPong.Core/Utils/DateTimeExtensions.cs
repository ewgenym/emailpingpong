using System;

namespace EmailPingPong.Core.Utils
{
	public static class DateTimeExtensions
	{
		public static bool LaterThen(this DateTime first, DateTime second)
		{
			return (first - second).TotalSeconds > 1;
		}
	}
}