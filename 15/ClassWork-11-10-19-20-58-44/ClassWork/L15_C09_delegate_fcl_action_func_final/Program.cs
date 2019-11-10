using System;
using System.Collections.Generic;

namespace L15_C09_delegate_fcl_action_func_final
{
	class Program
	{
		private static void Execute(
			ICollection<int> numbers,
			Func<ICollection<int>, int> operation,
			Action<string> output)
		{
			output($"The result of calculation is {operation(numbers)}");
		}

		private static void Display(string message)
		{
			Console.WriteLine(message);
		}

		private static int Sum(ICollection<int> numbers)
		{
			var sum = 0;

			foreach (var number in numbers)
			{
				sum += number;
			}

			return sum;
		}

		private static int Product(ICollection<int> numbers)
		{
			var product = 1;

			foreach (var number in numbers)
			{
				product *= number;
			}

			return product;
		}

		private static int Avg(ICollection<int> numbers)
		{
			return Sum(numbers) / numbers.Count;
		}

		private static void Main(string[] args)
		{
			var numbers = new[] {1, 2, 3, 4, 5, 6, 100};

			Console.WriteLine($"Getting sum of {string.Join(", ", numbers)}");
			Execute(numbers, Sum, Display);

			Console.WriteLine("\n***\n");

			Console.WriteLine($"Getting average value of {string.Join(", ", numbers)}");
			Execute(numbers, Avg, Display);

			Console.WriteLine("\n***\n");

			Console.WriteLine($"Getting product of {string.Join(", ", numbers)}");
			Execute(numbers, Product, Display);
		}
	}
}