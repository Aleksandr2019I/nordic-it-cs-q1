using System;
using System.Collections.Generic;
namespace очередь
{
	class Program
	{
		static void Main(string[] args)
		{
			var queue = new Queue<int>();
			while (true)
			{
				var num = Console.ReadLine();
				if (num == "run")
				{
					while (queue.Count > 0)
					{
						var x = Math.Sqrt(queue.Dequeue());
						Console.WriteLine($"{x}");
					}
				}
				else if (num == "exit")
				{
					var y = queue.Count;
					Console.WriteLine($"{y}");
					break;
				}
				else
				{
					queue.Enqueue(int.Parse(num));
				}
			}
			Console.ReadKey();
		}
	}
}
