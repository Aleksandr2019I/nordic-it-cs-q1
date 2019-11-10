using System;
using System.Collections.Generic;

namespace L08_C01_list_add
{
	class Program
	{
		static void Main()
		{
			var integers = new List<int>();
			integers.Add(10);
			integers.Add(20);
			integers.Add(30);
			integers.Add(40);

			Console.WriteLine(string.Join(", ", integers));

			var strings = new List<string>();
			strings.Add("one");
			strings.Add("two");
			strings.Add("three");
			strings.Add("four");
			strings.Add("four");
			strings.Add(null);
			strings.Add(null);

			Console.WriteLine(string.Join(", ", strings));
			Console.ReadKey();
		}
	}
}