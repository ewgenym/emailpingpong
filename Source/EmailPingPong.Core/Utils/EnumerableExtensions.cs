using System;
using System.Collections.Generic;

namespace EmailPingPong.Core.Utils
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach (var obj in source)
			{
				action(obj);
			}

			return source;
		}

		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
		{
			var index = 0;
			foreach (var obj in source)
			{
				action(obj, index++);
			}

			return source;
		}

		public static void AddRange<T>(this ICollection<T> target, IEnumerable<T> source)
		{
			source.ForEach(target.Add);
		}
	}
}