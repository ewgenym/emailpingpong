// Type: System.Windows.Application
// Assembly: PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\PresentationFramework.dll

using System;
using System.Collections;
using System.Reflection;
using System.Security;
using System.Windows.Markup;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Threading;

namespace System.Windows
{
	/// <summary>
	/// Encapsulates a Windows Presentation Foundation (WPF) application.
	/// </summary>
	public class Application : DispatcherObject, IHaveResources, IQueryAmbient
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Windows.Application"/> class.
		/// </summary>
		/// <exception cref="T:System.InvalidOperationException">More than one instance of the <see cref="T:System.Windows.Application"/> class is created per <see cref="T:System.AppDomain"/>.</exception>
		[SecurityCritical]
		public Application();

		/// <summary>
		/// Starts a Windows Presentation Foundation (WPF) application.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Int32"/> application exit code that is returned to the operating system when the application shuts down. By default, the exit code value is 0.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException"><see cref="M:System.Windows.Application.Run"/> is called from a browser-hosted application (for example, an XAML browser application (XBAP)).</exception>
		public int Run();

		/// <summary>
		/// Starts a Windows Presentation Foundation (WPF) application and opens the specified window.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Int32"/> application exit code that is returned to the operating system when the application shuts down. By default, the exit code value is 0.
		/// </returns>
		/// <param name="window">A <see cref="T:System.Windows.Window"/> that opens automatically when an application starts.</param><exception cref="T:System.InvalidOperationException"><see cref="M:System.Windows.Application.Run"/> is called from a browser-hosted application (for example, an XAML browser application (XBAP)).</exception>
		[SecurityCritical]
		public int Run(Window window);

		/// <summary>
		/// Shuts down an application.
		/// </summary>
		public void Shutdown();

		/// <summary>
		/// Shuts down an application that returns the specified exit code to the operating system.
		/// </summary>
		/// <param name="exitCode">An integer exit code for an application. The default exit code is 0.</param>
		[SecurityCritical]
		public void Shutdown(int exitCode);

		/// <summary>
		/// Searches for a user interface (UI) resource, such as a <see cref="T:System.Windows.Style"/> or <see cref="T:System.Windows.Media.Brush"/>, with the specified key, and throws an exception if the requested resource is not found (see Resources Overview).
		/// </summary>
		/// 
		/// <returns>
		/// The requested resource object. If the requested resource is not found, a <see cref="T:System.Windows.ResourceReferenceKeyNotFoundException"/> is thrown.
		/// </returns>
		/// <param name="resourceKey">The name of the resource to find.</param><exception cref="T:System.Windows.ResourceReferenceKeyNotFoundException">The resource cannot be found.</exception>
		public object FindResource(object resourceKey);

		/// <summary>
		/// Searches for the specified resource.
		/// </summary>
		/// 
		/// <returns>
		/// The requested resource object. If the requested resource is not found, a null reference is returned.
		/// </returns>
		/// <param name="resourceKey">The name of the resource to find.</param>
		public object TryFindResource(object resourceKey);

		/// <summary>
		/// Loads a XAML file that is located at the specified uniform resource identifier (URI) and converts it to an instance of the object that is specified by the root element of the XAML file.
		/// </summary>
		/// <param name="component">An object of the same type as the root element of the XAML file.</param><param name="resourceLocator">A <see cref="T:System.Uri"/> that maps to a relative XAML file.</param><exception cref="T:System.ArgumentNullException"><paramref name="component"/> is null.</exception><exception cref="T:System.ArgumentNullException"><paramref name="resourceLocator"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Uri.OriginalString"/> property of the <paramref name="resourceLocator"/><see cref="T:System.Uri"/> parameter is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="resourceLocator"/> is an absolute URI.</exception><exception cref="T:System.Exception"><paramref name="component"/> is of a type that does not match the root element of the XAML file.</exception>
		[SecurityCritical]
		public static void LoadComponent(object component, Uri resourceLocator);

