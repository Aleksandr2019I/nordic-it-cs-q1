namespace L10_C04_class_fields_pet_readonly_SW
{
	public class Pet
	{
		public string Kind;
		public string Name;
		public char Sex;
		public byte Age;

		public string Description =>
			$"{Name} is a {Kind} ({Sex}) of {Age} years old.";
	}
}