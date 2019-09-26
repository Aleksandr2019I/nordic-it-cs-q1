using System;

class Program
{
	static void Main()
	{
		// declaring and defining all the array at once
		string[] names =
		{
			"Andrey",
			"Maria",
			"Alexander",
			"Eugenia",
		};

		for (int i = 0; i < names.Length; i++)
		{
			Console.WriteLine(names[i]); // read the item at this index
		}
	}
}