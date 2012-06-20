// Type: Castle.MicroKernel.Registration.ComponentRegistration`1
// Assembly: Castle.Windsor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=407dd0808d44fbdc
// Assembly location: C:\Projects\Conversation\packages\Castle.Windsor.3.0.0.4001\lib\net40\Castle.Windsor.dll

using Castle.Core;
using Castle.Core.Configuration;
using Castle.DynamicProxy;
using Castle.MicroKernel;
using Castle.MicroKernel.Context;
using Castle.MicroKernel.Handlers;
using Castle.MicroKernel.LifecycleConcerns;
using Castle.MicroKernel.Lifestyle.Scoped;
using Castle.MicroKernel.ModelBuilder;
using Castle.MicroKernel.ModelBuilder.Descriptors;
using Castle.MicroKernel.Registration.Interceptor;
using Castle.MicroKernel.Registration.Lifestyle;
using Castle.MicroKernel.Registration.Proxy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Castle.MicroKernel.Registration
{
	/// <summary>
	/// Registration for a single type as a component with the kernel.
	/// 
	/// <para/>
	/// 
	///               You can create a new registration with the <see cref="T:Castle.MicroKernel.Registration.Component"/> factory.
	/// 
	/// </summary>
	/// <typeparam name="TService">The service type</typeparam>
	public class ComponentRegistration<TService> : IRegistration where TService : class
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Castle.MicroKernel.Registration.ComponentRegistration`1"/> class.
		/// 
		/// </summary>
		public ComponentRegistration();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Castle.MicroKernel.Registration.ComponentRegistration`1"/> class.
		/// 
		/// </summary>
		public ComponentRegistration(params Type[] services);

		/// <summary>
		/// Marks the components with one or more actors.
		/// 
		/// </summary>
		/// <param name="actors">The component actors.</param>
		/// <returns/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("If you\'re using WCF Facility use AsWcfClient/AsWcfService extension methods instead.")]
		public ComponentRegistration<TService> ActAs(params object[] actors);

		/// <summary>
		/// Set a custom <see cref="T:Castle.MicroKernel.IComponentActivator"/> which creates and destroys the component.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> Activator<TActivator>() where TActivator : IComponentActivator;

		/// <summary>
		/// Adds the attribute descriptor.
		/// 
		/// </summary>
		/// <param name="key">The key.</param><param name="value">The value.</param>
		/// <returns/>
		public ComponentRegistration<TService> AddAttributeDescriptor(string key, string value);

		/// <summary>
		/// Adds the descriptor.
		/// 
		/// </summary>
		/// <param name="descriptor">The descriptor.</param>
		/// <returns/>
		public ComponentRegistration<TService> AddDescriptor(IComponentModelDescriptor descriptor);

		/// <summary>
		/// Creates an attribute descriptor.
		/// 
		/// </summary>
		/// <param name="key">The attribute key.</param>
		/// <returns/>
		public AttributeKeyDescriptor<TService> Attribute(string key);

		/// <summary>
		/// Apply more complex configuration to this component registration.
		/// 
		/// </summary>
		/// <param name="configNodes">The config nodes.</param>
		/// <returns/>
		public ComponentRegistration<TService> Configuration(params Castle.MicroKernel.Registration.Node[] configNodes);

		/// <summary>
		/// Apply more complex configuration to this component registration.
		/// 
		/// </summary>
		/// <param name="configuration">The configuration <see cref="T:Castle.Core.Configuration.MutableConfiguration"/>.</param>
		/// <returns/>
		public ComponentRegistration<TService> Configuration(IConfiguration configuration);

		/// <summary>
		/// Specify custom dependencies using <see cref="M:Castle.MicroKernel.Registration.Property.ForKey(System.String)"/> or <see cref="M:Castle.MicroKernel.Registration.Property.ForKey(System.Type)"/>.
		/// 
		/// <para/>
		/// 
		///               You can pass <see cref="T:Castle.MicroKernel.Registration.ServiceOverride"/>s to specify the components
		///               this component should be resolved with.
		/// 
		/// </summary>
		/// <param name="dependencies">The dependencies.</param>
		/// <returns/>
		public ComponentRegistration<TService> DependsOn(params Dependency[] dependencies);

		/// <summary>
		/// Uses a dictionary of key/value pairs, to specify custom dependencies.
		/// 
		/// <para/>
		/// 
		/// </summary>
		/// <param name="dependencies">The dependencies.</param>
		/// <returns/>
		public ComponentRegistration<TService> DependsOn(IDictionary dependencies);

		/// <summary>
		/// Uses an (anonymous) object as a dictionary, to specify custom dependencies.
		/// 
		/// <para/>
		/// 
		/// </summary>
		/// <param name="anonymous">The dependencies.</param>
		/// <returns/>
		public ComponentRegistration<TService> DependsOn(object anonymous);

		/// <summary>
		/// Allows custom dependencies to by defined dyncamically. Calling this overload is synonymous to using <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.DynamicParameters(Castle.MicroKernel.Registration.DynamicParametersDelegate)"/>
		/// </summary>
		/// <param name="resolve">The delegate used for providing dynamic parameters.</param>
		/// <returns/>
		public ComponentRegistration<TService> DependsOn(DynamicParametersDelegate resolve);

		/// <summary>
		/// Allows custom dependencies to by defined dynamically with releasing capability. Calling this overload is synonymous to using <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.DynamicParameters(Castle.MicroKernel.Registration.DynamicParametersResolveDelegate)"/>
		/// </summary>
		/// <param name="resolve">The delegate used for providing dynamic parameters.</param>
		/// <returns/>
		public ComponentRegistration<TService> DependsOn(DynamicParametersResolveDelegate resolve);

		/// <summary>
		/// Allows custom dependencies to by defined dynamically with releasing capability. Calling this overload is synonymous to using <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.DynamicParameters(Castle.MicroKernel.Registration.DynamicParametersWithContextResolveDelegate)"/>
		/// </summary>
		/// <param name="resolve">The delegate used for providing dynamic parameters.</param>
		/// <returns/>
		/// 
		/// <remarks>
		/// Use <see cref="T:Castle.MicroKernel.Context.CreationContext"/> when resolving components from <see cref="T:Castle.MicroKernel.IKernel"/> in order to detect cycles.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> DependsOn(DynamicParametersWithContextResolveDelegate resolve);

		/// <summary>
		/// Allows custom dependencies to by defined dyncamically.
		/// 
		/// </summary>
		/// <param name="resolve">The delegate used for providing dynamic parameters.</param>
		/// <returns/>
		public ComponentRegistration<TService> DynamicParameters(DynamicParametersDelegate resolve);

		/// <summary>
		/// Allows custom dependencies to by defined dynamically with releasing capability.
		/// 
		/// </summary>
		/// <param name="resolve">The delegate used for providing dynamic parameters.</param>
		/// <returns/>
		public ComponentRegistration<TService> DynamicParameters(DynamicParametersResolveDelegate resolve);

		/// <summary>
		/// Allows custom dependencies to by defined dynamically with releasing capability.
		/// 
		/// </summary>
		/// <param name="resolve">The delegate used for providing dynamic parameters.</param>
		/// <returns/>
		/// 
		/// <remarks>
		/// Use <see cref="T:Castle.MicroKernel.Context.CreationContext"/> when resolving components from <see cref="T:Castle.MicroKernel.IKernel"/> in order to detect cycles.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> DynamicParameters(DynamicParametersWithContextResolveDelegate resolve);

		/// <summary>
		/// Sets <see cref="P:Castle.Core.ComponentModel.ExtendedProperties"/> for this component.
		/// 
		/// </summary>
		/// <param name="properties">The extended properties.</param>
		/// <returns/>
		public ComponentRegistration<TService> ExtendedProperties(params Property[] properties);

		/// <summary>
		/// Sets <see cref="P:Castle.Core.ComponentModel.ExtendedProperties"/> for this component.
		/// 
		/// </summary>
		/// <param name="anonymous">The extendend properties as key/value pairs.</param>
		/// <returns/>
		public ComponentRegistration<TService> ExtendedProperties(object anonymous);

		/// <summary>
		/// Adds <paramref name="types"/> as additional services to be exposed by this component.
		/// 
		/// </summary>
		/// <param name="types">The types to forward.</param>
		/// <returns/>
		public ComponentRegistration<TService> Forward(params Type[] types);

		/// <summary>
		/// Adds <typeparamref name="TService2"/> as additional service to be exposed by this component.
		/// 
		/// </summary>
		/// <typeparam name="TService2">The forwarded type.</typeparam>
		/// <returns>
		/// The component registration.
		/// </returns>
		public ComponentRegistration<TService> Forward<TService2>();

		/// <summary>
		/// Adds <typeparamref name="TService2"/> and <typeparamref name="TService3"/> as additional services to be exposed by this component.
		/// 
		/// </summary>
		/// <typeparam name="TService2">The first forwarded type.</typeparam><typeparam name="TService3">The second forwarded type.</typeparam>
		/// <returns>
		/// The component registration.
		/// </returns>
		public ComponentRegistration<TService> Forward<TService2, TService3>();

		/// <summary>
		/// Adds <typeparamref name="TService2"/>, <typeparamref name="TService3"/> and  <typeparamref name="TService4"/> as additional services to be exposed by this component.
		/// 
		/// </summary>
		/// <typeparam name="TService2">The first forwarded type.</typeparam><typeparam name="TService3">The second forwarded type.</typeparam><typeparam name="TService4">The third forwarded type.</typeparam>
		/// <returns>
		/// The component registration.
		/// </returns>
		public ComponentRegistration<TService> Forward<TService2, TService3, TService4>();

		/// <summary>
		/// Adds <typeparamref name="TService2"/>, <typeparamref name="TService3"/>,<typeparamref name="TService4"/> and  <typeparamref name="TService5"/> as additional services to be exposed by this component.
		/// 
		/// </summary>
		/// <typeparam name="TService2">The first forwarded type.</typeparam><typeparam name="TService3">The second forwarded type.</typeparam><typeparam name="TService4">The third forwarded type.</typeparam><typeparam name="TService5">The fourth forwarded type.</typeparam>
		/// <returns>
		/// The component registration.
		/// </returns>
		public ComponentRegistration<TService> Forward<TService2, TService3, TService4, TService5>();

		/// <summary>
		/// Adds <paramref name="types"/> as additional services to be exposed by this component.
		/// 
		/// </summary>
		/// <param name="types">The types to forward.</param>
		/// <returns/>
		public ComponentRegistration<TService> Forward(IEnumerable<Type> types);

		/// <summary>
		/// Sets the concrete type that implements the service to <typeparamref name="TImpl"/>.
		/// 
		/// <para/>
		/// 
		///               If not set, the class service type or first registered interface will be used as the implementation for this component.
		/// 
		/// </summary>
		/// <typeparam name="TImpl">The type that is the implementation for the service.</typeparam>
		/// <returns/>
		public ComponentRegistration<TService> ImplementedBy<TImpl>() where TImpl : TService;

		/// <summary>
		/// Sets the concrete type that implements the service to <paramref name="type"/>.
		/// 
		/// <para/>
		/// 
		///               If not set, the class service type or first registered interface will be used as the implementation for this component.
		/// 
		/// </summary>
		/// <param name="type">The type that is the implementation for the service.</param>
		/// <returns/>
		public ComponentRegistration<TService> ImplementedBy(Type type);

		/// <summary>
		/// Sets the concrete type that implements the service to <paramref name="type"/>.
		/// 
		/// <para/>
		/// 
		///               If not set, the class service type or first registered interface will be used as the implementation for this component.
		/// 
		/// </summary>
		/// <param name="type">The type that is the implementation for the service.</param><param name="genericImplementationMatchingStrategy">Provides ability to close open generic service. Ignored when registering closed or non-generic component.</param>
		/// <returns/>
		public ComponentRegistration<TService> ImplementedBy(Type type, IGenericImplementationMatchingStrategy genericImplementationMatchingStrategy);

		/// <summary>
		/// Assigns an existing instance as the component for this registration.
		/// 
		/// </summary>
		/// <param name="instance">The component instance.</param>
		/// <returns/>
		public ComponentRegistration<TService> Instance(TService instance);

		/// <summary>
		/// Set the interceptors for this component.
		/// 
		/// </summary>
		/// <param name="interceptors">The interceptors.</param>
		/// <returns/>
		public InterceptorGroup<TService> Interceptors(params InterceptorReference[] interceptors);

		/// <summary>
		/// Set the interceptors for this component.
		/// 
		/// </summary>
		/// <param name="interceptors">The interceptors.</param>
		/// <returns/>
		public ComponentRegistration<TService> Interceptors(params Type[] interceptors);

		/// <summary>
		/// Set the interceptor for this component.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> Interceptors<TInterceptor>() where TInterceptor : IInterceptor;

		/// <summary>
		/// Set the interceptor for this component.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> Interceptors<TInterceptor1, TInterceptor2>() where TInterceptor1 : IInterceptor where TInterceptor2 : IInterceptor;

		/// <summary>
		/// Set the interceptor for this component.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> Interceptors(params string[] keys);

		/// <summary>
		/// Sets component lifestyle to specified one.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestyleCustom(Type customLifestyleType);

		/// <summary>
		/// Sets component lifestyle to specified one.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestyleCustom<TLifestyleManager>() where TLifestyleManager : new(), ILifestyleManager;

		/// <summary>
		/// Sets component lifestyle to per thread.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestylePerThread();

		/// <summary>
		/// Sets component lifestyle to scoped per explicit scope. If <paramref name="scopeAccessorType"/> is provided, it will be used to access scope for the component. Otherwise the default scope accessor will be used.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestyleScoped(Type scopeAccessorType = null);

		/// <summary>
		/// Sets component lifestyle to scoped per explicit scope.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestyleScoped<TScopeAccessor>() where TScopeAccessor : new(), IScopeAccessor;

		/// <summary>
		/// Sets component lifestyle to scoped per nearest component on the resolution stack where implementation type is assignable to <typeparamref name="TBaseForRoot"/>.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestyleBoundTo<TBaseForRoot>() where TBaseForRoot : class;

		/// <summary>
		/// Sets component lifestyle to scoped per scope determined by <paramref name="scopeRootBinder"/>
		/// </summary>
		/// <param name="scopeRootBinder">Custom algorithm for selection which component higher up the resolution stack should be the root of the lifetime scope for current component's instances.
		///               The delegate will be invoked when current component is about to be resolved and will be passed set of handlers to components higher up the resolution stack. It ought to return one which it designages
		///               as the root which shall scope the lifetime of current component's instance, or <c>null</c></param>
		/// <returns/>
		public ComponentRegistration<TService> LifestyleBoundTo(Func<IHandler[], IHandler> scopeRootBinder);

		/// <summary>
		/// Sets component lifestyle to instance per web request.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestylePerWebRequest();

		/// <summary>
		/// Sets component lifestyle to pooled. If <paramref name="initialSize"/> or <paramref name="maxSize"/> are not set default values will be used.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestylePooled(int? initialSize = null, int? maxSize = null);

		/// <summary>
		/// Sets component lifestyle to singleton.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestyleSingleton();

		/// <summary>
		/// Sets component lifestyle to transient.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> LifestyleTransient();

		/// <summary>
		/// Set a name of this registration. This is required if you have multiple components for a given service and want to be able to resolve some specific ones. Then you'd provide the name so that Windsor knows which one of the bunch you know. Otherwise don't bother setting the name.
		/// 
		/// <para/>
		/// 
		///               If not set, the <see cref="P:System.Type.FullName"/> of the <see cref="P:Castle.MicroKernel.Registration.ComponentRegistration`1.Implementation"/>
		///               will be used as the key to register the component.
		/// 
		/// </summary>
		/// <param name="name">The name of this registration.</param>
		/// <returns/>
		/// 
		/// <remarks>
		/// Names have to be globally unique in the scope of the container.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> Named(string name);

		/// <summary>
		/// This method as opposed to <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.Named(System.String)"/> should be used by tools like facilities when the name is not provided by the user, but autogenerated and user has no interest in seing this name, for example in diagnostics reports.
		///               Set a name of this registration. This is required if you have multiple components for a given service and want to be able to resolve some specific ones. Then you'd provide the name so that Windsor knows which one of the bunch you know. Otherwise don't bother setting the name.
		/// 
		/// <para/>
		/// 
		///               If not set, the <see cref="P:System.Type.FullName"/> of the <see cref="P:Castle.MicroKernel.Registration.ComponentRegistration`1.Implementation"/>
		///               will be used as the key to register the component.
		/// 
		/// </summary>
		/// <param name="name">The name of this registration.</param>
		/// <returns/>
		/// 
		/// <remarks>
		/// Names have to be globally unique in the scope of the container.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> NamedAutomatically(string name);

		/// <summary>
		/// Stores a set of <see cref="T:Castle.MicroKernel.LifecycleConcerns.LifecycleActionDelegate`1"/> which will be invoked when the component
		///               is created and before it's returned from the container.
		/// 
		/// </summary>
		/// <param name="actions">A set of actions to be executed right after the component is created and before it's returned from the container.</param>
		public ComponentRegistration<TService> OnCreate(params Action<TService>[] actions);

		/// <summary>
		/// Stores a set of <see cref="T:Castle.MicroKernel.LifecycleConcerns.LifecycleActionDelegate`1"/> which will be invoked when the component
		///               is created and before it's returned from the container.
		/// 
		/// </summary>
		/// <param name="actions">A set of actions to be executed right after the component is created and before it's returned from the container.</param>
		public ComponentRegistration<TService> OnCreate(params LifecycleActionDelegate<TService>[] actions);

		/// <summary>
		/// Stores a set of <see cref="T:Castle.MicroKernel.LifecycleConcerns.LifecycleActionDelegate`1"/> which will be invoked when the component
		///               is created and before it's returned from the container.
		/// 
		/// </summary>
		/// <param name="actions">A set of actions to be executed right after the component is created and before it's returned from the container.</param>
		public ComponentRegistration<TService> OnDestroy(params Action<TService>[] actions);

		/// <summary>
		/// Stores a set of <see cref="T:Castle.MicroKernel.LifecycleConcerns.LifecycleActionDelegate`1"/> which will be invoked when the component
		///               is destroyed which means when it's released or it's lifetime scope ends. Notice that usage of this method will cause instsances of the component to be tracked, even if they wouldn't be otherwise.
		/// 
		/// </summary>
		/// <param name="actions">A set of actions to be executed when the component is destroyed.</param>
		public ComponentRegistration<TService> OnDestroy(params LifecycleActionDelegate<TService>[] actions);

		/// <summary>
		/// Services that are already present in the container will be skipped. If no new service is left the registration will not happen at all.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		public ComponentRegistration<TService> OnlyNewServices();

		/// <summary>
		/// With the overwrite.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ComponentRegistration<TService> OverWrite();

		/// <summary>
		/// Set configuration parameters with string or <see cref="T:Castle.Core.Configuration.IConfiguration"/> values.
		/// 
		/// </summary>
		/// <param name="parameters">The parameters.</param>
		/// <returns/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use DependsOn(Dependency.OnConfigValue()) or Dependency.OnValue() instead")]
		public ComponentRegistration<TService> Parameters(params Parameter[] parameters);

		/// <summary>
		/// Sets the interceptor selector for this component.
		/// 
		/// </summary>
		/// <param name="selector"/>
		/// <returns/>
		public ComponentRegistration<TService> SelectInterceptorsWith(IInterceptorSelector selector);

		/// <summary>
		/// Sets the interceptor selector for this component.
		/// 
		/// </summary>
		/// <param name="selector"/>
		/// <returns/>
		public ComponentRegistration<TService> SelectInterceptorsWith(Action<ItemRegistration<IInterceptorSelector>> selector);

		/// <summary>
		/// Override (some of) the services that this component needs.
		///               Use <see cref="M:Castle.MicroKernel.Registration.ServiceOverride.ForKey(System.String)"/> to create an override.
		/// 
		/// <para/>
		/// 
		///               Each key represents the service dependency of this component, for example the name of a constructor argument or a property.
		///               The corresponding value is the key of an other component registered to the kernel, and is used to resolve the dependency.
		/// 
		/// <para/>
		/// 
		///               To specify dependencies which are not services, use <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.DependsOn(Castle.MicroKernel.Registration.Dependency[])"/>
		/// </summary>
		/// <param name="overrides">The service overrides.</param>
		/// <returns/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use DependsOn(Dependency.OnComponent()) instead")]
		public ComponentRegistration<TService> ServiceOverrides(params ServiceOverride[] overrides);

		/// <summary>
		/// Override (some of) the services that this component needs, using a dictionary.
		/// 
		/// <para/>
		/// 
		///               Each key represents the service dependency of this component, for example the name of a constructor argument or a property.
		///               The corresponding value is the key of an other component registered to the kernel, and is used to resolve the dependency.
		/// 
		/// <para/>
		/// 
		///               To specify dependencies which are not services, use <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.DependsOn(System.Collections.IDictionary)"/>
		/// </summary>
		/// <param name="overrides">The service overrides.</param>
		/// <returns/>
		[Obsolete("Use DependsOn(Dependency.OnComponent()) instead")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ComponentRegistration<TService> ServiceOverrides(IDictionary overrides);

		/// <summary>
		/// Override (some of) the services that this component needs, using an (anonymous) object as a dictionary.
		/// 
		/// <para/>
		/// 
		///               Each key represents the service dependency of this component, for example the name of a constructor argument or a property.
		///               The corresponding value is the key of an other component registered to the kernel, and is used to resolve the dependency.
		/// 
		/// <para/>
		/// 
		///               To specify dependencies which are not services, use <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.DependsOn(System.Object)"/>
		/// </summary>
		/// <param name="anonymous">The service overrides.</param>
		/// <returns/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use DependsOn(Dependency.OnComponent()) instead")]
		public ComponentRegistration<TService> ServiceOverrides(object anonymous);

		/// <summary>
		/// Uses a factory to instantiate the component
		/// 
		/// </summary>
		/// <typeparam name="TFactory">Factory type. This factory has to be registered in the kernel.</typeparam><typeparam name="TServiceImpl">Implementation type.</typeparam><param name="factory">Factory invocation</param>
		/// <returns/>
		public ComponentRegistration<TService> UsingFactory<TFactory, TServiceImpl>(Converter<TFactory, TServiceImpl> factory) where TServiceImpl : TService;

		/// <summary>
		/// Uses a factory method to instantiate the component.
		/// 
		/// </summary>
		/// <typeparam name="TImpl">Implementation type</typeparam><param name="factoryMethod">Factory method</param><param name="managedExternally">When set to <c>true</c> container will not assume ownership of this component, will not track it not apply and lifecycle concerns to it.</param>
		/// <returns/>
		public ComponentRegistration<TService> UsingFactoryMethod<TImpl>(Func<TImpl> factoryMethod, bool managedExternally = false) where TImpl : TService;

		/// <summary>
		/// Uses a factory method to instantiate the component.
		/// 
		/// </summary>
		/// <typeparam name="TImpl">Implementation type</typeparam><param name="factoryMethod">Factory method</param><param name="managedExternally">When set to <c>true</c> container will not assume ownership of this component, will not track it not apply and lifecycle concerns to it.</param>
		/// <returns/>
		public ComponentRegistration<TService> UsingFactoryMethod<TImpl>(Converter<IKernel, TImpl> factoryMethod, bool managedExternally = false) where TImpl : TService;

		/// <summary>
		/// Uses a factory method to instantiate the component.
		/// 
		/// </summary>
		/// <typeparam name="TImpl">Implementation type</typeparam><param name="factoryMethod">Factory method</param><param name="managedExternally">When set to <c>true</c> container will not assume ownership of this component, will not track it not apply and lifecycle concerns to it.</param>
		/// <returns/>
		public ComponentRegistration<TService> UsingFactoryMethod<TImpl>(Func<IKernel, ComponentModel, CreationContext, TImpl> factoryMethod, bool managedExternally = false) where TImpl : TService;

		/// <summary>
		/// Uses a factory method to instantiate the component.
		/// 
		/// </summary>
		/// <typeparam name="TImpl">Implementation type</typeparam><param name="factoryMethod">Factory method</param>
		/// <returns/>
		public ComponentRegistration<TService> UsingFactoryMethod<TImpl>(Func<IKernel, CreationContext, TImpl> factoryMethod) where TImpl : TService;

		/// <summary>
		/// Registers this component with the <see cref="T:Castle.MicroKernel.IKernel"/>.
		/// 
		/// </summary>
		/// <param name="kernel">The kernel.</param>
		void IRegistration.Register(IKernelInternal kernel);

		/// <summary>
		/// Overrides default behavior by making the current component the default for every service it exposes. Optional <paramref name="serviceFilter"/> allows user to narrow down the number of services which should be make defaults.
		/// 
		/// </summary>
		/// <param name="serviceFilter">Invoked for each service exposed by given component if returns <c>true</c> this component will be the default for that service. If not specified it is assumed current component should become the default for all of its services.</param>
		/// <returns/>
		/// 
		/// <remarks>
		/// When specified for multiple components for any given service the one registered after will override the one selected before.
		///               This does not affect order of resolution via <see cref="M:Castle.MicroKernel.IKernel.ResolveAll``1"/> methods.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> IsDefault(Predicate<Type> serviceFilter);

		/// <summary>
		/// Overrides default behavior by making the current component the default for every service it exposes.
		/// 
		/// </summary>
		/// 
		/// <returns/>
		/// 
		/// <remarks>
		/// When specified for multiple components for any given service the one registered after will override the one selected before.
		///               This does not affect order of resolution via <see cref="M:Castle.MicroKernel.IKernel.ResolveAll``1"/> methods.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> IsDefault();

		/// <summary>
		/// Filters properties on the implementation that will be considered 'settable' by the container.
		/// 
		/// </summary>
		/// <param name="filter">Predicate deciding whether a property is settable or not. If returns <c>false</c> container will ignore the property, otherwise property will be ignored.</param>
		/// <returns/>
		/// 
		/// <remarks>
		/// Matched properties will be considered optional, that is component will resolve successfully if they can not be satisfied.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> Properties(Predicate<PropertyInfo> filter);

		/// <summary>
		/// Filters properties on the implementation that will be considered 'settable' by the container and specifies if matched properties are reqired.
		/// 
		/// </summary>
		/// <param name="filter">Predicate deciding whether a property is settable or not. If returns <c>false</c> container will ignore the property.</param><param name="isRequired"/>
		/// <returns/>
		/// 
		/// <remarks>
		/// Matched properties will be considered optional if <paramref name="isRequired"/> is<c>false</c>, that is component will resolve successfully if they can not be satisfied.
		///               If the argument is <c>true</c> and the dependencies can not be resolved the component will fail to resolve.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> Properties(Predicate<PropertyInfo> filter, bool isRequired);

		/// <summary>
		/// Filters properties on the implementation that will be considered 'settable' by the container and specifies if matched properties are reqired.
		/// 
		/// </summary>
		/// <param name="filter">Predicate deciding whether a property is settable or not. If returns <c>false</c> container will ignore the property.</param><param name="isRequired"/>
		/// <returns/>
		/// 
		/// <remarks>
		/// Matched properties will be considered optional if <paramref name="isRequired"/> is<c>false</c>, that is component will resolve successfully if they can not be satisfied.
		///               If the argument is <c>true</c> and the dependencies can not be resolved the component will fail to resolve.
		/// 
		/// </remarks>
		public ComponentRegistration<TService> Properties(Func<ComponentModel, PropertyInfo, bool> filter, bool isRequired);

		/// <summary>
		/// Filters properties on the implementation that will be considered 'settable' by the container and specifies if matched properties are reqired.
		/// 
		/// </summary>
		/// <param name="filter">Rules for deciding whether a property is settable or not and if container will ignore the property.</param>
		/// <returns/>
		public ComponentRegistration<TService> Properties(PropertyFilter filter);

		/// <summary>
		/// The concrete type that implements the service.
		/// 
		/// <para/>
		/// 
		///               To set the implementation, use <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.ImplementedBy(System.Type)"/>.
		/// 
		/// </summary>
		/// 
		/// <value>
		/// The implementation of the service.
		/// </value>
		public Type Implementation { get; }

		/// <summary>
		/// Set the lifestyle of this component.
		///               For example singleton and transient (also known as 'factory').
		/// 
		/// </summary>
		/// 
		/// <value>
		/// The with lifestyle.
		/// </value>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public LifestyleGroup<TService> LifeStyle { get; }

		/// <summary>
		/// The name of the component. Will become the key for the component in the kernel.
		/// 
		/// <para/>
		/// 
		///               To set the name, use <see cref="M:Castle.MicroKernel.Registration.ComponentRegistration`1.Named(System.String)"/>.
		/// 
		/// <para/>
		/// 
		///               If not set, the <see cref="P:System.Type.FullName"/> of the <see cref="P:Castle.MicroKernel.Registration.ComponentRegistration`1.Implementation"/>
		///               will be used as the key to register the component.
		/// 
		/// </summary>
		/// 
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; }

		/// <summary>
		/// Set proxy for this component.
		/// 
		/// </summary>
		/// 
		/// <value>
		/// The proxy.
		/// </value>
		public ProxyGroup<TService> Proxy { get; }

		protected internal IList<Type> Services { get; }
		protected internal int ServicesCount { get; }
	}
}
