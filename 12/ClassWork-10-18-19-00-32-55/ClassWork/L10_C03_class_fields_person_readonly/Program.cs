using System;

namespace L10_C03_class_fields_person_readonly
{
	class Program
	{
		static void Main()
		{
			var person = new Person
			{
				Name = "Some",
				Age = 12
			};

			// Now we shouldn't think about the format of output for parameters in the main code
			// We can just call PropertiesString where all the logic is encapsulated
			Console.WriteLine(person.DisplayName);

			// The line below will not be compiled as the property is read-only!
			// person.DisplayName = "Try to override read-only property";
		}
	}
}