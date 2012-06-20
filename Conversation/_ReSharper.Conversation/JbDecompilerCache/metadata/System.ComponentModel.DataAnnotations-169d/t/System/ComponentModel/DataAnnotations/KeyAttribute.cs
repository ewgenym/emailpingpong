// Type: System.ComponentModel.DataAnnotations.KeyAttribute
// Assembly: System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.ComponentModel.DataAnnotations.dll

using System;
using System.Runtime;

namespace System.ComponentModel.DataAnnotations
{
	/// <summary>
	/// Denotes one or more properties that uniquely identify an entity.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class KeyAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.ComponentModel.DataAnnotations.KeyAttribute"/> class.
		/// </summary>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public KeyAttribute();
	}
}
