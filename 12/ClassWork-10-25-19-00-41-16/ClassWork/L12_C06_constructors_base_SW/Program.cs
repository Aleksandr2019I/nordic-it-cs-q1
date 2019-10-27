using System;

namespace L12_C06_constructors_base_SW
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var bd1 = new BaseDocument(
				"Drive License",
				"AB32DS32",
				DateTimeOffset.Parse("2012-02-03"));
			bd1.WriteToConsole();

			var p1 = new Passport(
				"32135432",
				DateTimeOffset.Parse("2012-02-03"),
				"Artem",
				"Russia");
			p1.WriteToConsole();

			var p2 = new Passport(
				"32135432",
				DateTimeOffset.Parse("2012-02-03"));
			p2.WriteToConsole();

			var p3 = new Passport(
				"32135432",
				DateTimeOffset.Parse("2012-02-03"),
				"Artem");
			p3.WriteToConsole();

			var p4 = new Passport(
				"32135432",
				DateTimeOffset.Parse("2012-02-03"),
				"Russia",
				"Artem");
			p4.WriteToConsole();

			Console.ReadKey();
		}
	}
}
