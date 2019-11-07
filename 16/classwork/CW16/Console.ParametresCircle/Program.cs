using System;
using Calculator.Figure;
using Calculator.Operation;

namespace Console.ParametresCircle
{
	using Console = System.Console;

	class Program
	{
		static void Main(string[] args)
		{
			var first = new Circle(1.5);
			Console.WriteLine($"{first.Calculate(CircleOperation.Area)}");
			Console.WriteLine($"{first.Calculate(CircleOperation.Perimeter)}");
			var second = new Square(10);
			Console.WriteLine($"{second.CalculateP(PerimeterOperation.Area)}");

			Console.WriteLine($"{second.CalculateP(PerimeterOperation.Perimeter)}");
			Console.ReadKey();
		}
	}
}
