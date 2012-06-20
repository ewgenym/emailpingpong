// Type: Microsoft.Practices.Prism.Events.CompositePresentationEvent`1
// Assembly: Microsoft.Practices.Prism, Version=4.1.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Projects\Conversation\packages\Prism.4.1.0.0\lib\NET40\Microsoft.Practices.Prism.dll

using System;

namespace Microsoft.Practices.Prism.Events
{
	/// <summary>
	/// Defines a class that manages publication and subscription to events.
	/// 
	/// </summary>
	/// <typeparam name="TPayload">The type of message that will be passed to the subscribers.</typeparam>
	public class CompositePresentationEvent<TPayload> : EventBase
	{
		/// <summary>
		/// Subscribes a delegate to an event that will be published on the <see cref="F:Microsoft.Practices.Prism.Events.ThreadOption.PublisherThread"/>.
		///             <see cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/> will maintain a <seealso cref="T:System.WeakReference"/> to the target of the supplied <paramref name="action"/> delegate.
		/// 
		/// </summary>
		/// <param name="action">The delegate that gets executed when the event is published.</param>
		/// <returns>
		/// A <see cref="T:Microsoft.Practices.Prism.Events.SubscriptionToken"/> that uniquely identifies the added subscription.
		/// </returns>
		/// 
		/// <remarks>
		/// The CompositePresentationEvent collection is thread-safe.
		/// 
		/// </remarks>
		public SubscriptionToken Subscribe(Action<TPayload> action);

		/// <summary>
		/// Subscribes a delegate to an event.
		///             CompositePresentationEvent will maintain a <seealso cref="T:System.WeakReference"/> to the Target of the supplied <paramref name="action"/> delegate.
		/// 
		/// </summary>
		/// <param name="action">The delegate that gets executed when the event is raised.</param><param name="threadOption">Specifies on which thread to receive the delegate callback.</param>
		/// <returns>
		/// A <see cref="T:Microsoft.Practices.Prism.Events.SubscriptionToken"/> that uniquely identifies the added subscription.
		/// </returns>
		/// 
		/// <remarks>
		/// The CompositePresentationEvent collection is thread-safe.
		/// 
		/// </remarks>
		public SubscriptionToken Subscribe(Action<TPayload> action, ThreadOption threadOption);

		/// <summary>
		/// Subscribes a delegate to an event that will be published on the <see cref="F:Microsoft.Practices.Prism.Events.ThreadOption.PublisherThread"/>.
		/// 
		/// </summary>
		/// <param name="action">The delegate that gets executed when the event is published.</param><param name="keepSubscriberReferenceAlive">When <see langword="true"/>, the <seealso cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/> keeps a reference to the subscriber so it does not get garbage collected.</param>
		/// <returns>
		/// A <see cref="T:Microsoft.Practices.Prism.Events.SubscriptionToken"/> that uniquely identifies the added subscription.
		/// </returns>
		/// 
		/// <remarks>
		/// If <paramref name="keepSubscriberReferenceAlive"/> is set to <see langword="false"/>, <see cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/> will maintain a <seealso cref="T:System.WeakReference"/> to the Target of the supplied <paramref name="action"/> delegate.
		///             If not using a WeakReference (<paramref name="keepSubscriberReferenceAlive"/> is <see langword="true"/>), the user must explicitly call Unsubscribe for the event when disposing the subscriber in order to avoid memory leaks or unexepcted behavior.
		/// 
		/// <para/>
		/// 
		///             The CompositePresentationEvent collection is thread-safe.
		/// 
		/// </remarks>
		public SubscriptionToken Subscribe(Action<TPayload> action, bool keepSubscriberReferenceAlive);

		/// <summary>
		/// Subscribes a delegate to an event.
		/// 
		/// </summary>
		/// <param name="action">The delegate that gets executed when the event is published.</param><param name="threadOption">Specifies on which thread to receive the delegate callback.</param><param name="keepSubscriberReferenceAlive">When <see langword="true"/>, the <seealso cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/> keeps a reference to the subscriber so it does not get garbage collected.</param>
		/// <returns>
		/// A <see cref="T:Microsoft.Practices.Prism.Events.SubscriptionToken"/> that uniquely identifies the added subscription.
		/// </returns>
		/// 
		/// <remarks>
		/// If <paramref name="keepSubscriberReferenceAlive"/> is set to <see langword="false"/>, <see cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/> will maintain a <seealso cref="T:System.WeakReference"/> to the Target of the supplied <paramref name="action"/> delegate.
		///             If not using a WeakReference (<paramref name="keepSubscriberReferenceAlive"/> is <see langword="true"/>), the user must explicitly call Unsubscribe for the event when disposing the subscriber in order to avoid memory leaks or unexepcted behavior.
		/// 
		/// <para/>
		/// 
		///             The CompositePresentationEvent collection is thread-safe.
		/// 
		/// </remarks>
		public SubscriptionToken Subscribe(Action<TPayload> action, ThreadOption threadOption, bool keepSubscriberReferenceAlive);

		/// <summary>
		/// Subscribes a delegate to an event.
		/// 
		/// </summary>
		/// <param name="action">The delegate that gets executed when the event is published.</param><param name="threadOption">Specifies on which thread to receive the delegate callback.</param><param name="keepSubscriberReferenceAlive">When <see langword="true"/>, the <seealso cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/> keeps a reference to the subscriber so it does not get garbage collected.</param><param name="filter">Filter to evaluate if the subscriber should receive the event.</param>
		/// <returns>
		/// A <see cref="T:Microsoft.Practices.Prism.Events.SubscriptionToken"/> that uniquely identifies the added subscription.
		/// </returns>
		/// 
		/// <remarks>
		/// If <paramref name="keepSubscriberReferenceAlive"/> is set to <see langword="false"/>, <see cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/> will maintain a <seealso cref="T:System.WeakReference"/> to the Target of the supplied <paramref name="action"/> delegate.
		///             If not using a WeakReference (<paramref name="keepSubscriberReferenceAlive"/> is <see langword="true"/>), the user must explicitly call Unsubscribe for the event when disposing the subscriber in order to avoid memory leaks or unexepcted behavior.
		/// 
		///             The CompositePresentationEvent collection is thread-safe.
		/// 
		/// </remarks>
		public virtual SubscriptionToken Subscribe(Action<TPayload> action, ThreadOption threadOption, bool keepSubscriberReferenceAlive, Predicate<TPayload> filter);

		/// <summary>
		/// Publishes the <see cref="T:Microsoft.Practices.Prism.Events.CompositePresentationEvent`1"/>.
		/// 
		/// </summary>
		/// <param name="payload">Message to pass to the subscribers.</param>
		public virtual void Publish(TPayload payload);

		/// <summary>
		/// Removes the first subscriber matching <seealso cref="T:System.Action`1"/> from the subscribers' list.
		/// 
		/// </summary>
		/// <param name="subscriber">The <see cref="T:System.Action`1"/> used when subscribing to the event.</param>
		public virtual void Unsubscribe(Action<TPayload> subscriber);

		/// <summary>
		/// Returns <see langword="true"/> if there is a subscriber matching <seealso cref="T:System.Action`1"/>.
		/// 
		/// </summary>
		/// <param name="subscriber">The <see cref="T:System.Action`1"/> used when subscribing to the event.</param>
		/// <returns>
		/// <see langword="true"/> if there is an <seealso cref="T:System.Action`1"/> that matches; otherwise <see langword="false"/>.
		/// </returns>
		public virtual bool Contains(Action<TPayload> subscriber);
	}
}
