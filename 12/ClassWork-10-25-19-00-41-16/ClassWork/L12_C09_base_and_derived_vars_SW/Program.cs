using System;

namespace L12_C09_base_and_derived_vars_SW
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var documents = new BaseDocument[2]
			{
				new BaseDocument(
					"Drive License",
					"AB32DS32",
					DateTimeOffset.Parse("2012-02-03")),
				new Passport(
					"32135432",
					DateTimeOffset.Parse("2012-02-03"),
					"Artem",
					"Russia")
			};

			foreach (var document in documents)
			{
				if (document is Passport passport)
				{
					passport.ChangeIssueDate(DateTimeOffset.UtcNow);
				}

				document.WriteToConsole();
			}

			Console.ReadKey();
		}
	}
}
