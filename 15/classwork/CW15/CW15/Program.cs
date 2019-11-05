using System;


namespace CW15
{
	class Program
	{
		static public double Area(double _radius)
		{
			return Math.PI*Math.Pow(_radius,2);

			
		}
		static public double perimtr(double _radius)
		{
			return 2*Math.PI*_radius;


		}
		static void Main(string[] args)
		{
			//var first = new Account<int>(12,"po");
			//var second = new Account<string>("text","text2");
			//var guides = new Account<Guid>(Guid.NewGuid(), "pff");
			//first.WriteProperties();
			//second.WriteProperties();
			//guides.WriteProperties();


			var first = new Circle(1.5);
			first.Calculate(Area);
			first.Calculate(perimtr);

			Console.ReadLine($"{first.}");

			Console.ReadKey();
		}
	}
	//class Account<T>
	//{
	//	public  T Id { get; private set; }
	//	public string Name { get; private set; }
	//	public Account( T id, string name)
	//	{
	//		Id = id;
	//		Name = name;
	//	}
	//	public void WriteProperties()
	//	{
	//		Console.WriteLine($"id - {Id},name - {Name}");

	//	}
	//}

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
