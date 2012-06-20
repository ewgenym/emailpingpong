using System;

namespace ConversationTree.ViewModels
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class DisplayStringAttribute : Attribute
	{
		private readonly string _value;
		public string Value
		{
			get { return _value; }
		}

		public string ResourceKey { get; set; }

		public DisplayStringAttribute(string v)
		{
			_value = v;
		}

		public DisplayStringAttribute()
		{
		}
	}
}