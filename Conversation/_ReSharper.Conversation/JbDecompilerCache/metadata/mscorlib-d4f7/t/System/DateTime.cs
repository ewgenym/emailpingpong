// Type: System.DateTime
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Globalization;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>
	/// Represents an instant in time, typically expressed as a date and time of day.
	/// </summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime>
	{
		/// <summary>
		/// Represents the smallest possible value of <see cref="T:System.DateTime"/>. This field is read-only.
		/// </summary>
		/// <filterpriority>1</filterpriority>
		public static readonly DateTime MinValue;

		/// <summary>
		/// Represents the largest possible value of <see cref="T:System.DateTime"/>. This field is read-only.
		/// </summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><see cref="F:System.DateTime.MaxValue"/> is outside the range of the current culture's default calendar or of a specified culture's default calendar.</exception><filterpriority>1</filterpriority>
		public static readonly DateTime MaxValue;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to a specified number of ticks.
		/// </summary>
		/// <param name="ticks">A date and time expressed in 100-nanosecond units. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="ticks"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception>
		public DateTime(long ticks);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to a specified number of ticks and to Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="ticks">A date and time expressed in 100-nanosecond units. </param><param name="kind">One of the enumeration values that indicates whether <paramref name="ticks"/> specifies a local time, Coordinated Universal Time (UTC), or neither.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="ticks"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><exception cref="T:System.ArgumentException"><paramref name="kind"/> is not one of the <see cref="T:System.DateTimeKind"/> values.</exception>
		public DateTime(long ticks, DateTimeKind kind);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, and day.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param><param name="month">The month (1 through 12). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is less than 1 or greater than 9999.-or- <paramref name="month"/> is less than 1 or greater than 12.-or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>. </exception><exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. </exception>
		public DateTime(int year, int month, int day);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, and day for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through the number of years in <paramref name="calendar"/>). </param><param name="month">The month (1 through the number of months in <paramref name="calendar"/>). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="calendar">The calendar that is used to interpret <paramref name="year"/>, <paramref name="month"/>, and <paramref name="day"/>. </param><exception cref="T:System.ArgumentNullException"><paramref name="calendar"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is not in the range supported by <paramref name="calendar"/>.-or- <paramref name="month"/> is less than 1 or greater than the number of months in <paramref name="calendar"/>.-or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>. </exception><exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. </exception>
		public DateTime(int year, int month, int day, Calendar calendar);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, day, hour, minute, and second.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param><param name="month">The month (1 through 12). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="hour">The hours (0 through 23). </param><param name="minute">The minutes (0 through 59). </param><param name="second">The seconds (0 through 59). </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is less than 1 or greater than 9999. -or- <paramref name="month"/> is less than 1 or greater than 12. -or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>.-or- <paramref name="hour"/> is less than 0 or greater than 23. -or- <paramref name="minute"/> is less than 0 or greater than 59. -or- <paramref name="second"/> is less than 0 or greater than 59. </exception><exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. </exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, day, hour, minute, second, and Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param><param name="month">The month (1 through 12). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="hour">The hours (0 through 23). </param><param name="minute">The minutes (0 through 59). </param><param name="second">The seconds (0 through 59). </param><param name="kind">One of the enumeration values that indicates whether <paramref name="year"/>, <paramref name="month"/>, <paramref name="day"/>, <paramref name="hour"/>, <paramref name="minute"/> and <paramref name="second"/> specify a local time, Coordinated Universal Time (UTC), or neither.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is less than 1 or greater than 9999. -or- <paramref name="month"/> is less than 1 or greater than 12. -or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>.-or- <paramref name="hour"/> is less than 0 or greater than 23. -or- <paramref name="minute"/> is less than 0 or greater than 59. -or- <paramref name="second"/> is less than 0 or greater than 59. </exception><exception cref="T:System.ArgumentException">The specified time parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. -or-<paramref name="kind"/> is not one of the <see cref="T:System.DateTimeKind"/> values.</exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, day, hour, minute, and second for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through the number of years in <paramref name="calendar"/>). </param><param name="month">The month (1 through the number of months in <paramref name="calendar"/>). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="hour">The hours (0 through 23). </param><param name="minute">The minutes (0 through 59). </param><param name="second">The seconds (0 through 59). </param><param name="calendar">The calendar that is used to interpret <paramref name="year"/>, <paramref name="month"/>, and <paramref name="day"/>. </param><exception cref="T:System.ArgumentNullException"><paramref name="calendar"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is not in the range supported by <paramref name="calendar"/>.-or- <paramref name="month"/> is less than 1 or greater than the number of months in <paramref name="calendar"/>.-or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>.-or- <paramref name="hour"/> is less than 0 or greater than 23 -or- <paramref name="minute"/> is less than 0 or greater than 59. -or- <paramref name="second"/> is less than 0 or greater than 59. </exception><exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. </exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, day, hour, minute, second, and millisecond.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param><param name="month">The month (1 through 12). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="hour">The hours (0 through 23). </param><param name="minute">The minutes (0 through 59). </param><param name="second">The seconds (0 through 59). </param><param name="millisecond">The milliseconds (0 through 999). </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is less than 1 or greater than 9999.-or- <paramref name="month"/> is less than 1 or greater than 12.-or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>.-or- <paramref name="hour"/> is less than 0 or greater than 23.-or- <paramref name="minute"/> is less than 0 or greater than 59.-or- <paramref name="second"/> is less than 0 or greater than 59.-or- <paramref name="millisecond"/> is less than 0 or greater than 999. </exception><exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. </exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, day, hour, minute, second, millisecond, and Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param><param name="month">The month (1 through 12). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="hour">The hours (0 through 23). </param><param name="minute">The minutes (0 through 59). </param><param name="second">The seconds (0 through 59). </param><param name="millisecond">The milliseconds (0 through 999). </param><param name="kind">One of the enumeration values that indicates whether <paramref name="year"/>, <paramref name="month"/>, <paramref name="day"/>, <paramref name="hour"/>, <paramref name="minute"/>, <paramref name="second"/>, and <paramref name="millisecond"/> specify a local time, Coordinated Universal Time (UTC), or neither.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is less than 1 or greater than 9999.-or- <paramref name="month"/> is less than 1 or greater than 12.-or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>.-or- <paramref name="hour"/> is less than 0 or greater than 23.-or- <paramref name="minute"/> is less than 0 or greater than 59.-or- <paramref name="second"/> is less than 0 or greater than 59.-or- <paramref name="millisecond"/> is less than 0 or greater than 999. </exception><exception cref="T:System.ArgumentException">The specified time parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. -or-<paramref name="kind"/> is not one of the <see cref="T:System.DateTimeKind"/> values.</exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, day, hour, minute, second, and millisecond for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through the number of years in <paramref name="calendar"/>). </param><param name="month">The month (1 through the number of months in <paramref name="calendar"/>). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="hour">The hours (0 through 23). </param><param name="minute">The minutes (0 through 59). </param><param name="second">The seconds (0 through 59). </param><param name="millisecond">The milliseconds (0 through 999). </param><param name="calendar">The calendar that is used to interpret <paramref name="year"/>, <paramref name="month"/>, and <paramref name="day"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="calendar"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is not in the range supported by <paramref name="calendar"/>.-or- <paramref name="month"/> is less than 1 or greater than the number of months in <paramref name="calendar"/>.-or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>.-or- <paramref name="hour"/> is less than 0 or greater than 23.-or- <paramref name="minute"/> is less than 0 or greater than 59.-or- <paramref name="second"/> is less than 0 or greater than 59.-or- <paramref name="millisecond"/> is less than 0 or greater than 999. </exception><exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. </exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar);

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.DateTime"/> structure to the specified year, month, day, hour, minute, second, millisecond, and Coordinated Universal Time (UTC) or local time for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through the number of years in <paramref name="calendar"/>). </param><param name="month">The month (1 through the number of months in <paramref name="calendar"/>). </param><param name="day">The day (1 through the number of days in <paramref name="month"/>). </param><param name="hour">The hours (0 through 23). </param><param name="minute">The minutes (0 through 59). </param><param name="second">The seconds (0 through 59). </param><param name="millisecond">The milliseconds (0 through 999). </param><param name="calendar">The calendar that is used to interpret <paramref name="year"/>, <paramref name="month"/>, and <paramref name="day"/>.</param><param name="kind">One of the enumeration values that indicates whether <paramref name="year"/>, <paramref name="month"/>, <paramref name="day"/>, <paramref name="hour"/>, <paramref name="minute"/>, <paramref name="second"/>, and <paramref name="millisecond"/> specify a local time, Coordinated Universal Time (UTC), or neither.</param><exception cref="T:System.ArgumentNullException"><paramref name="calendar"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is not in the range supported by <paramref name="calendar"/>.-or- <paramref name="month"/> is less than 1 or greater than the number of months in <paramref name="calendar"/>.-or- <paramref name="day"/> is less than 1 or greater than the number of days in <paramref name="month"/>.-or- <paramref name="hour"/> is less than 0 or greater than 23.-or- <paramref name="minute"/> is less than 0 or greater than 59.-or- <paramref name="second"/> is less than 0 or greater than 59.-or- <paramref name="millisecond"/> is less than 0 or greater than 999. </exception><exception cref="T:System.ArgumentException">The specified time parameters evaluate to less than <see cref="F:System.DateTime.MinValue"/> or more than <see cref="F:System.DateTime.MaxValue"/>. -or-<paramref name="kind"/> is not one of the <see cref="T:System.DateTimeKind"/> values.</exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind);

		/// <summary>
		/// Adds a specified time interval to a specified date and time, yielding a new date and time.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> that is the sum of the values of <paramref name="d"/> and <paramref name="t"/>.
		/// </returns>
		/// <param name="d">A <see cref="T:System.DateTime"/>. </param><param name="t">A <see cref="T:System.TimeSpan"/>. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>3</filterpriority>
		public static DateTime operator +(DateTime d, TimeSpan t);

		/// <summary>
		/// Subtracts a specified time interval from a specified date and time and returns a new date and time.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the value of <paramref name="d"/> minus the value of <paramref name="t"/>.
		/// </returns>
		/// <param name="d">A <see cref="T:System.DateTime"/>. </param><param name="t">A <see cref="T:System.TimeSpan"/>. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>3</filterpriority>
		public static DateTime operator -(DateTime d, TimeSpan t);

		/// <summary>
		/// Subtracts a specified date and time from another specified date and time and returns a time interval.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.TimeSpan"/> that is the time interval between <paramref name="d1"/> and <paramref name="d2"/>; that is, <paramref name="d1"/> minus <paramref name="d2"/>.
		/// </returns>
		/// <param name="d1">A <see cref="T:System.DateTime"/> (the minuend). </param><param name="d2">A <see cref="T:System.DateTime"/> (the subtrahend). </param><filterpriority>3</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static TimeSpan operator -(DateTime d1, DateTime d2);

		/// <summary>
		/// Determines whether two specified instances of <see cref="T:System.DateTime"/> are equal.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="d1"/> and <paramref name="d2"/> represent the same date and time; otherwise, false.
		/// </returns>
		/// <param name="d1">A <see cref="T:System.DateTime"/>. </param><param name="d2">A <see cref="T:System.DateTime"/>. </param><filterpriority>3</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator ==(DateTime d1, DateTime d2);

		/// <summary>
		/// Determines whether two specified instances of <see cref="T:System.DateTime"/> are not equal.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="d1"/> and <paramref name="d2"/> do not represent the same date and time; otherwise, false.
		/// </returns>
		/// <param name="d1">A <see cref="T:System.DateTime"/>. </param><param name="d2">A <see cref="T:System.DateTime"/>. </param><filterpriority>3</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator !=(DateTime d1, DateTime d2);

		/// <summary>
		/// Determines whether one specified <see cref="T:System.DateTime"/> is less than another specified <see cref="T:System.DateTime"/>.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="t1"/> is less than <paramref name="t2"/>; otherwise, false.
		/// </returns>
		/// <param name="t1">A <see cref="T:System.DateTime"/>. </param><param name="t2">A <see cref="T:System.DateTime"/>. </param><filterpriority>3</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator <(DateTime t1, DateTime t2);

		/// <summary>
		/// Determines whether one specified <see cref="T:System.DateTime"/> is less than or equal to another specified <see cref="T:System.DateTime"/>.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="t1"/> is less than or equal to <paramref name="t2"/>; otherwise, false.
		/// </returns>
		/// <param name="t1">A <see cref="T:System.DateTime"/>. </param><param name="t2">A <see cref="T:System.DateTime"/>. </param><filterpriority>3</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator <=(DateTime t1, DateTime t2);

		/// <summary>
		/// Determines whether one specified <see cref="T:System.DateTime"/> is greater than another specified <see cref="T:System.DateTime"/>.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="t1"/> is greater than <paramref name="t2"/>; otherwise, false.
		/// </returns>
		/// <param name="t1">A <see cref="T:System.DateTime"/>. </param><param name="t2">A <see cref="T:System.DateTime"/>. </param><filterpriority>3</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator >(DateTime t1, DateTime t2);

		/// <summary>
		/// Determines whether one specified <see cref="T:System.DateTime"/> is greater than or equal to another specified <see cref="T:System.DateTime"/>.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="t1"/> is greater than or equal to <paramref name="t2"/>; otherwise, false.
		/// </returns>
		/// <param name="t1">A <see cref="T:System.DateTime"/>. </param><param name="t2">A <see cref="T:System.DateTime"/>. </param><filterpriority>3</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator >=(DateTime t1, DateTime t2);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the value of the specified <see cref="T:System.TimeSpan"/> to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the time interval represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A <see cref="T:System.TimeSpan"/> object that represents a positive or negative time interval. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime Add(TimeSpan value);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of days to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the number of days represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A number of whole and fractional days. The <paramref name="value"/> parameter can be negative or positive. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime AddDays(double value);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of hours to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the number of hours represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A number of whole and fractional hours. The <paramref name="value"/> parameter can be negative or positive. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime AddHours(double value);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of milliseconds to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the number of milliseconds represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A number of whole and fractional milliseconds. The <paramref name="value"/> parameter can be negative or positive. Note that this value is rounded to the nearest integer.</param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime AddMilliseconds(double value);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of minutes to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the number of minutes represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A number of whole and fractional minutes. The <paramref name="value"/> parameter can be negative or positive. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime AddMinutes(double value);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of months to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and <paramref name="months"/>.
		/// </returns>
		/// <param name="months">A number of months. The <paramref name="months"/> parameter can be negative or positive. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>.-or- <paramref name="months"/> is less than -120,000 or greater than 120,000. </exception><filterpriority>2</filterpriority>
		public DateTime AddMonths(int months);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of seconds to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the number of seconds represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A number of whole and fractional seconds. The <paramref name="value"/> parameter can be negative or positive. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime AddSeconds(double value);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of ticks to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the time represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A number of 100-nanosecond ticks. The <paramref name="value"/> parameter can be positive or negative. </param><exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime AddTicks(long value);

		/// <summary>
		/// Returns a new <see cref="T:System.DateTime"/> that adds the specified number of years to the value of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the sum of the date and time represented by this instance and the number of years represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A number of years. The <paramref name="value"/> parameter can be negative or positive. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="value"/> or the resulting <see cref="T:System.DateTime"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime AddYears(int value);

		/// <summary>
		/// Compares two instances of <see cref="T:System.DateTime"/> and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.
		/// </summary>
		/// 
		/// <returns>
		/// A signed number indicating the relative values of <paramref name="t1"/> and <paramref name="t2"/>.Value Type Condition Less than zero <paramref name="t1"/> is earlier than <paramref name="t2"/>. Zero <paramref name="t1"/> is the same as <paramref name="t2"/>. Greater than zero <paramref name="t1"/> is later than <paramref name="t2"/>.
		/// </returns>
		/// <param name="t1">The first <see cref="T:System.DateTime"/>. </param><param name="t2">The second <see cref="T:System.DateTime"/>. </param><filterpriority>1</filterpriority>
		public static int Compare(DateTime t1, DateTime t2);

		/// <summary>
		/// Compares the value of this instance to a specified object that contains a specified <see cref="T:System.DateTime"/> value, and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime"/> value.
		/// </summary>
		/// 
		/// <returns>
		/// A signed number indicating the relative values of this instance and <paramref name="value"/>.Value Description Less than zero This instance is earlier than <paramref name="value"/>. Zero This instance is the same as <paramref name="value"/>. Greater than zero This instance is later than <paramref name="value"/>, or <paramref name="value"/> is null.
		/// </returns>
		/// <param name="value">A boxed <see cref="T:System.DateTime"/> object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="value"/> is not a <see cref="T:System.DateTime"/>. </exception><filterpriority>2</filterpriority>
		public int CompareTo(object value);

		/// <summary>
		/// Compares the value of this instance to a specified <see cref="T:System.DateTime"/> value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime"/> value.
		/// </summary>
		/// 
		/// <returns>
		/// A signed number indicating the relative values of this instance and the <paramref name="value"/> parameter.Value Description Less than zero This instance is earlier than <paramref name="value"/>. Zero This instance is the same as <paramref name="value"/>. Greater than zero This instance is later than <paramref name="value"/>.
		/// </returns>
		/// <param name="value">A <see cref="T:System.DateTime"/> object to compare. </param><filterpriority>2</filterpriority>
		public int CompareTo(DateTime value);

		/// <summary>
		/// Returns the number of days in the specified month and year.
		/// </summary>
		/// 
		/// <returns>
		/// The number of days in <paramref name="month"/> for the specified <paramref name="year"/>.For example, if <paramref name="month"/> equals 2 for February, the return value is 28 or 29 depending upon whether <paramref name="year"/> is a leap year.
		/// </returns>
		/// <param name="year">The year. </param><param name="month">The month (a number ranging from 1 to 12). </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="month"/> is less than 1 or greater than 12.-or-<paramref name="year"/> is less than 1 or greater than 9999.</exception><filterpriority>1</filterpriority>
		public static int DaysInMonth(int year, int month);

		/// <summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="value"/> is an instance of <see cref="T:System.DateTime"/> and equals the value of this instance; otherwise, false.
		/// </returns>
		/// <param name="value">An object to compare to this instance. </param><filterpriority>2</filterpriority>
		public override bool Equals(object value);

		/// <summary>
		/// Returns a value indicating whether this instance is equal to the specified <see cref="T:System.DateTime"/> instance.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <paramref name="value"/> parameter equals the value of this instance; otherwise, false.
		/// </returns>
		/// <param name="value">A <see cref="T:System.DateTime"/> instance to compare to this instance. </param><filterpriority>2</filterpriority>
		public bool Equals(DateTime value);

		/// <summary>
		/// Returns a value indicating whether two instances of <see cref="T:System.DateTime"/> are equal.
		/// </summary>
		/// 
		/// <returns>
		/// true if the two <see cref="T:System.DateTime"/> values are equal; otherwise, false.
		/// </returns>
		/// <param name="t1">The first <see cref="T:System.DateTime"/> instance. </param><param name="t2">The second <see cref="T:System.DateTime"/> instance. </param><filterpriority>1</filterpriority>
		public static bool Equals(DateTime t1, DateTime t2);

		/// <summary>
		/// Deserializes a 64-bit binary value and recreates an original serialized <see cref="T:System.DateTime"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> object that is equivalent to the <see cref="T:System.DateTime"/> object that was serialized by the <see cref="M:System.DateTime.ToBinary"/> method.
		/// </returns>
		/// <param name="dateData">A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind"/> property in a 2-bit field and the <see cref="P:System.DateTime.Ticks"/> property in a 62-bit field. </param><exception cref="T:System.ArgumentException"><paramref name="dateData"/> is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>1</filterpriority>
		public static DateTime FromBinary(long dateData);

		/// <summary>
		/// Converts the specified Windows file time to an equivalent local time.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> object that represents a local time equivalent to the date and time represented by the <paramref name="fileTime"/> parameter.
		/// </returns>
		/// <param name="fileTime">A Windows file time expressed in ticks. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="fileTime"/> is less than 0 or represents a time greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>1</filterpriority>
		public static DateTime FromFileTime(long fileTime);

		/// <summary>
		/// Converts the specified Windows file time to an equivalent UTC time.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> object that represents a UTC time equivalent to the date and time represented by the <paramref name="fileTime"/> parameter.
		/// </returns>
		/// <param name="fileTime">A Windows file time expressed in ticks. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="fileTime"/> is less than 0 or represents a time greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>1</filterpriority>
		public static DateTime FromFileTimeUtc(long fileTime);

		/// <summary>
		/// Returns a <see cref="T:System.DateTime"/> equivalent to the specified OLE Automation Date.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> that represents the same date and time as <paramref name="d"/>.
		/// </returns>
		/// <param name="d">An OLE Automation Date value. </param><exception cref="T:System.ArgumentException">The date is not a valid OLE Automation Date value. </exception><filterpriority>1</filterpriority>
		public static DateTime FromOADate(double d);

		/// <summary>
		/// Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object with the data needed to serialize the current <see cref="T:System.DateTime"/> object.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> object to populate with data. </param><param name="context">The destination for this serialization. (This parameter is not used; specify null.)</param><exception cref="T:System.ArgumentNullException"><paramref name="info"/> is null.</exception>
		[SecurityCritical]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);

		/// <summary>
		/// Indicates whether this instance of <see cref="T:System.DateTime"/> is within the Daylight Saving Time range for the current time zone.
		/// </summary>
		/// 
		/// <returns>
		/// true if <see cref="P:System.DateTime.Kind"/> is <see cref="F:System.DateTimeKind.Local"/> or <see cref="F:System.DateTimeKind.Unspecified"/> and the value of this instance of <see cref="T:System.DateTime"/> is within the Daylight Saving Time range for the current time zone. false if <see cref="P:System.DateTime.Kind"/> is <see cref="F:System.DateTimeKind.Utc"/>.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		public bool IsDaylightSavingTime();

		/// <summary>
		/// Creates a new <see cref="T:System.DateTime"/> object that has the same number of ticks as the specified <see cref="T:System.DateTime"/>, but is designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified <see cref="T:System.DateTimeKind"/> value.
		/// </summary>
		/// 
		/// <returns>
		/// A new object that has the same number of ticks as the object represented by the <paramref name="value"/> parameter and the <see cref="T:System.DateTimeKind"/> value specified by the <paramref name="kind"/> parameter.
		/// </returns>
		/// <param name="value">A date and time. </param><param name="kind">One of the enumeration values that indicates whether the new object represents local time, UTC, or neither.</param><filterpriority>2</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind);

		/// <summary>
		/// Serializes the current <see cref="T:System.DateTime"/> object to a 64-bit binary value that subsequently can be used to recreate the <see cref="T:System.DateTime"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind"/> and <see cref="P:System.DateTime.Ticks"/> properties.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		public long ToBinary();

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A 32-bit signed integer hash code.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public override int GetHashCode();

		/// <summary>
		/// Returns an indication whether the specified year is a leap year.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="year"/> is a leap year; otherwise, false.
		/// </returns>
		/// <param name="year">A 4-digit year. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="year"/> is less than 1 or greater than 9999.</exception><filterpriority>1</filterpriority>
		public static bool IsLeapYear(int year);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> equivalent to the date and time contained in <paramref name="s"/>.
		/// </returns>
		/// <param name="s">A string containing a date and time to convert. </param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null. </exception><exception cref="T:System.FormatException"><paramref name="s"/> does not contain a valid string representation of a date and time. </exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public static DateTime Parse(string s);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified culture-specific format information.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> equivalent to the date and time contained in <paramref name="s"/> as specified by <paramref name="provider"/>.
		/// </returns>
		/// <param name="s">A string containing a date and time to convert. </param><param name="provider">An object that supplies culture-specific format information about <paramref name="s"/>. </param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null. </exception><exception cref="T:System.FormatException"><paramref name="s"/> does not contain a valid string representation of a date and time. </exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public static DateTime Parse(string s, IFormatProvider provider);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified culture-specific format information and formatting style.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> equivalent to the date and time contained in <paramref name="s"/> as specified by <paramref name="provider"/> and <paramref name="styles"/>.
		/// </returns>
		/// <param name="s">A string containing a date and time to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s"/>. </param><param name="styles">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s"/> for the parse operation to succeed and that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> is null. </exception><exception cref="T:System.FormatException"><paramref name="s"/> does not contain a valid string representation of a date and time. </exception><exception cref="T:System.ArgumentException"><paramref name="styles"/> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles"/> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal"/> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal"/>.</exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> equivalent to the date and time contained in <paramref name="s"/> as specified by <paramref name="format"/> and <paramref name="provider"/>.
		/// </returns>
		/// <param name="s">A string that contains a date and time to convert. </param><param name="format">A format specifier that defines the required format of <paramref name="s"/>. </param><param name="provider">An object that supplies culture-specific format information about <paramref name="s"/>. </param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> or <paramref name="format"/> is null. </exception><exception cref="T:System.FormatException"><paramref name="s"/> or <paramref name="format"/> is an empty string. -or- <paramref name="s"/> does not contain a date and time that corresponds to the pattern specified in <paramref name="format"/>. -or-The hour component and the AM/PM designator in <paramref name="s"/> do not agree.</exception><filterpriority>2</filterpriority>
		public static DateTime ParseExact(string s, string format, IFormatProvider provider);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> equivalent to the date and time contained in <paramref name="s"/> as specified by <paramref name="format"/>, <paramref name="provider"/>, and <paramref name="style"/>.
		/// </returns>
		/// <param name="s">A string containing a date and time to convert. </param><param name="format">A format specifier that defines the required format of <paramref name="s"/>. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s"/>. </param><param name="style">A bitwise combination of the enumeration values that provides additional information about <paramref name="s"/>, about style elements that may be present in <paramref name="s"/>, or about the conversion from <paramref name="s"/> to a <see cref="T:System.DateTime"/> value. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> or <paramref name="format"/> is null. </exception><exception cref="T:System.FormatException"><paramref name="s"/> or <paramref name="format"/> is an empty string. -or- <paramref name="s"/> does not contain a date and time that corresponds to the pattern specified in <paramref name="format"/>. -or-The hour component and the AM/PM designator in <paramref name="s"/> do not agree.</exception><exception cref="T:System.ArgumentException"><paramref name="style"/> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles"/> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal"/> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal"/>.</exception><filterpriority>2</filterpriority>
		public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly or an exception is thrown.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> equivalent to the date and time contained in <paramref name="s"/> as specified by <paramref name="formats"/>, <paramref name="provider"/>, and <paramref name="style"/>.
		/// </returns>
		/// <param name="s">A string containing one or more dates and times to convert. </param><param name="formats">An array of allowable formats of <paramref name="s"/>. </param><param name="provider">An <see cref="T:System.IFormatProvider"/> that supplies culture-specific format information about <paramref name="s"/>. </param><param name="style">A bitwise combination of <see cref="T:System.Globalization.DateTimeStyles"/> values that indicates the permitted format of <paramref name="s"/>. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="s"/> or <paramref name="formats"/> is null. </exception><exception cref="T:System.FormatException"><paramref name="s"/> is an empty string. -or- an element of <paramref name="formats"/> is an empty string. -or- <paramref name="s"/> does not contain a date and time that corresponds to any element of <paramref name="formats"/>. -or-The hour component and the AM/PM designator in <paramref name="s"/> do not agree.</exception><exception cref="T:System.ArgumentException"><paramref name="style"/> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles"/> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal"/> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal"/>.</exception><filterpriority>2</filterpriority>
		public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);

		/// <summary>
		/// Subtracts the specified date and time from this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.TimeSpan"/> interval equal to the date and time represented by this instance minus the date and time represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">An instance of <see cref="T:System.DateTime"/>. </param><exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public TimeSpan Subtract(DateTime value);

		/// <summary>
		/// Subtracts the specified duration from this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> equal to the date and time represented by this instance minus the time interval represented by <paramref name="value"/>.
		/// </returns>
		/// <param name="value">An instance of <see cref="T:System.TimeSpan"/>. </param><exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue"/> or greater than <see cref="F:System.DateTime.MaxValue"/>. </exception><filterpriority>2</filterpriority>
		public DateTime Subtract(TimeSpan value);

		/// <summary>
		/// Converts the value of this instance to the equivalent OLE Automation date.
		/// </summary>
		/// 
		/// <returns>
		/// A double-precision floating-point number that contains an OLE Automation date equivalent to the value of this instance.
		/// </returns>
		/// <exception cref="T:System.OverflowException">The value of this instance cannot be represented as an OLE Automation Date. </exception><filterpriority>2</filterpriority>
		public double ToOADate();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to a Windows file time.
		/// </summary>
		/// 
		/// <returns>
		/// The value of the current <see cref="T:System.DateTime"/> object expressed as a Windows file time.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting file time would represent a date and time before 12:00 midnight January 1, 1601 C.E. UTC. </exception><filterpriority>2</filterpriority>
		public long ToFileTime();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to a Windows file time.
		/// </summary>
		/// 
		/// <returns>
		/// The value of the current <see cref="T:System.DateTime"/> object expressed as a Windows file time.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting file time would represent a date and time before 12:00 midnight January 1, 1601 C.E. UTC. </exception><filterpriority>2</filterpriority>
		public long ToFileTimeUtc();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to local time.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> object whose <see cref="P:System.DateTime.Kind"/> property is <see cref="F:System.DateTimeKind.Local"/>, and whose value is the local time equivalent to the value of the current <see cref="T:System.DateTime"/> object, or <see cref="F:System.DateTime.MaxValue"/> if the converted value is too large to be represented by a <see cref="T:System.DateTime"/> object, or <see cref="F:System.DateTime.MinValue"/> if the converted value is too small to be represented as a <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		public DateTime ToLocalTime();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent long date string representation.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the long date string representation of the current <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		[SecuritySafeCritical]
		public string ToLongDateString();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent long time string representation.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the long time string representation of the current <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		[SecuritySafeCritical]
		public string ToLongTimeString();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent short date string representation.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the short date string representation of the current <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		[SecuritySafeCritical]
		public string ToShortDateString();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent short time string representation.
		/// </summary>
		/// 
		/// <returns>
		/// A string that contains the short time string representation of the current <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		[SecuritySafeCritical]
		public string ToShortTimeString();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent string representation.
		/// </summary>
		/// 
		/// <returns>
		/// A string representation of the value of the current <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public override string ToString();

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent string representation using the specified format.
		/// </summary>
		/// 
		/// <returns>
		/// A string representation of value of the current <see cref="T:System.DateTime"/> object as specified by <paramref name="format"/>.
		/// </returns>
		/// <param name="format">A standard or custom date and time format string. </param><exception cref="T:System.FormatException">The length of <paramref name="format"/> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo"/>.-or- <paramref name="format"/> does not contain a valid custom format pattern. </exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public string ToString(string format);

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent string representation using the specified culture-specific format information.
		/// </summary>
		/// 
		/// <returns>
		/// A string representation of value of the current <see cref="T:System.DateTime"/> object as specified by <paramref name="provider"/>.
		/// </returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider"/> that supplies culture-specific formatting information. </param><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string ToString(IFormatProvider provider);

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to its equivalent string representation using the specified format and culture-specific format information.
		/// </summary>
		/// 
		/// <returns>
		/// A string representation of value of the current <see cref="T:System.DateTime"/> object as specified by <paramref name="format"/> and <paramref name="provider"/>.
		/// </returns>
		/// <param name="format">A standard or custom date and time format string. </param><param name="provider">An object that supplies culture-specific formatting information. </param><exception cref="T:System.FormatException">The length of <paramref name="format"/> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo"/>.-or- <paramref name="format"/> does not contain a valid custom format pattern. </exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider);

		/// <summary>
		/// Converts the value of the current <see cref="T:System.DateTime"/> object to Coordinated Universal Time (UTC).
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> object whose <see cref="P:System.DateTime.Kind"/> property is <see cref="F:System.DateTimeKind.Utc"/>, and whose value is the UTC equivalent to the value of the current <see cref="T:System.DateTime"/> object, or <see cref="F:System.DateTime.MaxValue"/> if the converted value is too large to be represented by a <see cref="T:System.DateTime"/> object, or <see cref="F:System.DateTime.MinValue"/> if the converted value is too small to be represented by a <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		public DateTime ToUniversalTime();

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent and returns a value that indicates whether the conversion succeeded.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <paramref name="s"/> parameter was converted successfully; otherwise, false.
		/// </returns>
		/// <param name="s">A string containing a date and time to convert. </param><param name="result">When this method returns, contains the <see cref="T:System.DateTime"/> value equivalent to the date and time contained in <paramref name="s"/>, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue"/> if the conversion failed. The conversion fails if the <paramref name="s"/> parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized. </param><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public static bool TryParse(string s, out DateTime result);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified culture-specific format information and formatting style, and returns a value that indicates whether the conversion succeeded.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <paramref name="s"/> parameter was converted successfully; otherwise, false.
		/// </returns>
		/// <param name="s">A string containing a date and time to convert. </param><param name="provider">An object that supplies culture-specific formatting information about <paramref name="s"/>. </param><param name="styles">A bitwise combination of enumeration values that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None"/>.</param><param name="result">When this method returns, contains the <see cref="T:System.DateTime"/> value equivalent to the date and time contained in <paramref name="s"/>, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue"/> if the conversion failed. The conversion fails if the <paramref name="s"/> parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized. </param><exception cref="T:System.ArgumentException"><paramref name="styles"/> is not a valid <see cref="T:System.Globalization.DateTimeStyles"/> value.-or-<paramref name="styles"/> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles"/> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal"/> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal"/>).</exception><exception cref="T:System.NotSupportedException"><paramref name="provider"/> is a neutral culture and cannot be used in a parsing operation.</exception><filterpriority>1</filterpriority>
		[SecuritySafeCritical]
		public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly. The method returns a value that indicates whether the conversion succeeded.
		/// </summary>
		/// 
		/// <returns>
		/// true if <paramref name="s"/> was converted successfully; otherwise, false.
		/// </returns>
		/// <param name="s">A string containing a date and time to convert. </param><param name="format">The required format of <paramref name="s"/>. </param><param name="provider">An <see cref="T:System.IFormatProvider"/> object that supplies culture-specific formatting information about <paramref name="s"/>. </param><param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of <paramref name="s"/>. </param><param name="result">When this method returns, contains the <see cref="T:System.DateTime"/> value equivalent to the date and time contained in <paramref name="s"/>, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue"/> if the conversion failed. The conversion fails if either the <paramref name="s"/> or <paramref name="format"/> parameter is null, is an empty string, or does not contain a date and time that correspond to the pattern specified in <paramref name="format"/>. This parameter is passed uninitialized. </param><exception cref="T:System.ArgumentException"><paramref name="styles"/> is not a valid <see cref="T:System.Globalization.DateTimeStyles"/> value.-or-<paramref name="styles"/> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles"/> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal"/> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal"/>).</exception><filterpriority>1</filterpriority>
		public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);

		/// <summary>
		/// Converts the specified string representation of a date and time to its <see cref="T:System.DateTime"/> equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly. The method returns a value that indicates whether the conversion succeeded.
		/// </summary>
		/// 
		/// <returns>
		/// true if the <paramref name="s"/> parameter was converted successfully; otherwise, false.
		/// </returns>
		/// <param name="s">A string containing one or more dates and times to convert. </param><param name="formats">An array of allowable formats of <paramref name="s"/>. </param><param name="provider">An object that supplies culture-specific format information about <paramref name="s"/>. </param><param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s"/>. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None"/>.</param><param name="result">When this method returns, contains the <see cref="T:System.DateTime"/> value equivalent to the date and time contained in <paramref name="s"/>, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue"/> if the conversion failed. The conversion fails if <paramref name="s"/> or <paramref name="formats"/> is null, <paramref name="s"/> or an element of <paramref name="formats"/> is an empty string, or the format of <paramref name="s"/> is not exactly as specified by at least one of the format patterns in <paramref name="formats"/>. This parameter is passed uninitialized. </param><exception cref="T:System.ArgumentException"><paramref name="styles"/> is not a valid <see cref="T:System.Globalization.DateTimeStyles"/> value.-or-<paramref name="styles"/> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles"/> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal"/> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal"/>).</exception><filterpriority>1</filterpriority>
		public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result);

		/// <summary>
		/// Converts the value of this instance to all the string representations supported by the standard <see cref="T:System.DateTime"/> format specifiers.
		/// </summary>
		/// 
		/// <returns>
		/// A string array where each element is the representation of the value of this instance formatted with one of the standard <see cref="T:System.DateTime"/> formatting specifiers.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		public string[] GetDateTimeFormats();

		/// <summary>
		/// Converts the value of this instance to all the string representations supported by the standard <see cref="T:System.DateTime"/> format specifiers and the specified culture-specific formatting information.
		/// </summary>
		/// 
		/// <returns>
		/// A string array where each element is the representation of the value of this instance formatted with one of the standard <see cref="T:System.DateTime"/> formatting specifiers.
		/// </returns>
		/// <param name="provider">An object that supplies culture-specific formatting information about this instance. </param><filterpriority>2</filterpriority>
		public string[] GetDateTimeFormats(IFormatProvider provider);

		/// <summary>
		/// Converts the value of this instance to all the string representations supported by the specified standard <see cref="T:System.DateTime"/> format specifier.
		/// </summary>
		/// 
		/// <returns>
		/// A string array where each element is the representation of the value of this instance formatted with the <paramref name="format"/> standard <see cref="T:System.DateTime"/> formatting specifier.
		/// </returns>
		/// <param name="format">A standard date and time format string. (See Standard Date and Time Format Strings.) </param><exception cref="T:System.FormatException"><paramref name="format"/> is not a valid standard date and time format specifier character.</exception><filterpriority>2</filterpriority>
		public string[] GetDateTimeFormats(char format);

		/// <summary>
		/// Converts the value of this instance to all the string representations supported by the specified standard <see cref="T:System.DateTime"/> format specifier and culture-specific formatting information.
		/// </summary>
		/// 
		/// <returns>
		/// A string array where each element is the representation of the value of this instance formatted with one of the standard <see cref="T:System.DateTime"/> formatting specifiers.
		/// </returns>
		/// <param name="format">A date and time format string. </param><param name="provider">An object that supplies culture-specific formatting information about this instance. </param><exception cref="T:System.FormatException"><paramref name="format"/> is not a valid standard date and time format specifier character.</exception><filterpriority>2</filterpriority>
		public string[] GetDateTimeFormats(char format, IFormatProvider provider);

		/// <summary>
		/// Returns the <see cref="T:System.TypeCode"/> for value type <see cref="T:System.DateTime"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The enumerated constant, <see cref="F:System.TypeCode.DateTime"/>.
		/// </returns>
		/// <filterpriority>2</filterpriority>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public TypeCode GetTypeCode();

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		bool IConvertible.ToBoolean(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		char IConvertible.ToChar(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		sbyte IConvertible.ToSByte(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		byte IConvertible.ToByte(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		short IConvertible.ToInt16(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		ushort IConvertible.ToUInt16(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		int IConvertible.ToInt32(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		uint IConvertible.ToUInt32(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		long IConvertible.ToInt64(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		ulong IConvertible.ToUInt64(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases. </exception>
		float IConvertible.ToSingle(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		double IConvertible.ToDouble(IFormatProvider provider);

		/// <summary>
		/// This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException"/>.
		/// </summary>
		/// 
		/// <returns>
		/// The return value for this member is not used.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface or null.</param><exception cref="T:System.InvalidCastException">In all cases.</exception>
		decimal IConvertible.ToDecimal(IFormatProvider provider);

		/// <summary>
		/// Returns the current <see cref="T:System.DateTime"/> object.
		/// </summary>
		/// 
		/// <returns>
		/// The current <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param>
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		DateTime IConvertible.ToDateTime(IFormatProvider provider);

		/// <summary>
		/// Converts the current <see cref="T:System.DateTime"/> object to an object of a specified type.
		/// </summary>
		/// 
		/// <returns>
		/// An object of the type specified by the <paramref name="type"/> parameter, with a value equivalent to the current <see cref="T:System.DateTime"/> object.
		/// </returns>
		/// <param name="type">The desired type. </param><param name="provider">An object that implements the <see cref="T:System.IFormatProvider"/> interface. (This parameter is not used; specify null.)</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> is null. </exception><exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DateTime"/> type.</exception>
		object IConvertible.ToType(Type type, IFormatProvider provider);

		/// <summary>
		/// Gets the date component of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A new <see cref="T:System.DateTime"/> with the same date as this instance, and the time value set to 12:00:00 midnight (00:00:00).
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public DateTime Date { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the day of the month represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The day component, expressed as a value between 1 and 31.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int Day { get; }

		/// <summary>
		/// Gets the day of the week represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DayOfWeek"/> enumerated constant that indicates the day of the week of this <see cref="T:System.DateTime"/> value.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public DayOfWeek DayOfWeek { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the day of the year represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The day of the year, expressed as a value between 1 and 366.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int DayOfYear { get; }

		/// <summary>
		/// Gets the hour component of the date represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The hour component, expressed as a value between 0 and 23.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int Hour { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets a value that indicates whether the time represented by this instance is based on local time, Coordinated Universal Time (UTC), or neither.
		/// </summary>
		/// 
		/// <returns>
		/// One of the <see cref="T:System.DateTimeKind"/> values. The default is <see cref="F:System.DateTimeKind.Unspecified"/>.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public DateTimeKind Kind { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the milliseconds component of the date represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The milliseconds component, expressed as a value between 0 and 999.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int Millisecond { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the minute component of the date represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The minute component, expressed as a value between 0 and 59.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int Minute { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the month component of the date represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The month component, expressed as a value between 1 and 12.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int Month { get; }

		/// <summary>
		/// Gets a <see cref="T:System.DateTime"/> object that is set to the current date and time on this computer, expressed as the local time.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the current local date and time.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public static DateTime Now { get; }

		/// <summary>
		/// Gets a <see cref="T:System.DateTime"/> object that is set to the current date and time on this computer, expressed as the Coordinated Universal Time (UTC).
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> whose value is the current UTC date and time.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public static DateTime UtcNow { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries"), SecuritySafeCritical]
		get; }

		/// <summary>
		/// Gets the seconds component of the date represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The seconds, between 0 and 59.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int Second { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the number of ticks that represent the date and time of this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The number of ticks that represent the date and time of this instance. The value is between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public long Ticks { get; }

		/// <summary>
		/// Gets the time of day for this instance.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.TimeSpan"/> that represents the fraction of the day that has elapsed since midnight.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public TimeSpan TimeOfDay { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the current date.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.DateTime"/> set to today's date, with the time component set to 00:00:00.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public static DateTime Today { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		get; }

		/// <summary>
		/// Gets the year component of the date represented by this instance.
		/// </summary>
		/// 
		/// <returns>
		/// The year, between 1 and 9999.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		public int Year { get; }
	}
}
