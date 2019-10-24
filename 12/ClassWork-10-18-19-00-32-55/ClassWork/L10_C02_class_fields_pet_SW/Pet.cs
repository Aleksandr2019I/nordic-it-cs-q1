namespace L10_C02_class_fields_pet_SW
{
	public class Pet
	{
		public PetType Kind;
		public string Name;
		public PetSex Sex;
		public byte Age;

		public string Information =>
			$"{Name} is a {Kind} ({Sex}) of {Age} years old.";
	}
}