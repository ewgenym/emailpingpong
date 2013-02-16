using System;

namespace EmailPingPong.Core.Services
{
	public interface ITimeProvider
	{
		DateTime Now { get; }
	}
}