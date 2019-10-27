using System;

namespace L12_C03_virtual_override
{
	internal class Program
	{
		private static void Main()
		{
			var p1 = new Person
			{
				Name = "Artem",
				DateOfBirth = DateTimeOffset.Parse("1995-09-12")
			};

			p1.WriteShortDescription(); // Person name: Artem, date of birth: 14-03-82

			var e1 = new Employee
			{
				Name = "Artem",
				DateOfBirth = DateTimeOffset.Parse("1995-09-12"),
				EmployeeCode = "000001",
				HireDate = DateTimeOffset.Parse("2016-10-01")
			};

			e1.WriteShortDescription(); // Employee name: Artem, date of birth: 14-03-82

			Console.ReadLine();
		}
	}
}