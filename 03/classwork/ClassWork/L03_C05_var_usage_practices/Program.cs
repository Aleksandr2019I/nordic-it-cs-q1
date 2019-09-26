using System.IO;

class Program
{
	static void Main()
	{
		// Good
		var population = int.Parse("15");
		var fruit = "Apples";
		var letter = 'Z';
		var happy = true;
		var o = new object();

		// Bad
		var weight = 250_000_000_000;
		var price = 4.99;
		var file = File.CreateText("dummy.txt");
	}
}