using System;

namespace L15_C05_generic_constraints_demo
{
	public static class Swapper<T>
		// where T : struct
		// where T : class
		where T : IComparable<T>
		// where T : new()
		// where T : fixed
		// where T : class, IComparable<T>, new()
	{
		public static void Swap(ref T a, ref T b)
		{
			var temp = a;
			a = b;
			b = temp;
		}

		public static void BubbleSort(T[] array)
		{
			for (var i = 0; i < array.Length - 1; i++)
			{
				var limit = array.Length - 1 - i;

				for (var j = 0; j < limit; j++)
				{
					if (array[j].CompareTo(array[j + 1]) > 0)
					{
						Swap(ref array[j + 1], ref array[j]);
					}
				}
			}
		}
	}
}
