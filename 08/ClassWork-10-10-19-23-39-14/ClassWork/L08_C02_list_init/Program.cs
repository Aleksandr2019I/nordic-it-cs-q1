using System;
using System.Collections.Generic;

namespace L08_C02_list_init
{
	class Program
	{
		static void Main()
		{
			var integers = new List<int> { 10, 20, 30, 40 };
			Console.WriteLine(string.Join(", ", integers));

			var strings = new List<string>
			{
				"one",
				"two",
				"three",
				"four"
			};

			Console.WriteLine(string.Join(", ", strings));
			Console.ReadKey();
		}
	}
}