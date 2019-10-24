namespace L10_C03_class_fields_person_readonly
{
	class Person
	{
		private int m_age;
		public int Age
		{
			get { return m_age; }
			set
			{
				if (value > 0 && value < 140)
				{
					m_age = value;
				}
			}
		}

		public string Name { get; set; }

		public string DisplayName =>
			$"Name: {Name}, Age: {Age}.";
	}
}