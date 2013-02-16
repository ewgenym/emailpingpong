using System;

namespace EmailPingPong.Core.Services.Implementation
{
	public class TimeProvider : ITimeProvider
	{
		public DateTime Now 
		{
			get { return DateTime.Now; }
		}
	}
}