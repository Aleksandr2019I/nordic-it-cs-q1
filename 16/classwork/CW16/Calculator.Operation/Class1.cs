using System;
using Calculator.Figure;


namespace Calculator.Operation
{
	public class CircleOperation
	{


		static public double Area(double _radius)
		{
			return Math.PI * Math.Pow(_radius, 2);
		}


		static public double Perimeter(double _radius)
		{
			return 2 * Math.PI * _radius;
		}
	}

	public class PerimeterOperation
	{
		static public double Perimeter(double _length)
		{

			return 4 * _length;
		}

		static public double Area(double _length)
		{
			return _length * _length;

		}


	}
}
