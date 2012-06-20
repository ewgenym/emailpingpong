using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Data;
using ConversationTree.ViewModels;

namespace ConversationTree.Utils
{
	/// <summary>
	/// This class simply takes an enum and uses some reflection to obtain
	/// the friendly name for the enum. Where the friendlier name is
	/// obtained using the LocalizableDescriptionAttribute, which holds the localized
	/// value read from the resource file for the enum
	/// </summary>
	[ValueConversion(typeof(object), typeof(String))]
	public class EnumToFriendlyNameConverter : IValueConverter
	{
		#region IValueConverter implementation

		/// <summary>
		/// Convert value for binding from source object
		/// </summary>
		public object Convert(object value, Type targetType,
				object parameter, CultureInfo culture)
		{
			// To get around the stupid WPF designer bug
			if (value != null)
			{
				if (value is Array)
				{
					var res = new string[((Array)value).Length];
					int i = 0;
					foreach (var el in (Array)value)
					{
						object convert;
						ConvertValue(value, out convert);
						res[i] = (string)convert;
						i++;
					}
					return res;
				}
				else
				{
					object convert;
					if (ConvertValue(value, out convert)) return convert;
				}
			}

			return string.Empty;
		}

		private static bool ConvertValue(object value, out object convert)
		{
			convert = string.Empty;
			FieldInfo fi = value.GetType().GetField(value.ToString());

			// To get around the stupid WPF designer bug
			if (fi != null)
			{
				var attributes = (DisplayStringAttribute[]) fi.GetCustomAttributes(typeof (DisplayStringAttribute), false);

				{
					convert = ((attributes.Length > 0) && (!String.IsNullOrEmpty(attributes[0].Value)))
					          	? attributes[0].Value
					          	: value.ToString();
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// ConvertBack value from binding back to source object
		/// </summary>
		public object ConvertBack(object value, Type targetType,
			object parameter, CultureInfo culture)
		{
			//throw new Exception("Cant convert back");
			return "1213";
		}
		#endregion
	}
}
