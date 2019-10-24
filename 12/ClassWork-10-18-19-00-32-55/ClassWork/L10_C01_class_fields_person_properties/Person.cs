namespace L10_C01_class_fields_person_properties
{
	class Person
	{
		private int _age;

		public int Age
		{
			get { return _age; }
			set
			{
				if (value > 0 && value < 140)
				{
					_age = value;
				}
			}
		}

		public string Name { get; set; }
	}
}