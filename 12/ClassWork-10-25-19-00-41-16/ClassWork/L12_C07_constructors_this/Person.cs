using System;
using System.Diagnostics;

namespace L12_C07_constructors_this
{
	public class Person
	{
		public string Name { get; set; }

		public DateTimeOffset DateOfBirth { get; set; }

		public Person(string name, DateTimeOffset dateOfBirth)
		{
			Name = name;
			DateOfBirth = dateOfBirth;
			Debug.WriteLine("Constructor Person(name, dateOfBirth) called");
		}

		public virtual string ShortDescription =>
			$"{GetType().Name} " +
			$"name: {Name}, " +
			$"date of birth: {DateOfBirth:dd-MM-yy}";

		public void WriteShortDecription()
		{
			Console.WriteLine(ShortDescription);
		}
	}
}