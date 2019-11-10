using System;

namespace Calculator.Figure
{
	public class Square
	{
		private readonly double _side;

		public Square(double side)
		{
			_side = side;
		}

		public double Calculate(Func<double, double> operation)
		{
			return operation(_side);
		}
	}
}
