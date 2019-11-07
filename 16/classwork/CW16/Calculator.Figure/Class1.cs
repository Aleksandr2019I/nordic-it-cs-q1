using System;

namespace Calculator.Figure
{
	public sealed class Circle
	{
		private double _radius;

		public Circle(double radius)
		{
			_radius = radius;

		}
		public double Calculate(Func<double, double> operation)
		{
			return operation(_radius);

		}
	}

	public sealed class Square
	{
		private double _length;

		public Square(double length) //length
		{
			_length = length;
		}
		public double CalculateP(Func<double, double> operation)
		{
			return _length;
		}

	}
}
