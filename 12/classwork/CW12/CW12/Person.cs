namespace CW12
{
	class Person
	{
		public byte Age { get; set; }
		public string Name { get; set; }
		public string Description
		{
			get
			{
				return $"and Age";
			}
		}
	}


}
