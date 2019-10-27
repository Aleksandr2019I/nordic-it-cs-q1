using System;

namespace L12_C01_hiding_members
{
	public class Person
	{
		public string Name { get; set; }

		public DateTimeOffset DateOfBirth { get; set; }

		public string ShortDescription =>
			$"{GetType().Name} " +
			$"name: {Name}, " +
			$"date of birth: {DateOfBirth:dd-MM-yy}";

		public void WriteShortDescription()
		{
			Console.WriteLine(ShortDescription);
		}
	}
}
