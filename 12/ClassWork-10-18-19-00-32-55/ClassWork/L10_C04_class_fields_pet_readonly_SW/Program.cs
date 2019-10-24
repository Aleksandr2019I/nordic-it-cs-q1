using System;

namespace L10_C04_class_fields_pet_readonly_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var pet1 = new Pet();
			pet1.Kind = "Cat";
			pet1.Name = "Tom";
			pet1.Sex = 'M';
			pet1.Age = 8;
			Console.WriteLine(pet1.Description);

			var pet2 = new Pet
			{
				Kind = "Mouse",
				Name = "Minnie",
				Sex = 'F',
				Age = 1
			};
			Console.WriteLine(pet2.Description);
		}
	}
}