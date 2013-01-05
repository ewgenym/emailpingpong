using System;
using System.Runtime.Serialization;

namespace EmailPingPong.Infrastructure
{
	public class NoHandlerForCommandException : Exception
	{
		public NoHandlerForCommandException(string message)
			: base(message)
		{
		}

		protected NoHandlerForCommandException(SerializationInfo info, StreamingContext context) 
			: base(info, context)
		{
		}

		public NoHandlerForCommandException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}