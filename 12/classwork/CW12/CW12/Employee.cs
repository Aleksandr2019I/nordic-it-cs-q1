namespace CW12
{
	class Employee : Person
	{
		public string Company { get; set; }

		public new string Description =>
			$"Name is \"{Name} and Age  is {Age} in Company {Company}";
	}
}
