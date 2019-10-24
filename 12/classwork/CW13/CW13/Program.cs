using System;

namespace CW13
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseDocument proga = new BaseDocument("abc", "35", DateTimeOffset.Parse("2017-10-15"));


			proga.WriteToConsole();

			Passport pass = new Passport("Pypu", "Multy", "23", DateTimeOffset.Parse("2017-8-11"));

			pass.WriteToConsole();

			Console.ReadKey();
		}
	}
}
