// Type: Microsoft.Practices.Prism.Events.EventAggregator
// Assembly: Microsoft.Practices.Prism, Version=4.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Projects\Conversation\packages\Prism.4.1.0.0\lib\NET40\Microsoft.Practices.Prism.dll

namespace Microsoft.Practices.Prism.Events
{
	/// <summary>
	/// Implements <see cref="T:Microsoft.Practices.Prism.Events.IEventAggregator"/>.
	/// 
	/// </summary>
	public class EventAggregator : IEventAggregator
	{
		/// <summary>
		/// Gets the single instance of the event managed by this EventAggregator. Multiple calls to this method with the same <typeparamref name="TEventType"/> returns the same event instance.
		/// 
		/// </summary>
		/// <typeparam name="TEventType">The type of event to get. This must inherit from <see cref="T:Microsoft.Practices.Prism.Events.EventBase"/>.</typeparam>
		/// <returns>
		/// A singleton instance of an event object of type <typeparamref name="TEventType"/>.
		/// </returns>
		public TEventType GetEvent<TEventType>() where TEventType : new(), EventBase;
	}
}
