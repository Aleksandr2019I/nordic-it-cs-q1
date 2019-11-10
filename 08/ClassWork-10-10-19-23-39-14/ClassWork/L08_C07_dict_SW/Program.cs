using System;
using System.Collections.Generic;

namespace L08_C07_dict_SW
{
	class Program
	{
		static void Main()
		{
			var countries = new Dictionary<string, string>
			{
				//["key"] = "value"
				// alternative syntax
				// { key, value }

				{ "Россия", "Москва" },
				{ "Франция", "Париж" },
				{ "Германия", "Берлин" },
				{ "Великобритания", "Лондон" }
			};

			while (true)
			{
				var (country, capital) = GetRandomPair(countries);

				// alternative, more simple syntx to
				// var kvp = GetRandomPair(countries);
				// var country = kvp.Key;
				// var capital = kvp.Value;

				Console.Write($"Введите столицу страны \"{country}\": ");
				var answer = Console.ReadLine()?.Trim();
				if (answer == capital)
				{
					Console.WriteLine("Правильно!");
				}
				else
				{
					Console.WriteLine("Вы проиграли :( Выходим...");
					break;
				}
			}
			Console.ReadKey();
		}

		static KeyValuePair<string, string> GetRandomPair(
			Dictionary<string, string> dictionary)
		{
			var random = new Random();
			var index = random.Next(dictionary.Count);
			var i = 0;

			foreach (var pair in dictionary)
			{
				if (i == index)
				{
					return pair;
				}

				++i;
			}

			throw new ArgumentOutOfRangeException();
		}
	}
}

