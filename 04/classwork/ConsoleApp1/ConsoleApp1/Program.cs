using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Height");
			var height = double.Parse(Console.ReadLine());
			Console.WriteLine("Side");
			var side = double.Parse(Console.ReadLine());

			double sideS = 3 * height * side;

			var sideF = 3 / 2 * height * (height*(Math.Sqrt(3)) + 2 * side);

			var voluem = (Math.Pow(side, 2) / side) * (Math.Sqrt(3));

			Console.WriteLine($"{sideS}, {sideF}, {voluem} ");


			Console.ReadKey();






		}
	}
}
