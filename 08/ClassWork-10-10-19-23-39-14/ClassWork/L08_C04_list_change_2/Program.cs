using System;
using System.Collections.Generic;

namespace L08_C04_list_change_2
{
	class Program
	{
		static void Main()
		{
			var list = new List<string> { "10", "20", "30", "40" };
			Console.WriteLine(list.IndexOf("30"));
			// 2

			list.Insert(3, "35");
			Console.WriteLine(string.Join(", ", list));
			// 10, 20, 30, 35, 40

			list.Remove("20");
			Console.WriteLine(string.Join(", ", list));
			// 10, 30, 35, 40

			list.RemoveAt(0);
			Console.WriteLine(string.Join(", ", list));
			// 30, 35, 40

			list.Clear();
			Console.WriteLine(list.Count);
			// 0
			Console.ReadKey();
		}
	}

}

