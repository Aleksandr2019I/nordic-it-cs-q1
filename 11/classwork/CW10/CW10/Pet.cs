using System;
namespace CW11
{
	class Pet
	{
		// У публичных полей название с БОЛЬШОЙ буквы.
		// 
		public string Kind;
		public string Name;
		public char Sex;
		public DateTime DateOfBirth;
		public byte GetAge()
		{
			DateTime date = DateTime.Now;
			TimeSpan difference = date - DateOfBirth;
			double days = difference.TotalDays;
			double years = days / 365;
			return (byte)Math.Floor(years);
		}

		public void Display(bool isShortDescription)
		{
			if (isShortDescription)
			{
				Console.WriteLine(Description);
			}
			else
			{
				Console.WriteLine(ShortDescription);
			}
		}

		public Pet (string name, string kind)
		{
			Name = name;
			Kind = kind;
		}



		public string ShortDescription
		{
			get
			{
				return $"{Name} and {Kind}";
			}
		}

		public string Description
		{
			get
			{
				return $"the lalal {Name},{Kind},{Sex},{GetAge()}";
			}
		}

		//public string Description =>
		//	$"The lalal {Name},{Kind},{Sex},{Age}";

	}
}
