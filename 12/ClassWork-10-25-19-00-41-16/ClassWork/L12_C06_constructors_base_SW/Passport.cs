using System;

namespace L12_C06_constructors_base_SW
{
	public class Passport : BaseDocument
	{
		public string Country { get; set; }

		public string PersonName { get; set; }

		public Passport(
			string number,
			DateTimeOffset issueDate)
			: base("Passport", number, issueDate)
		{
		}

		public Passport(
			string number,
			DateTimeOffset issueDate,
			string personName)
			: this(number, issueDate)
		{
			PersonName = personName;
		}

		public Passport(
			string number,
			DateTimeOffset issueDate,
			string country,
			string personName) : this(number, issueDate, personName)
		{
			Country = country;
		}

		public override string Description
		{
			get
			{
				if(Country == null && PersonName == null)
				{
					return base.Description;
				}

				return $"{Title} #{Number} issued "
					   + $"{IssueDate:dd-MM-yy} in "
					   + $"{Country} for {PersonName}";
			}
		}
	}
}
