using System;

namespace L15_C07_delegate_multiple_demo
{
	delegate int PerformCalculation(int x, int y);

	class Program
	{
		static void Main(string[] args)
		{
			PerformCalculation performCalculation1 = Operations.Sum;
			PerformCalculation performCalculation2 = Operations.Multiply;

			// operator +=
			performCalculation1 += performCalculation2;

			// static method Delegate.Combine
			performCalculation1 = (PerformCalculation)Delegate.Combine(
				performCalculation1, performCalculation2);

			var multipleResult = performCalculation1(10, 5);
			Console.WriteLine($"{nameof(multipleResult)} = {multipleResult}");

			Console.WriteLine("\n***\n");

			// operator -=
			performCalculation1 -= performCalculation2;

			// method Remove()
			performCalculation1 = (PerformCalculation)Delegate.Remove(
				performCalculation1, performCalculation2);

			multipleResult = performCalculation1(10, 5);
			Console.WriteLine($"{nameof(multipleResult)} = {multipleResult}");
		}
	}
}
