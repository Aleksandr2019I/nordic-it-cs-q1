using System;
using System.Collections.Generic;

namespace L08_C05_list_SW
{
	class Program
	{
		static void Main()
		{
			var list = new List<double>();

			Console.WriteLine("Enter double precision float values (enter \"stop\" to finish");
			do
			{
				var input = Console.ReadLine();
				if (input.Equals("stop", StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}

				try
				{
					list.Add(double.Parse(input));
				}
				catch (FormatException)
				{
					Console.WriteLine("Error! Not a number entered! Aborting");
					throw;
				}
			}
			while (true);

			double sum = 0;
			foreach (var d in list)
			{
				sum += d;
			}

			var avg = sum / list.Count;

			Console.WriteLine($"Sum: {sum:#.###}, Average: {avg:#.###}");
			Console.ReadKey();
		}
	}
}

