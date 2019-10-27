using System;

namespace L12_C00_constructors
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person()
			{
				Name = "Test"
			};

			Employee e1 = new Employee()
			{
				Name = "Test2",
			};

			Console.WriteLine(p1.Type);
			Console.WriteLine(e1.Type);
			Console.WriteLine(((Person)e1).Type);
			Console.ReadKey();
		}
	}
}
