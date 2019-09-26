using System;

class Program
{
	static void Main()
	{
		Console.WriteLine($"{default(int)}"); // 0
		Console.WriteLine($"{default(bool)}"); // False
		Console.WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00

		Console.WriteLine($"{default(string)}"); // ???
	}
}