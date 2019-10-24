using System;

namespace CW12
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person()
			{
				Name = "Persone one",
				Age = 23

			};
			Console.WriteLine($"{person.Description}");
			Employee employee = new Employee()
			{
				Name = "Emp one",
				Age = 25,
				Company = "Company"
			};
			Console.WriteLine($"{ employee.Description}");
			Console.ReadKey();
		}


	}
}
