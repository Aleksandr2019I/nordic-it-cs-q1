using System;

namespace L15_C06_delegate_demo
{
	delegate int PerformCalculation(int x, int y);

	class Program
	{
		static void Main(string[] args)
		{
			PerformCalculation performCalculation = Operations.Sum;
			var result = performCalculation(10, 5);
			Console.WriteLine(result);

			performCalculation = Operations.Multiply;
			result = performCalculation(10, 5);
			Console.WriteLine(result);
		}

		private static void Swap<T>(ref T a, ref T b)
		{
			var temp = a;
			a = b;
			b = temp;
		}

		private static void BubbleSort<T>(T[] array, Comparison<T> comparaison)
		{
			for (var i = 0; i < array.Length - 1; i++)
			{
				var limit = array.Length - 1 - i;

				for (var j = 0; j < limit; j++)
				{
					if (comparaison(array[j], array[j + 1]) > 0)
					{
						Swap(ref array[j + 1], ref array[j]);
					}
				}
			}
		}
	}
}
