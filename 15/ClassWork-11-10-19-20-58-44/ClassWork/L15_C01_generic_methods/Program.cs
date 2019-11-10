using System;

namespace L15_C01_generic_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = -1;
			var b = 100;
			Console.WriteLine($"a = {a}, b = {b}");
			Swapper.Swap(ref a, ref b);
			Console.WriteLine($"a = {a}, b = {b}");
			Console.ReadKey();
		}
	}
}
