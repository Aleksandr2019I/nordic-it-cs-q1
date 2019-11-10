using System;

namespace L15_C05_generic_constraints_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = -1;
			var b = 100;
			Console.WriteLine($"a = {a}, b = {b}");
			Swapper<int>.Swap(ref a, ref b);
			Console.WriteLine($"a = {a}, b = {b}");

			var c = MathF.PI;
			var d = MathF.E;
			Console.WriteLine($"c = {c}, d = {d}");
			Swapper<float>.Swap(ref c, ref d);
			Console.WriteLine($"c = {c}, d = {d}");

			// this will not work
			//string e = "Hello";
			//string f = "World";
			//Console.WriteLine($"e = {e}, f = {f}");
			//Swapper<string>.Swap(ref e, ref f);
			//Console.WriteLine($"e = {e}, f = {f}");

			// this will not work!
			//int[] arr1 = { 1, 2, 3 };
			//int[] arr2 = { };
			//Console.WriteLine($"arr1.Length = {arr1.Length}, arr2.Length = {arr2.Length}");
			//Swapper<int[]>.Swap(ref arr1, ref arr2);
			//Console.WriteLine($"arr1.Length = {arr1.Length}, arr2.Length = {arr2.Length}");

			var array = new int[] { 1, 3, 71, 67, 10 };
			Swapper<int>.BubbleSort(array);
			Console.WriteLine($"{string.Join(", ", array)}");

			var arrayDoubles = new double[] { 1, 3, 71, 67, 10 };
			Swapper<double>.BubbleSort(arrayDoubles);
			Console.WriteLine($"{string.Join(", ", arrayDoubles)}");
		}
	}
}
