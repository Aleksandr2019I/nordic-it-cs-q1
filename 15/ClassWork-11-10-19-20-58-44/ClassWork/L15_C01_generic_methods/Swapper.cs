namespace L15_C01_generic_methods
{
	public static class Swapper
	{
		public static void Swap<TArgument>(ref TArgument a, ref TArgument b)
		{
			var c = a;
			a = b;
			b = c;
		}
	}
}
