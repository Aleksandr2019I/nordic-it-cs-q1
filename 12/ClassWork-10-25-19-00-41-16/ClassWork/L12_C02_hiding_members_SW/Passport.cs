using System;

namespace L12_C02_hiding_members_SW
{
	public class Passport : BaseDocument
	{
		public string Country { get; set; }

		public string PersonName { get; set; }

		public new string Description =>
			$"{Title} #{Number} issued "
			+ $"{IssueDate:dd-MM-yy} in "
			+ $"{Country} for {PersonName}";

		public new void WriteToConsole()
		{
			Console.WriteLine(Description);
		}
	}
}
