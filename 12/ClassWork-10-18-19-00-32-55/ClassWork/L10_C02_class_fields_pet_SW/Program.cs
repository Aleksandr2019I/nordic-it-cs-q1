using System;

namespace L10_C02_class_fields_pet_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var pet1 = new Pet();
			pet1.Kind = PetType.Mouse;
			pet1.Name = "Mikky";
			pet1.Age = 1;
			pet1.Sex = PetSex.Male;

			var pet2 = new Pet
			{
				Kind = PetType.Cat,
				Name = "Showball",
				Sex = PetSex.Female,
				Age = 3
			};

			Console.WriteLine(pet1.Information);
			Console.WriteLine(pet2.Information);
			Console.ReadKey();
		}
	}
}