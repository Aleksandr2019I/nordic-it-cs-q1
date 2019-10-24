using System;
namespace CW13
{
	class BaseDocument
	{
		public string Title		{get;set ;}
		public string Number { get; set; }
		public DateTimeOffset IssueDate { get; set; }
		public string Description =>
			$"{Title},{Number},{IssueDate}";

		public void WriteToConsole()
		{
			Console.WriteLine(Description);
		}
	};
}
