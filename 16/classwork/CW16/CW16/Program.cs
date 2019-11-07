using System;

namespace CW16
{
	class Program
	{
		static public double Area(double _radius)
		{
			return Math.PI * Math.Pow(_radius, 2);
		}


		static public double perimtr(double _radius)
		{
			return 2 * Math.PI * _radius;
		}

		static void Main(string[] args)
		{
			var first = new Circle(1.5);
			first.Calculate((r)=>Math.PI*Math.Pow(r,2) );
			//first.Calculate(perimtr);
			first.Calculate(per => 2 * Math.PI*per);

			Console.WriteLine($"{first.Calculate(Area)}");

			Console.WriteLine($"{first}");

			Console.ReadKey();
		}
	}

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

}
