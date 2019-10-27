using System;

namespace L12_C09_base_and_derived_vars_SW
{
	public class Passport : BaseDocument
	{
		public string Country { get; set; }

		public string PersonName { get; set; }

		public Passport(
			string number,
			DateTimeOffset issueDate,
			string country,
			string personName) : base("Passport", number, issueDate)
		{
			Country = country;
			PersonName = personName;
		}

		public override string Description =>
			$"{Title} #{Number} issued "
			+ $"{IssueDate:dd-MM-yy} in "
			+ $"{Country} for {PersonName}";

		public void ChangeIssueDate(DateTimeOffset newIssueDate)
		{
			IssueDate = newIssueDate;
		}
	}
}
