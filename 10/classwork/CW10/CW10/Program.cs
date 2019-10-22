using System;

namespace CW10
{
	class Program
	{
		static void Main(string[] args)
		{
		//	Pet pet2 = new Pet();
		//	pet2.Name = "The Cat";
		//	pet2.Kind = "Cat";
		//	pet2.Sex = 'W';
		//	pet2.DateOfBirth = new DateTime(2015, 3, 23);
		//	pet2.Display(true);
		//	Console.WriteLine(pet2.Description);

		//	Pet pet1 = new Pet()
		//	{
		//		Name = "The Dog",
		//		Kind = "Dog",
		//		Sex = 'M',
		//		DateOfBirth = new DateTime(2018, 9, 15)
		//};
			////Console.WriteLine($"The lalal {pet.Name},{pet.Kind},{pet.Sex},{pet.Age}");
			//pet1.Display(false);

			var nameType = new Pet(name: Console.ReadLine(), kind: Console.ReadLine());
			Console.WriteLine($"{nameType.ShortDescription} ");

			Console.ReadKey();
		}
	}
}
