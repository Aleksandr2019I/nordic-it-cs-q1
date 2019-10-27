using System;

namespace L12_C04_virtual_override_SW
{
	public class BaseDocument
	{
		public string Title { get; set; }

		public string Number { get; set; }

		public DateTimeOffset IssueDate { get; set; }

		public virtual string Description => $"{Title} #{Number} issued {IssueDate:dd-MM-yy}";

		public void WriteToConsole()
		{
			Console.WriteLine(Description);
		}
	}
}
