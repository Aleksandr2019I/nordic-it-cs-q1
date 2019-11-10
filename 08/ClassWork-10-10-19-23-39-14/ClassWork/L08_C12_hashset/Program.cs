using System;
using System.Collections.Generic;

namespace L08_C12_hashset
{
	class Program
	{
		static void Main(string[] args)
		{
			var set1 = new SortedSet<int>
			{
				1, 3, 5, 7, 9, 10, 11, 12, 13
			};

			var set2 = new HashSet<int>
			{
				0, 2, 4, 6, 8, 10, 11, 12, 13
			};

			set1.Add(14);

			Console.WriteLine("Set 1: " + string.Join(", ", set1));
			Console.WriteLine("Set 2: " + string.Join(", ", set2));

			set1.UnionWith(set2);
			Console.WriteLine("Set 1 UnionWith Set 2:\n" + string.Join(", ", set1));

			set1.ExceptWith(set2);
			Console.WriteLine("Set 1 ExceptWith Set 2:\n" + string.Join(", ", set1));

			set1.IntersectWith(set2);
			Console.WriteLine("Set 1 IntersectWith Set 2:\n" + string.Join(", ", set1));

			Console.ReadKey();
		}
	}
}
