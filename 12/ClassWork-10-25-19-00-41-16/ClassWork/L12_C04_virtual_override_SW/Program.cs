using System;

namespace L12_C04_virtual_override_SW
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var bd1 = new BaseDocument
			{
				Title = "Drive License",
				Number = "AB32DS32",
				IssueDate = DateTimeOffset.Parse("2012-02-03")
			};

			bd1.WriteToConsole();

			var p1 = new Passport
			{
				Title = "Passport",
				Number = "32135432",
				IssueDate = DateTimeOffset.Parse("2012-02-03"),
				PersonName = "Artem",
				Country = "Russia"
			};

			p1.WriteToConsole();

			Console.ReadKey();
		}
	}
}
