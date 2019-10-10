using System;
using System.Collections.Generic;
namespace CW8._1
{
	class Program
	{
		static void Main(string[] args)
		{
			var capitals = new Dictionary<string, string>
			{
				["Russia"] = "Moscow",
				["USA"] = "Washington",
				["Great britain"] = "London"
			};
			

			while (true)
			{
				KeyValuePair<string, string> randomElement = GetRandomElement(capitals);
				Console.WriteLine($"Какая столица страны  {randomElement.Key} ");
				 var val = Console.ReadLine();
				if (val == randomElement.Value)
				{
					Console.WriteLine("Вы правы, молодец");
				}
				else
				{
					Console.WriteLine("Вы ошиблись, пока.");
					break;
				}

			}

			Console.ReadKey();
		}

		static KeyValuePair<string, string> GetRandomElement(Dictionary<string, string> capitals)
		{
			var random = new Random();
			var i = 0;
			var index = random.Next(0, capitals.Count);

			foreach (var pair in capitals)
			{
				if (i == index)
				{
					return pair;
				}
				i++;
			}
			throw new IndexOutOfRangeException();
		}

	}
}
