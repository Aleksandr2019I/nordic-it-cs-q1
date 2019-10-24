using System;

namespace L10_C01_class_fields_person_properties
{
	class Program
	{
		static void Main()
		{
			var person = new Person();

			// p1.m_age - inaccessable as it is private
			person.Name = "Some";
			person.Age = 36;

			Console.WriteLine($"Name: {person.Name}, Age: {person.Age}.");
			Console.ReadKey();
			// Name: Some, Age: 36.
		}
	}
}