using System.Collections.Generic;
using System.Linq;

namespace EmailPingPong.UI.Desktop.Utils
{
	public static class EnumerableExtensions
	{
		public static bool ElementsEqual<T>(this IEnumerable<T> list1, IEnumerable<T> list2)
			where T: class
		{
			if (list1 == null && list2 == null)
			{
				return true;
			}

			if (list1 == null || list2 == null)
			{
				return false;
			}

			var lst1 = list1.ToList();
			var lst2 = list2.ToList();

			if (!lst1.Any() && !lst2.Any())
			{
				return true;
			}

			if (lst1.Count() != lst2.Count())
			{
				return false;
			}

			for (var i = 0; i < lst1.Count(); i++)
			{
				T element1 = lst1[i];
				T element2 = lst2[i];

				if (!element1.Equals(element2))
				{
					return false;
				}
			}

			return true;
		}
	}
}