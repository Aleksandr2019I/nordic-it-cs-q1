using System;
using System.Collections.Generic;

namespace L08_C08_queue
{
	class Program
	{
		static void Main()
		{
			var numbers = new Queue<string>();
			numbers.Enqueue("one");
			numbers.Enqueue("two");
			numbers.Enqueue("three");
			numbers.Enqueue("four");
			numbers.Enqueue("five");

			// A queue can be enumerated without disturbing its contents.
			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}

			while (numbers.Count > 0)
			{
				var n = numbers.Dequeue();
				Console.Write($"Processing \"{n}\"... ");
				// here we can really do something with dequeued element :)
				Console.WriteLine("OK");
			}
			Console.ReadKey();
		}
	}
}

