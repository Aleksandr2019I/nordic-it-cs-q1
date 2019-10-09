using System;

namespace CW7
{
	class Program
	{
		static void Main(string[] args)
		{
			var first = double.Parse(Console.ReadLine());
			var second = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Enter two real numbers to multiply them");
			Console.WriteLine(second + "*" + first + "=" + second + first); //конкатинация
			Console.WriteLine($"{first:#.##} - {second:#.##} = {second - first:#.##}"); //интерполяция
			Console.WriteLine("{0:#.##} + {1:#.##} = {2:#.##}", first, second,second + first); // форматирование
			


			Console.ReadKey();


		}
	}
}
