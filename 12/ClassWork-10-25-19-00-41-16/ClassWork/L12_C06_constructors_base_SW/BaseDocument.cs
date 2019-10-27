using System;

namespace L12_C06_constructors_base_SW
{
	public class BaseDocument
	{
		public string Title { get; set; }

		public string Number { get; set; }

		public DateTimeOffset IssueDate { get; set; }


		public BaseDocument(
			string title,
			string number,
			DateTimeOffset issueDate)
		{
			Title = title;
			Number = number;
			IssueDate = issueDate;
		}

		public virtual string Description => $"{Title} #{Number} issued {IssueDate:dd-MM-yy}";

		public void WriteToConsole()
		{
			Console.WriteLine(Description);
		}
	}
}
