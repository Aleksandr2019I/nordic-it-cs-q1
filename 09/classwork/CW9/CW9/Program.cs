using System;
using System.Diagnostics;
namespace CW9
{

	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int[] array = new int[99];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next();
			}
			mass(array);
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine($"{array[i]}");
			}
		}
		static void mass(int[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				var limit = array.Length - 1 - i;
				for (int j = 0; j < limit; j++)
				{
					if (array[j] < array[j + 1])
					{
						var temp = array[j + 1]; //1
						array[j + 1] = array[j]; // 0
						array[j] = temp; // 1
					};
				}
			}
		}
	}
}