		/// <summary>
		/// Loads a XAML file that is located at the specified uniform resource identifier (URI), and converts it to an instance of the object that is specified by the root element of the XAML file.
		/// </summary>
		/// 
		/// <returns>
		/// An instance of the root element specified by the XAML file loaded.
		/// </returns>
		/// <param name="resourceLocator">A <see cref="T:System.Uri"/> that maps to a relative XAML file.</param><exception cref="T:System.ArgumentNullException"><paramref name="resourceLocator"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Uri.OriginalString"/> property of the <paramref name="resourceLocator"/><see cref="T:System.Uri"/> parameter is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="resourceLocator"/> is an absolute URI.</exception><exception cref="T:System.Exception">The file is not a XAML file.</exception>
		public static object LoadComponent(Uri resourceLocator);

		/// <summary>
		/// Returns a resource stream for a resource data file that is located at the specified <see cref="T:System.Uri"/> (see WPF Application Resource, Content, and Data Files).
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Resources.StreamResourceInfo"/> that contains a resource stream for resource data file that is located at the specified <see cref="T:System.Uri"/>. If the resource located at the specified <see cref="T:System.Uri"/> is not found, null is returned.
		/// </returns>
		/// <param name="uriResource">The <see cref="T:System.Uri"/> that maps to an embedded resource.</param><exception cref="T:System.ArgumentNullException">The <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetResourceStream(System.Uri)"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Uri.OriginalString"/> property of the <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetResourceStream(System.Uri)"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetResourceStream(System.Uri)"/> is either not relative, or is absolute but not in the pack://application:,,,/ form.</exception>
		[SecurityCritical]
		public static StreamResourceInfo GetResourceStream(Uri uriResource);

		/// <summary>
		/// Returns a resource stream for a content data file that is located at the specified <see cref="T:System.Uri"/> (see WPF Application Resource, Content, and Data Files).
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Resources.StreamResourceInfo"/> that contains a content data file that is located at the specified <see cref="T:System.Uri"/>. If a loose resource is not found, null is returned.
		/// </returns>
		/// <param name="uriContent">The relative <see cref="T:System.Uri"/> that maps to a loose resource.</param><exception cref="T:System.ArgumentNullException">The <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetContentStream(System.Uri)"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Uri.OriginalString"/> property of the <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetContentStream(System.Uri)"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetContentStream(System.Uri)"/> is an absolute <see cref="T:System.Uri"/>.</exception>
		[SecurityCritical]
		public static StreamResourceInfo GetContentStream(Uri uriContent);

		/// <summary>
		/// Returns a resource stream for a site-of-origin data file that is located at the specified <see cref="T:System.Uri"/> (see WPF Application Resource, Content, and Data Files).
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Resources.StreamResourceInfo"/> that contains a resource stream for a site-of-origin data file that is located at the specified <see cref="T:System.Uri"/>. If the loose resource is not found, null is returned.
		/// </returns>
		/// <param name="uriRemote">The <see cref="T:System.Uri"/> that maps to a loose resource at the site of origin.</param><exception cref="T:System.ArgumentNullException">The <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetRemoteStream(System.Uri)"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Uri.OriginalString"/> property of the <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetRemoteStream(System.Uri)"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="T:System.Uri"/> that is passed to <see cref="M:System.Windows.Application.GetRemoteStream(System.Uri)"/> is either not relative, or is absolute but not in the pack://siteoforigin:,,,/ form.</exception>
		[SecurityCritical]
		public static StreamResourceInfo GetRemoteStream(Uri uriRemote);

		/// <summary>
		/// Retrieves a cookie for the location specified by a <see cref="T:System.Uri"/>.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> value, if the cookie exists; otherwise, a <see cref="T:System.ComponentModel.Win32Exception"/> is thrown.
		/// </returns>
		/// <param name="uri">The <see cref="T:System.Uri"/> that specifies the location for which a cookie was created.</param><exception cref="T:System.ComponentModel.Win32Exception">A Win32 error is raised by the InternetGetCookie function (called by <see cref="M:System.Windows.Application.GetCookie(System.Uri)"/>) if a problem occurs when attempting to retrieve the specified cookie.</exception>
		public static string GetCookie(Uri uri);

