using System;

class Program
{
	static void Main()
	{
		// storing a string in a dynamic object
		dynamic anotherName = "Alexander";
		// this compiles but might throw an exception at run-time!
		int length = anotherName.Length;
		Console.WriteLine(length);
	}
}