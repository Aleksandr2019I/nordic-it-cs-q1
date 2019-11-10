using System;
using System.Collections.Generic;

namespace L08_C06_dict
{
	class Program
	{
		static void Main()
		{
			var countries = new Dictionary<int, string>(5);
			countries.Add(1, "Russia");
			countries.Add(3, "Great Britain");
			countries.Add(2, "USA");
			countries.Add(4, "France");
			countries.Add(5, "China");

			foreach (var keyValue in countries)
			{
				Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
			}

			// getting elements by key
			var country = countries[4];      // #4 is "France"
											 // changing of the value by index
			countries[4] = "Spain";             // #4 has changed, now it "Spain"
												// removing by key
			countries.Remove(2);                // now "Great Britain" deleted
			Console.ReadKey();
		}
	}
}