		/// <summary>
		/// Creates a cookie for the location specified by a <see cref="T:System.Uri"/>.
		/// </summary>
		/// <param name="uri">The <see cref="T:System.Uri"/> that specifies the location for which the cookie should be created.</param><param name="value">The <see cref="T:System.String"/> that contains the cookie data.</param><exception cref="T:System.ComponentModel.Win32Exception">A Win32 error is raised by the InternetSetCookie function (called by <see cref="M:System.Windows.Application.SetCookie(System.Uri,System.String)"/>) if a problem occurs when attempting to create the specified cookie.</exception>
		public static void SetCookie(Uri uri, string value);

		/// <summary>
		/// Queries for whether a specified ambient property is available in the current scope.
		/// </summary>
		/// 
		/// <returns>
		/// true if the requested ambient property is available; otherwise, false.
		/// </returns>
		/// <param name="propertyName">The name of the requested ambient property.</param>
		bool IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.Startup"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.StartupEventArgs"/> that contains the event data.</param>
		protected virtual void OnStartup(StartupEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.Exit"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.Windows.ExitEventArgs"/> that contains the event data.</param>
		protected virtual void OnExit(ExitEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.Activated"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
		protected virtual void OnActivated(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.Deactivated"/> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
		protected virtual void OnDeactivated(EventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.SessionEnding"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.SessionEndingCancelEventArgs"/> that contains the event data.</param>
		protected virtual void OnSessionEnding(SessionEndingCancelEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.Navigating"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigatingCancelEventArgs"/> that contains the event data.</param>
		protected virtual void OnNavigating(NavigatingCancelEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.Navigated"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationEventArgs"/> that contains the event data.</param>
		protected virtual void OnNavigated(NavigationEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.NavigationProgress"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationProgressEventArgs"/> that contains the event data.</param>
		protected virtual void OnNavigationProgress(NavigationProgressEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.NavigationFailed"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationFailedEventArgs"/> that contains the event data.</param>
		protected virtual void OnNavigationFailed(NavigationFailedEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.LoadCompleted"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationEventArgs"/> that contains the event data.</param>
		protected virtual void OnLoadCompleted(NavigationEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.NavigationStopped"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Navigation.NavigationEventArgs"/> that contains the event data. </param>
		protected virtual void OnNavigationStopped(NavigationEventArgs e);

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Application.FragmentNavigation"/> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.Windows.Navigation.FragmentNavigationEventArgs"/> that contains the event data.</param>
		protected virtual void OnFragmentNavigation(FragmentNavigationEventArgs e);

		/// <summary>
		/// Gets the <see cref="T:System.Windows.Application"/> object for the current <see cref="T:System.AppDomain"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The <see cref="T:System.Windows.Application"/> object for the current <see cref="T:System.AppDomain"/>.
		/// </returns>
		public static Application Current { get; }

		/// <summary>
		/// Gets the instantiated windows in an application.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.WindowCollection"/> that contains references to all window objects in the current <see cref="T:System.AppDomain"/>.
		/// </returns>
		public WindowCollection Windows { get; }

		/// <summary>
		/// Gets or sets the main window of the application.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.Window"/> that is designated as the main application window.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException"><see cref="P:System.Windows.Application.MainWindow"/> is set from an application that's hosted in a browser, such as an XAML browser applications (XBAPs).</exception>
		public Window MainWindow { get; set; }

		/// <summary>
		/// Gets or sets the condition that causes the <see cref="M:System.Windows.Application.Shutdown"/> method to be called.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.ShutdownMode"/> enumeration value. The default value is <see cref="F:System.Windows.ShutdownMode.OnLastWindowClose"/>.
		/// </returns>
		public ShutdownMode ShutdownMode { get; set; }

		/// <summary>
		/// Gets or sets a collection of application-scope resources, such as styles and brushes.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Windows.ResourceDictionary"/> object that contains zero or more application-scope resources.
		/// </returns>
		[Ambient]
		public ResourceDictionary Resources { get; set; }

		/// <summary>
		/// Gets or sets a UI that is automatically shown when an application starts.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.Uri"/> that refers to the UI that automatically opens when an application starts.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><see cref="P:System.Windows.Application.StartupUri"/> is set with a value of null.</exception>
		public Uri StartupUri { get; set; }

		/// <summary>
		/// Gets a collection of application-scope properties.
		/// </summary>
		/// 
		/// <returns>
		/// An <see cref="T:System.Collections.IDictionary"/> that contains the application-scope properties.
		/// </returns>
		public IDictionary Properties { get; }

		/// <summary>
		/// Gets or sets the <see cref="T:System.Reflection.Assembly"/> that provides the pack uniform resource identifiers (URIs) for resources in a WPF application.
		/// </summary>
		/// 
		/// <returns>
		/// A reference to the <see cref="T:System.Reflection.Assembly"/> that provides the pack uniform resource identifiers (URIs) for resources in a WPF application.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException">A WPF application has an entry assembly, or <see cref="P:System.Windows.Application.ResourceAssembly"/> has already been set.</exception>
		public static Assembly ResourceAssembly { get; set; }

		/// <summary>
		/// Occurs when the <see cref="M:System.Windows.Application.Run"/> method of the <see cref="T:System.Windows.Application"/> object is called.
		/// </summary>
		public event StartupEventHandler Startup;

		/// <summary>
		/// Occurs just before an application shuts down, and cannot be canceled.
		/// </summary>
		public event ExitEventHandler Exit;

		/// <summary>
		/// Occurs when an application becomes the foreground application.
		/// </summary>
		public event EventHandler Activated;

		/// <summary>
		/// Occurs when an application stops being the foreground application.
		/// </summary>
		public event EventHandler Deactivated;

		/// <summary>
		/// Occurs when the user ends the Windows session by logging off or shutting down the operating system.
		/// </summary>
		public event SessionEndingCancelEventHandler SessionEnding;

		/// <summary>
		/// Occurs when an exception is thrown by an application but not handled.
		/// </summary>
		public event DispatcherUnhandledExceptionEventHandler DispatcherUnhandledException;

		/// <summary>
		/// Occurs when a new navigation is requested by a navigator in the application.
		/// </summary>
		public event NavigatingCancelEventHandler Navigating;

		/// <summary>
		/// Occurs when the content that is being navigated to by a navigator in the application has been found, although it may not have completed loading.
		/// </summary>
		public event NavigatedEventHandler Navigated;

		/// <summary>
		/// Occurs periodically during a download that is being managed by a navigator in the application to provide navigation progress information.
		/// </summary>
		public event NavigationProgressEventHandler NavigationProgress;

		/// <summary>
		/// Occurs when an error occurs while a navigator in the application is navigating to the requested content.
		/// </summary>
		public event NavigationFailedEventHandler NavigationFailed;

		/// <summary>
		/// Occurs when content that was navigated to by a navigator in the application has been loaded, parsed, and has begun rendering.
		/// </summary>
		public event LoadCompletedEventHandler LoadCompleted;

		/// <summary>
		/// Occurs when the StopLoading method of a navigator in the application is called, or when a new navigation is requested by a navigator while a current navigation is in progress.
		/// </summary>
		public event NavigationStoppedEventHandler NavigationStopped;

		/// <summary>
		/// Occurs when a navigator in the application begins navigation to a content fragment, Navigation occurs immediately if the desired fragment is in the current content, or after the source XAML content has been loaded if the desired fragment is in different content.
		/// </summary>
		public event FragmentNavigationEventHandler FragmentNavigation;
	}
}
