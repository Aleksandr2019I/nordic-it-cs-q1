using System;

namespace L12_C02_hiding_members_SW
{
	public class BaseDocument
	{
		public string Title { get; set; }

		public string Number { get; set; }

		public DateTimeOffset IssueDate { get; set; }

		public string Description => 
			$"{Title} #{Number} issued {IssueDate:dd-MM-yy}";

		public void WriteToConsole()
		{
			Console.WriteLine(Description);
		}
	}
}
