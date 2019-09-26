using System;

class Program
{
	static void Main()
	{
		int? a = null;
		Console.WriteLine(a); // <null>
		a = 4;
		Console.WriteLine(a); // 4
	}
}