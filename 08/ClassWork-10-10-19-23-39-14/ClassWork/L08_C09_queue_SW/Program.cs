using System;
using System.Collections.Generic;

namespace L08_C09_queue_SW
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Вводите числа для создания отложенных задач возведения их в квадрат.");
			Console.WriteLine("Введите \"run\" чтобы запустить расчет, или \"exit\" чтобы завершить работу.");

			var queue = new Queue<int>();
			var execute = true;

			while (execute)
			{
				var input = Console.ReadLine().ToLower();

				switch (input)
				{
					case "run":
						while (queue.Count > 0)
						{
							var number = queue.Dequeue();
							Console.WriteLine($"{number}^2 = {number * number}");
						}
						break;

					case "exit":
						execute = false;
						Console.WriteLine($"Выходим. Число задач в очереди на момент выхода: {queue.Count}");
						break;

					default:
						queue.Enqueue(int.Parse(input));
						break;
				}
			}
			Console.ReadKey();
		}
	}
}

