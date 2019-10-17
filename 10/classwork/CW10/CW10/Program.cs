using System;

namespace CW10
{
	class Program
	{


		static void Main(string[] args)
		{
			Pet pet = new Pet()
			{
				Name = "The Dog",
				Kind = "Dog",
				Sex = 'M',
				Age = 10
			};

			Console.WriteLine($"The lalal {pet.Name},{pet.Kind},{pet.Sex},{pet.Age}");
			

			Console.WriteLine(pet.Description);

			Pet pet1 = new Pet();
			pet1.Name = "The Cat";
			pet1.Kind = "Cat";
			pet1.Sex = 'W';
			pet1.Age = 22;

		}
	}
}
