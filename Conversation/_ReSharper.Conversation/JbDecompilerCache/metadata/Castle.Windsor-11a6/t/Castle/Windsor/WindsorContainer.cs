// Type: Castle.Windsor.WindsorContainer
// Assembly: Castle.Windsor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=407dd0808d44fbdc
// Assembly location: C:\Projects\Conversation\Conversation\bin\Debug\Castle.Windsor.dll

using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor.Configuration;
using Castle.Windsor.Diagnostics;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace Castle.Windsor
{
	/// <summary>
	/// Implementation of <see cref="T:Castle.Windsor.IWindsorContainer"/>
	///               which delegates to <see cref="T:Castle.MicroKernel.IKernel"/> implementation.
	/// 
	/// </summary>
	[DebuggerDisplay("{name,nq}")]
	[DebuggerTypeProxy(typeof (KernelDebuggerProxy))]
	[Serializable]
	public class WindsorContainer : MarshalByRefObject, IWindsorContainer, IDisposable
	{
		/// <summary>
		/// Constructs a container without any external
		///               configuration reference
		/// 
		/// </summary>
		public WindsorContainer();

		/// <summary>
		/// Constructs a container using the specified
		///               <see cref="T:Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore"/> implementation.
		/// 
		/// </summary>
		/// <param name="store">The instance of an <see cref="T:Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore"/> implementation.</param>
		public WindsorContainer(IConfigurationStore store);

		/// <summary>
		/// Constructs a container using the specified
		///               <see cref="T:Castle.Windsor.Configuration.IConfigurationInterpreter"/> implementation.
		/// 
		/// </summary>
		/// <param name="interpreter">The instance of an <see cref="T:Castle.Windsor.Configuration.IConfigurationInterpreter"/> implementation.</param>
		public WindsorContainer(IConfigurationInterpreter interpreter);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Castle.Windsor.WindsorContainer"/> class.
		/// 
		/// </summary>
		/// <param name="interpreter">The interpreter.</param><param name="environmentInfo">The environment info.</param>
		public WindsorContainer(IConfigurationInterpreter interpreter, IEnvironmentInfo environmentInfo);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Castle.Windsor.WindsorContainer"/> class using a
		///               resource pointed to by the parameter. That may be a file, an assembly embedded resource, a UNC path or a config file section.
		/// 
		/// <para>
		/// Equivalent to the use of <c>new WindsorContainer(new XmlInterpreter(configurationUri))</c>
		/// </para>
		/// 
		/// </summary>
		/// <param name="configurationUri">The XML file.</param>
		public WindsorContainer(string configurationUri);

		/// <summary>
		/// Constructs a container using the specified <see cref="T:Castle.MicroKernel.IKernel"/>
		///               implementation. Rarely used.
		/// 
		/// </summary>
		/// 
		/// <remarks>
		/// This constructs sets the Kernel.ProxyFactory property to
		///               <c>Proxy.DefaultProxyFactory</c>
		/// </remarks>
		/// <param name="kernel">Kernel instance</param><param name="installer">Installer instance</param>
		public WindsorContainer(IKernel kernel, IComponentsInstaller installer);

		/// <summary>
		/// Constructs a container using the specified <see cref="T:Castle.MicroKernel.IKernel"/>
		///               implementation. Rarely used.
		/// 
		/// </summary>
		/// 
		/// <remarks>
		/// This constructs sets the Kernel.ProxyFactory property to
		///               <c>Proxy.DefaultProxyFactory</c>
		/// </remarks>
		/// <param name="name">Container's name</param><param name="kernel">Kernel instance</param><param name="installer">Installer instance</param>
		public WindsorContainer(string name, IKernel kernel, IComponentsInstaller installer);

		/// <summary>
		/// Constructs with a given <see cref="T:Castle.MicroKernel.IProxyFactory"/>.
		/// 
		/// </summary>
		/// <param name="proxyFactory">A instance of an <see cref="T:Castle.MicroKernel.IProxyFactory"/>.</param>
		public WindsorContainer(IProxyFactory proxyFactory);

		/// <summary>
		/// Constructs a container assigning a parent container
		///               before starting the dependency resolution.
		/// 
		/// </summary>
		/// <param name="parent">The instance of an <see cref="T:Castle.Windsor.IWindsorContainer"/></param><param name="interpreter">The instance of an <see cref="T:Castle.Windsor.Configuration.IConfigurationInterpreter"/> implementation</param>
		public WindsorContainer(IWindsorContainer parent, IConfigurationInterpreter interpreter);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Castle.Windsor.WindsorContainer"/> class.
		/// 
		/// </summary>
		/// <param name="name">The container's name.</param><param name="parent">The parent.</param><param name="interpreter">The interpreter.</param>
		public WindsorContainer(string name, IWindsorContainer parent, IConfigurationInterpreter interpreter);

		protected virtual void RunInstaller();

		/// <summary>
		/// Executes Dispose on underlying <see cref="T:Castle.MicroKernel.IKernel"/>
		/// </summary>
		public virtual void Dispose();

		/// <summary>
		/// Registers a subcontainer. The components exposed
		///               by this container will be accessible from subcontainers.
		/// 
		/// </summary>
		/// <param name="childContainer"/>
		public virtual void AddChildContainer(IWindsorContainer childContainer);

		/// <summary>
		/// Registers a facility within the container.
		/// 
		/// </summary>
		/// <param name="facility"/>
		public IWindsorContainer AddFacility(IFacility facility);

		/// <summary>
		/// Creates and adds an <see cref="T:Castle.MicroKernel.IFacility"/> facility to the container.
		/// 
		/// </summary>
		/// <typeparam name="T">The facility type.</typeparam>
		/// <returns/>
		public IWindsorContainer AddFacility<T>() where T : new(), IFacility;

		/// <summary>
		/// Creates and adds an <see cref="T:Castle.MicroKernel.IFacility"/> facility to the container.
		/// 
		/// </summary>
		/// <typeparam name="T">The facility type.</typeparam><param name="onCreate">The callback for creation.</param>
		/// <returns/>
		public IWindsorContainer AddFacility<T>(Action<T> onCreate) where T : new(), IFacility;

		/// <summary>
		/// Gets a child container instance by name.
		/// 
		/// </summary>
		/// <param name="name">The container's name.</param>
		/// <returns>
		/// The child container instance or null
		/// </returns>
		public IWindsorContainer GetChildContainer(string name);

		/// <summary>
		/// Runs the <paramref name="installers"/> so that they can register components in the container. For details see the documentation at http://j.mp/WindsorInstall
		/// 
		/// </summary>
		/// 
		/// <remarks>
		/// In addition to instantiating and passing every installer inline you can use helper methods on <see cref="T:Castle.Windsor.Installer.FromAssembly"/> class to automatically instantiate and run your installers.
		///               You can also use <see cref="N:Castle.Windsor.Configuration"/> class to install components and/or run aditional installers specofied in a configuration file.
		/// 
		/// </remarks>
		/// 
		/// <returns>
		/// The container.
		/// </returns>
		/// 
		/// <example>
		/// 
		/// <code>
		/// container.Install(new YourInstaller1(), new YourInstaller2(), new YourInstaller3());
		/// 
		/// </code>
		/// 
		/// </example>
		/// 
		/// <example>
		/// 
		/// <code>
		/// container.Install(FromAssembly.This(), Configuration.FromAppConfig(), new SomeOtherInstaller());
		/// 
		/// </code>
		/// 
		/// </example>
		public IWindsorContainer Install(params IWindsorInstaller[] installers);

		/// <summary>
		/// Registers the components with the <see cref="T:Castle.Windsor.IWindsorContainer"/>. The instances of <see cref="T:Castle.MicroKernel.Registration.IRegistration"/> are produced by fluent registration API.
		///               Most common entry points are <see cref="M:Castle.MicroKernel.Registration.Component.For``1"/> method to register a single type or (recommended in most cases)
		///               <see cref="M:Castle.MicroKernel.Registration.AllTypes.FromThisAssembly"/>.
		///               Let the Intellisense drive you through the fluent API past those entry points. For details see the documentation at http://j.mp/WindsorApi
		/// 
		/// </summary>
		/// 
		/// <example>
		/// 
		/// <code>
		/// container.Register(Component.For&lt;IService&gt;().ImplementedBy&lt;DefaultService&gt;().LifestyleTransient());
		/// 
		/// </code>
		/// 
		/// </example>
		/// 
		/// <example>
		/// 
		/// <code>
		/// container.Register(Classes.FromThisAssembly().BasedOn&lt;IService&gt;().WithServiceDefaultInterfaces().Configure(c =&gt; c.LifestyleTransient()));
		/// 
		/// </code>
		/// 
		/// </example>
		/// <param name="registrations">The component registrations created by <see cref="M:Castle.MicroKernel.Registration.Component.For``1"/>, <see cref="M:Castle.MicroKernel.Registration.AllTypes.FromThisAssembly"/> or different entry method to the fluent API.</param>
		/// <returns>
		/// The container.
		/// </returns>
		public IWindsorContainer Register(params IRegistration[] registrations);

		/// <summary>
		/// Releases a component instance
		/// 
		/// </summary>
		/// <param name="instance"/>
		public virtual void Release(object instance);

		/// <summary>
		/// Removes (unregisters) a subcontainer.  The components exposed by this container
		///               will no longer be accessible to the child container.
		/// 
		/// </summary>
		/// <param name="childContainer"/>
		public virtual void RemoveChildContainer(IWindsorContainer childContainer);

		/// <summary>
		/// Returns a component instance by the service
		/// 
		/// </summary>
		/// <param name="service"/><param name="arguments"/>
		/// <returns/>
		public virtual object Resolve(Type service, IDictionary arguments);

		/// <summary>
		/// Returns a component instance by the service
		/// 
		/// </summary>
		/// <param name="service"/><param name="argumentsAsAnonymousType"/>
		/// <returns/>
		public virtual object Resolve(Type service, object argumentsAsAnonymousType);

		/// <summary>
		/// Returns a component instance by the service
		/// 
		/// </summary>
		/// <param name="service"/>
		/// <returns/>
		public virtual object Resolve(Type service);

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/><param name="service"/>
		/// <returns/>
		public virtual object Resolve(string key, Type service);

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/><param name="service"/><param name="arguments"/>
		/// <returns/>
		public virtual object Resolve(string key, Type service, IDictionary arguments);

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/><param name="service"/><param name="argumentsAsAnonymousType"/>
		/// <returns/>
		public virtual object Resolve(string key, Type service, object argumentsAsAnonymousType);

		/// <summary>
		/// Returns a component instance by the service
		/// 
		/// </summary>
		/// <typeparam name="T"/><param name="arguments"/>
		/// <returns/>
		public T Resolve<T>(IDictionary arguments);

		/// <summary>
		/// Returns a component instance by the service
		/// 
		/// </summary>
		/// <typeparam name="T"/><param name="argumentsAsAnonymousType"/>
		/// <returns/>
		public T Resolve<T>(object argumentsAsAnonymousType);

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/><param name="arguments"/>
		/// <returns/>
		public virtual T Resolve<T>(string key, IDictionary arguments);

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/><param name="argumentsAsAnonymousType"/>
		/// <returns/>
		public virtual T Resolve<T>(string key, object argumentsAsAnonymousType);

		/// <summary>
		/// Returns a component instance by the service
		/// 
		/// </summary>
		/// <typeparam name="T"/>
		/// <returns/>
		public T Resolve<T>();

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/>
		/// <returns/>
		public virtual T Resolve<T>(string key);

		/// <summary>
		/// Resolve all valid components that match this type.
		/// 
		/// </summary>
		/// <typeparam name="T">The service type</typeparam>
		public T[] ResolveAll<T>();

		public Array ResolveAll(Type service);
		public Array ResolveAll(Type service, IDictionary arguments);
		public Array ResolveAll(Type service, object argumentsAsAnonymousType);

		/// <summary>
		/// Resolve all valid components that match this type.
		///               <typeparam name="T">The service type</typeparam><param name="arguments">Arguments to resolve the service</param>
		/// </summary>
		public T[] ResolveAll<T>(IDictionary arguments);

		/// <summary>
		/// Resolve all valid components that match this type.
		///               <typeparam name="T">The service type</typeparam><param name="argumentsAsAnonymousType">Arguments to resolve the service</param>
		/// </summary>
		public T[] ResolveAll<T>(object argumentsAsAnonymousType);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For(classType).Named(key)) or generic version instead.")]
		public virtual IWindsorContainer AddComponent(string key, Type classType);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For(serviceType).ImplementedBy(classType).Named(key)) or generic version instead.")]
		public virtual IWindsorContainer AddComponent(string key, Type serviceType, Type classType);

		[Obsolete("Use Register(Component.For<T>()) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddComponent<T>();

		[Obsolete("Use Register(Component.For<T>().Named(key)) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddComponent<T>(string key);

		[Obsolete("Use Register(Component.For<I>().ImplementedBy<T>().Named(key)) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddComponent<I, T>(string key) where T : class;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For<I>().ImplementedBy<T>()) instead.")]
		public IWindsorContainer AddComponent<I, T>() where T : class;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For(classType).Named(key).Lifestyle.Is(lifestyle)) or generic version instead.")]
		public IWindsorContainer AddComponentLifeStyle(string key, Type classType, LifestyleType lifestyle);

		[Obsolete("Use Register(Component.For(serviceType).ImplementedBy(classType).Named(key).Lifestyle.Is(lifestyle)) or generic version instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddComponentLifeStyle(string key, Type serviceType, Type classType, LifestyleType lifestyle);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For<T>().Lifestyle.Is(lifestyle)) instead.")]
		public IWindsorContainer AddComponentLifeStyle<T>(LifestyleType lifestyle);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For<I>().ImplementedBy<T>().Lifestyle.Is(lifestyle)) instead.")]
		public IWindsorContainer AddComponentLifeStyle<I, T>(LifestyleType lifestyle) where T : class;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For<T>().Named(key).Lifestyle.Is(lifestyle)) instead.")]
		public IWindsorContainer AddComponentLifeStyle<T>(string key, LifestyleType lifestyle);

		[Obsolete("Use Register(Component.For<I>().ImplementedBy<T>().Named(key).Lifestyle.Is(lifestyle)) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddComponentLifeStyle<I, T>(string key, LifestyleType lifestyle) where T : class;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For<I>().ImplementedBy<T>().ExtendedProperties(extendedProperties)) instead.")]
		public IWindsorContainer AddComponentProperties<I, T>(IDictionary extendedProperties) where T : class;

		[Obsolete("Use Register(Component.For<I>().ImplementedBy<T>().Named(key).ExtendedProperties(extendedProperties)) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddComponentProperties<I, T>(string key, IDictionary extendedProperties) where T : class;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For(classType).Named(key).ExtendedProperties(extendedProperties)) or generic version instead.")]
		public virtual IWindsorContainer AddComponentWithProperties(string key, Type classType, IDictionary extendedProperties);

		[Obsolete("Use Register(Component.For(serviceType).ImplementedBy(classType).Named(key).ExtendedProperties(extendedProperties)) or generic version instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual IWindsorContainer AddComponentWithProperties(string key, Type serviceType, Type classType, IDictionary extendedProperties);

		[Obsolete("Use Register(Component.For<T>().ExtendedProperties(extendedProperties)) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddComponentWithProperties<T>(IDictionary extendedProperties);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Register(Component.For<T>().Named(key).ExtendedProperties(extendedProperties)) instead.")]
		public IWindsorContainer AddComponentWithProperties<T>(string key, IDictionary extendedProperties);

		/// <summary>
		/// Registers a facility within the container.
		/// 
		/// </summary>
		/// <param name="idInConfiguration"/><param name="facility"/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use AddFacility(IFacility) instead.")]
		public virtual IWindsorContainer AddFacility(string idInConfiguration, IFacility facility);

		/// <summary>
		/// Creates and adds an <see cref="T:Castle.MicroKernel.IFacility"/> facility to the container.
		/// 
		/// </summary>
		/// <typeparam name="T">The facility type.</typeparam><param name="idInConfiguration"/>
		/// <returns/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use AddFacility<TFacility>() instead.")]
		public IWindsorContainer AddFacility<T>(string idInConfiguration) where T : new(), IFacility;

		/// <summary>
		/// Creates and adds an <see cref="T:Castle.MicroKernel.IFacility"/> facility to the container.
		/// 
		/// </summary>
		/// <typeparam name="T">The facility type.</typeparam><param name="idInConfiguration"/><param name="configureFacility">The callback for creation.</param>
		/// <returns/>
		[Obsolete("Use AddFacility<TFacility>(Action<TFacility>) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IWindsorContainer AddFacility<T>(string idInConfiguration, Action<T> configureFacility) where T : new(), IFacility;

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/><param name="arguments"/>
		/// <returns/>
		[Obsolete("Use Resolve<object>(key, arguments) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual object Resolve(string key, IDictionary arguments);

		/// <summary>
		/// Returns a component instance by the key
		/// 
		/// </summary>
		/// <param name="key"/><param name="argumentsAsAnonymousType"/>
		/// <returns/>
		[Obsolete("Use Resolve<object>(key, argumentsAsAnonymousType) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual object Resolve(string key, object argumentsAsAnonymousType);

		public IComponentsInstaller Installer { get; }

		/// <summary>
		/// Returns the inner instance of the MicroKernel
		/// 
		/// </summary>
		public virtual IKernel Kernel { get; }

		/// <summary>
		/// Gets the container's name
		/// 
		/// </summary>
		/// 
		/// <remarks>
		/// Only useful when child containers are being used
		/// 
		/// </remarks>
		/// 
		/// <value>
		/// The container's name.
		/// </value>
		public string Name { get; }

		/// <summary>
		/// Gets or sets the parent container if this instance
		///               is a sub container.
		/// 
		/// </summary>
		public virtual IWindsorContainer Parent { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Resolve(key, new Arguments()) or Resolve<TService>(key) instead.")]
		public virtual object this[string key] { get; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Resolve(service) or generic version instead.")]
		public virtual object this[Type service] { get; }
	}
}
