using System;
using System.Collections.Generic;

namespace L08_C10_stack
{
	class Program
	{
		static void Main()
		{
			var numbers = new Stack<string>();
			numbers.Push("one");
			numbers.Push("two");
			numbers.Push("three");
			numbers.Push("four");
			numbers.Push("five");

			// A stack can be enumerated without disturbing its contents.
			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}

			while (numbers.Count > 0)
			{
				var n = numbers.Pop();
				Console.Write($"Processing \"{n}\"... ");
				// here we can really do something with popped element :)
				Console.WriteLine("OK");
			}
			Console.ReadKey();
		}
	}
}

