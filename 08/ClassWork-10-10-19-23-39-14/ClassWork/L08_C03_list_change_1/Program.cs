using System;
using System.Collections.Generic;

namespace L08_C03_list_change_1
{
	class Program
	{
		static void Main()
		{
			var integers = new List<int> { 10, 20, 30, 40 };
			integers.AddRange(new[] { 50, 60, 70, 80 }); // add new 4 elements
			Console.WriteLine(string.Join(", ", integers));

			integers.RemoveRange(4, 2); // remove 2 elements from index 4 
			Console.WriteLine(string.Join(", ", integers));
			Console.ReadKey();
		}
	}
}
