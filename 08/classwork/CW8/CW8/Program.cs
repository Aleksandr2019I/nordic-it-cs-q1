using System;
using System.Collections.Generic;
namespace CW8
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new List<double>();
			try
			{
				while (true)
				{
					var value = Console.ReadLine();

					if (value == "stop")
					{
						break;
					}
					else
					{
						var num = double.Parse(value);

						list.Add(num);
					}

				}
			}
			
			catch ( ArgumentException )
			{
				Console.WriteLine($"Введено нечисловое значение, программа остановленна");
			}

			
			double sum = 0;
			for (int i = 0; i < list.Count; i++)
			{
				sum += list[i];
			}
			var arifm = sum / list.Count;

			Console.WriteLine($"{sum}");
			Console.WriteLine($"{arifm}");
			Console.WriteLine($"{list.Count}");
			Console.ReadKey();

		}
	}
}
