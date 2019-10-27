using System;

namespace L12_C02_hiding_members_SW
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
				PersonName = "Artem Trofimushkin",
				Country = "Russia"
			};

			p1.WriteToConsole();

			Console.ReadKey();
		}
	}
}
