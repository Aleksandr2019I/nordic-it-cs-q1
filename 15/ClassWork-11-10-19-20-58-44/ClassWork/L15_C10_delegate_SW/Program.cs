using System;

namespace L15_C10_delegate_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var circleRadius = 1.5;
			var circle = new Circle(circleRadius);

			var circlePerimeter =
				circle.Calculate(CircleOperations.Perimeter);

			var circleSquare =
				circle.Calculate(CircleOperations.Square);

			Console.WriteLine(
				$"For the circle with radius {circleRadius}\n" +
				$"\tPerimeter is\t{circlePerimeter}\n" +
				$"\tSquare is\t{circleSquare}");
		}
	}
}
