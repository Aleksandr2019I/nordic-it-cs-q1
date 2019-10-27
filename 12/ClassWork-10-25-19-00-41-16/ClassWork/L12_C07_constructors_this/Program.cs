using System;

// Program.cs

namespace L12_C07_constructors_this
{
	internal class Program
	{
		private static void Main()
		{
			var p1 = new Person("Artem", DateTimeOffset.Parse("1995-09-12"));
			p1.WriteShortDecription(); // Person name: Artem, date of birth: 14-03-82

			var e1 = new Employee(
				"Artem",
				DateTimeOffset.Parse("1995-09-12"),
				"000001",
				DateTimeOffset.Parse("2016-10-01"));

			e1.WriteShortDecription();
			// Employee code: 000001, name: Artem,
			// date of birth: 14-03-82, hire date: 01-10-16

			Console.ReadKey();
		}
	}
}