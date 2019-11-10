using System;
using System.Collections.Generic;

namespace L08_C11_stack_SW
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Введите \"wash\", чтобы добавить тарелку в стопку помытых.");
			Console.WriteLine("Введите \"dry\" чтобы взять тарелку с вершины стопки для вытирания.");
			Console.WriteLine("Введите \"exit\" чтобы завершить работу.");

			var stack = new Stack<bool>();
			var execute = true;

			while (execute)
			{
				var input = Console.ReadLine().ToLower();

				switch (input)
				{
					case "wash":
						stack.Push(true);
						break;
					case "dry":
						if (stack.Count > 0)
						{
							stack.Pop();
						}
						else
						{
							Console.WriteLine("Стопка тарелок пуста!");
						}

						break;
					case "exit":
						execute = false;
						break;
				}

				Console.WriteLine($"Тарелок стопке на вытирание: {stack.Count}");
			}
			Console.ReadKey();
		}
	}
}

