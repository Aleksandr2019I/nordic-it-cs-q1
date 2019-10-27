using System;

namespace L12_C03_virtual_override
{
	public class Person
	{
		public string Name { get; set; }
		public DateTimeOffset DateOfBirth { get; set; }

		public virtual string ShortDescription =>
			$"{GetType().Name} " +
			$"name: {Name}, " +
			$"date of birth: {DateOfBirth:dd-MM-yy}";

		public void WriteShortDescription()
		{
			Console.WriteLine(ShortDescription);
		}
	}
}
