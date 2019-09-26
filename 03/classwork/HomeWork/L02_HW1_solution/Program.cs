using System;

namespace L02_HW1_solution
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter the first integer value: ");
			var first = int.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.Write("Enter the second integer value: ");
			var second = int.Parse(Console.ReadLine());

			Console.WriteLine(first + second);
			Console.WriteLine(first - second);
			Console.WriteLine(first * second);
		}
	}
}
