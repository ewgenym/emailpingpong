﻿using System;
using System.Linq;
using System.Windows.Markup;

namespace EmailPingPong.UI.Desktop.Utils
{
	public class EnumerationExtension : MarkupExtension
	{
		private Type _enumType;


		public EnumerationExtension(Type enumType)
		{
			if (enumType == null)
				throw new ArgumentNullException("enumType");

			EnumType = enumType;
		}

		public Type EnumType
		{
			get { return _enumType; }
			private set
			{
				if (_enumType == value)
					return;

				var enumType = Nullable.GetUnderlyingType(value) ?? value;

				if (!enumType.IsEnum)
					throw new ArgumentException("Enum type is expected.");

				_enumType = value;
			}
		}

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			var enumValues = Enum.GetValues(EnumType);

			return enumValues
				.Cast<object>()
				.Select(enumValue => new EnumerationMember
			       		{
			       			Value = enumValue,
			       			Description = GetDescription(enumValue)
			       		})
				.ToArray();
		}

		private string GetDescription(object enumValue)
		{
			var descriptionAttribute = EnumType
			  .GetField(enumValue.ToString())
			  .GetCustomAttributes(typeof(DisplayStringAttribute), false)
			  .FirstOrDefault() as DisplayStringAttribute;

			return descriptionAttribute != null
			       	? descriptionAttribute.Value
			       	: enumValue.ToString();
		}

		public class EnumerationMember
		{
			public string Description { get; set; }
			public object Value { get; set; }
		}
	}
}