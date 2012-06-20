// Type: System.IO.Path
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.IO
{
	/// <summary>
	/// Performs operations on <see cref="T:System.String"/> instances that contain file or directory path information. These operations are performed in a cross-platform manner.
	/// </summary>
	/// <filterpriority>1</filterpriority>
	[ComVisible(true)]
	public static class Path
	{
		/// <summary>
		/// Provides a platform-specific character used to separate directory levels in a path string that reflects a hierarchical file system organization.
		/// </summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char DirectorySeparatorChar;

		/// <summary>
		/// Provides a platform-specific alternate character used to separate directory levels in a path string that reflects a hierarchical file system organization.
		/// </summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char AltDirectorySeparatorChar;

		/// <summary>
		/// Provides a platform-specific volume separator character.
		/// </summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char VolumeSeparatorChar;

		/// <summary>
		/// Provides a platform-specific array of characters that cannot be specified in path string arguments passed to members of the <see cref="T:System.IO.Path"/> class.
		/// </summary>
		/// 
		/// <returns>
		/// A character array of invalid path characters for the current platform.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		[Obsolete("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")] public static readonly char[] InvalidPathChars;

		/// <summary>
		/// A platform-specific separator character used to separate path strings in environment variables.
		/// </summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char PathSeparator;

		/// <summary>
		/// Changes the extension of a path string.
		/// </summary>
		/// 
		/// <returns>
		/// A string containing the modified path information.On Windows-based desktop platforms, if <paramref name="path"/> is null or an empty string (""), the path information is returned unmodified. If <paramref name="extension"/> is null, the returned string contains the specified path with its extension removed. If <paramref name="path"/> has no extension, and <paramref name="extension"/> is not null, the returned path string contains <paramref name="extension"/> appended to the end of <paramref name="path"/>.
		/// </returns>
		/// <param name="path">The path information to modify. The path cannot contain any of the characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </param><param name="extension">The new extension (with or without a leading period). Specify null to remove an existing extension from <paramref name="path"/>. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>.</exception><filterpriority>1</filterpriority>
		public static string ChangeExtension(string path, string extension);

		/// <summary>
		/// Returns the directory information for the specified path string.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> containing directory information for <paramref name="path"/>, or null if <paramref name="path"/> denotes a root directory, is the empty string (""), or is null. Returns <see cref="F:System.String.Empty"/> if <paramref name="path"/> does not contain directory information.
		/// </returns>
		/// <param name="path">The path of a file or directory. </param><exception cref="T:System.ArgumentException">The <paramref name="path"/> parameter contains invalid characters, is empty, or contains only white spaces. </exception><exception cref="T:System.IO.PathTooLongException">The <paramref name="path"/> parameter is longer than the system-defined maximum length.</exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public static string GetDirectoryName(string path);

		/// <summary>
		/// Gets an array containing the characters that are not allowed in path names.
		/// </summary>
		/// 
		/// <returns>
		/// An array containing the characters that are not allowed in path names.
		/// </returns>
		public static char[] GetInvalidPathChars();

		/// <summary>
		/// Gets an array containing the characters that are not allowed in file names.
		/// </summary>
		/// 
		/// <returns>
		/// An array containing the characters that are not allowed in file names.
		/// </returns>
		public static char[] GetInvalidFileNameChars();

		/// <summary>
		/// Returns the extension of the specified path string.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> containing the extension of the specified path (including the "."), null, or <see cref="F:System.String.Empty"/>. If <paramref name="path"/> is null, GetExtension returns null. If <paramref name="path"/> does not have extension information, GetExtension returns Empty.
		/// </returns>
		/// <param name="path">The path string from which to get the extension. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>.  </exception><filterpriority>1</filterpriority>
		public static string GetExtension(string path);

		/// <summary>
		/// Returns the absolute path for the specified path string.
		/// </summary>
		/// 
		/// <returns>
		/// A string containing the fully qualified location of <paramref name="path"/>, such as "C:\MyFile.txt".
		/// </returns>
		/// <param name="path">The file or directory for which to obtain absolute path information. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> is a zero-length string, contains only white space, or contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>.-or- The system could not retrieve the absolute path. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception><exception cref="T:System.ArgumentNullException"><paramref name="path"/> is null. </exception><exception cref="T:System.NotSupportedException"><paramref name="path"/> contains a colon (":") that is not part of a volume identifier (for example, "c:\"). </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*"/></PermissionSet>
		[SecuritySafeCritical]
		public static string GetFullPath(string path);

		/// <summary>
		/// Returns the file name and extension of the specified path string.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> consisting of the characters after the last directory character in <paramref name="path"/>. If the last character of <paramref name="path"/> is a directory or volume separator character, this method returns <see cref="F:System.String.Empty"/>. If <paramref name="path"/> is null, this method returns null.
		/// </returns>
		/// <param name="path">The path string from which to obtain the file name and extension. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </exception><filterpriority>1</filterpriority>
		public static string GetFileName(string path);

		/// <summary>
		/// Returns the file name of the specified path string without the extension.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> containing the string returned by <see cref="M:System.IO.Path.GetFileName(System.String)"/>, minus the last period (.) and all characters following it.
		/// </returns>
		/// <param name="path">The path of the file. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>.</exception><filterpriority>1</filterpriority>
		public static string GetFileNameWithoutExtension(string path);

		/// <summary>
		/// Gets the root directory information of the specified path.
		/// </summary>
		/// 
		/// <returns>
		/// A string containing the root directory of <paramref name="path"/>, such as "C:\", or null if <paramref name="path"/> is null, or an empty string if <paramref name="path"/> does not contain root directory information.
		/// </returns>
		/// <param name="path">The path from which to obtain root directory information. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>.-or- <see cref="F:System.String.Empty"/> was passed to <paramref name="path"/>. </exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public static string GetPathRoot(string path);

		/// <summary>
		/// Returns the path of the current system's temporary folder.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> containing the path information of a temporary directory.
		/// </returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
		[SecuritySafeCritical]
		public static string GetTempPath();

		/// <summary>
		/// Returns a random folder name or file name.
		/// </summary>
		/// 
		/// <returns>
		/// A random folder name or file name.
		/// </returns>
		public static string GetRandomFileName();

		/// <summary>
		/// Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.String"/> containing the full path of the temporary file.
		/// </returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs, such as no unique temporary file name is available.- or -This method was unable to create a temporary file.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
		[SecuritySafeCritical]
		public static string GetTempFileName();

		/// <summary>
		/// Determines whether a path includes a file name extension.
		/// </summary>
		/// 
		/// <returns>
		/// true if the characters that follow the last directory separator (\\ or /) or volume separator (:) in the path include a period (.) followed by one or more characters; otherwise, false.
		/// </returns>
		/// <param name="path">The path to search for an extension. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </exception><filterpriority>1</filterpriority>
		public static bool HasExtension(string path);

		/// <summary>
		/// Gets a value indicating whether the specified path string contains absolute or relative path information.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="path"/> contains an absolute path; otherwise, false.
		/// </returns>
		/// <param name="path">The path to test. </param><exception cref="T:System.ArgumentException"><paramref name="path"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </exception><filterpriority>1</filterpriority>
		public static bool IsPathRooted(string path);

		/// <summary>
		/// Combines two strings into a path.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If <paramref name="path2"/> contains an absolute path, this method returns <paramref name="path2"/>.
		/// </returns>
		/// <param name="path1">The first path to combine. </param><param name="path2">The second path to combine. </param><exception cref="T:System.ArgumentException"><paramref name="path1"/> or <paramref name="path2"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </exception><exception cref="T:System.ArgumentNullException"><paramref name="path1"/> or <paramref name="path2"/> is null. </exception><filterpriority>1</filterpriority>
		public static string Combine(string path1, string path2);

		/// <summary>
		/// Combines three strings into a path.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the combined paths.
		/// </returns>
		/// <param name="path1">The first path to combine. </param><param name="path2">The second path to combine. </param><param name="path3">The third path to combine.</param><exception cref="T:System.ArgumentException"><paramref name="path1"/>, <paramref name="path2"/>, or <paramref name="path3"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </exception><exception cref="T:System.ArgumentNullException"><paramref name="path1"/>, <paramref name="path2"/>, or <paramref name="path3"/> is null. </exception>
		public static string Combine(string path1, string path2, string path3);

		/// <summary>
		/// Combines four strings into a path.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the combined paths.
		/// </returns>
		/// <param name="path1">The first path to combine. </param><param name="path2">The second path to combine. </param><param name="path3">The third path to combine.</param><param name="path4">The fourth path to combine.</param><exception cref="T:System.ArgumentException"><paramref name="path1"/>, <paramref name="path2"/>, <paramref name="path3"/>, or <paramref name="path4"/> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </exception><exception cref="T:System.ArgumentNullException"><paramref name="path1"/>, <paramref name="path2"/>, <paramref name="path3"/>, or <paramref name="path4"/> is null. </exception>
		public static string Combine(string path1, string path2, string path3, string path4);

		/// <summary>
		/// Combines an array of strings into a path.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the combined paths.
		/// </returns>
		/// <param name="paths">An array of parts of the path.</param><exception cref="T:System.ArgumentException">One of the strings in the array contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars"/>. </exception><exception cref="T:System.ArgumentNullException">One of the strings in the array is null. </exception>
		public static string Combine(params string[] paths);
	}
}
