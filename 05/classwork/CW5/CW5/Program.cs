using System;

namespace CW5
{
	class Program
	{
		static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());
			var firstDigit = num / 10;
			var lastDigit = num % 10;
			
			switch (lastDigit)
			{ 
				case 1 when firstDigit > 1 || firstDigit == 0:				
				
					Console.WriteLine($"{num} год");
				break;
				case 2 when firstDigit > 1 || firstDigit == 0:
				case 3 when firstDigit > 1 || firstDigit == 0:
				case 4 when firstDigit > 1 || firstDigit == 0:
					Console.WriteLine($"{num} года");
				break;

				default:
					Console.WriteLine($"{num} лет");
					break;

			}
			
			Console.ReadKey();
		}
	}
}
