using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Key Analyzer App"); // Writes text and starts a new line
		Console.Write("Enter string: "); // Writes text without starting a new line
		Console.WriteLine(); // Just starts a new line

		string s = Console.ReadLine(); // Reading a line
		Console.WriteLine(s); // Repeat the entered line on the screen

		ConsoleKeyInfo cki1 = Console.ReadKey(); // Reads a single key
		Console.WriteLine(cki1.Key.ToString());  // Writes the name of pressed key

		ConsoleKeyInfo cki2 = Console.ReadKey(false); // Reading single key (hidden)
		Console.WriteLine($"Key {cki2.Key}");  // Writes the name with template
	}
}