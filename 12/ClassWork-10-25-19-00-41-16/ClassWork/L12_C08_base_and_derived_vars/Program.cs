using System;

namespace L12_C08_base_and_derived_vars
{
	internal class Program
	{
		private static void Main()
		{
			var p1 = new Person("Artem", DateTimeOffset.Parse("1995-09-12"));
			p1.WriteShortDecription(); // Person name: Artem, date of birth: 14-03-82

			Person e1 = new Employee(
				"Artem",
				DateTimeOffset.Parse("1995-09-12"),
				"000001",
				DateTimeOffset.Parse("2016-10-01"));

			e1.WriteShortDecription();
			// Employee code: 000001, name: Artem,
			// date of birth: 14-03-82, hire date: 01-10-16

			// Two lines below will raise compiler error
			// as Person doesn't know about these fields
			//Console.WriteLine(e1.HireDate);
			//Console.WriteLine(e1.EmployeeCode);

			Console.WriteLine("\n***\nSee experiments with base type:\n***");

			var persons = new Person[3]
			{
				new Person("Maria", DateTimeOffset.Parse("1987-03-01")),
				new Person("Sergey", DateTimeOffset.Parse("1981-12-27")),
				new Employee("Artem", DateTimeOffset.Parse("1995-09-12"), "000001", DateTimeOffset.Parse("2016-10-01"))
			};

			foreach (var person in persons)
			{
				// First option:
				// Use is opetator and type conversion
				if (person is Employee)
				{
					var employeeConverted = (Employee)person;

					Console.WriteLine(
						$"{employeeConverted.GetType().Name} " +
						$"code: {employeeConverted.EmployeeCode}, " +
						$"name: {employeeConverted.Name}, " +
						$"date of birth: {employeeConverted.DateOfBirth:dd-MM-yy}, " +
						$"hire date: {employeeConverted.HireDate:dd-MM-yy}");
				}

				// Second option:
				// Use as operator and comparaision against null
				var employeeCasted = person as Employee;
				if (employeeCasted != null)
				{
					Console.WriteLine(
						$"{employeeCasted.GetType().Name} " +
						$"code: {employeeCasted.EmployeeCode}, " +
						$"name: {employeeCasted.Name}, " +
						$"date of birth: {employeeCasted.DateOfBirth:dd-MM-yy}, " +
						$"hire date: {employeeCasted.HireDate:dd-MM-yy}");
				}

				// Third option:
				// Use is declaration syntax
				if (person is Employee employee)
				{
					Console.WriteLine(
						$"{employee.GetType().Name} " +
						$"code: {employee.EmployeeCode}, " +
						$"name: {employee.Name}, " +
						$"date of birth: {employee.DateOfBirth:dd-MM-yy}, " +
						$"hire date: {employee.HireDate:dd-MM-yy}");
				}

				// Also, if-else can ba converted to switch expression
				switch(person)
				{
					case Employee employeeMatched:
						Console.WriteLine(
							$"{employeeMatched.GetType().Name} " +
							$"code: {employeeMatched.EmployeeCode}, " +
							$"name: {employeeMatched.Name}, " +
							$"date of birth: {employeeMatched.DateOfBirth:dd-MM-yy}, " +
							$"hire date: {employeeMatched.HireDate:dd-MM-yy}");
						break;
					default:
						// no-op
						break;
				}

				person.WriteShortDecription();
			}

			Console.ReadKey();
		}
	}
}
