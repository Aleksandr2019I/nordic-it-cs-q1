using System;

namespace L15_C06_delegate_demo
{
	public static class Operations
	{
		public static int Sum(int x, int y)
		{
			Console.WriteLine($"{nameof(Sum)} called");
			return x + y;
		}

		public static int Multiply(int x, int y)
		{
			Console.WriteLine($"{nameof(Multiply)} called");
			return x * y;
		}
	}
}
