using System;

namespace CW6
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
			var counter = 0;
			var sum = 0;
			while (counter < num.Length)
			{
				sum += num[counter];
				Console.WriteLine("{0}", sum);
				++counter;
				  
					
			}

			Console.ReadKey();
		}
	}
}
