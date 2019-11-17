using System;

namespace L17_C02_events_demo_no_good
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	public delegate int WorkPerformedHandler(
		int hours,
		WorkType workType);

	internal class Program
	{
		private static void Main(string[] args)
		{
			var del1 = new WorkPerformedHandler(WorkPerformed1);
			var del2 = new WorkPerformedHandler(WorkPerformed2);
			var del3 = new WorkPerformedHandler(WorkPerformed3);

			var finalDelegate = del1 + del2 + del3;
			var finalResult = finalDelegate(1, WorkType.Work);

			Console.WriteLine(finalResult);
		}

		private static int WorkPerformed1(int hours, WorkType workType)
		{
			Console.WriteLine(
				$"{nameof(WorkPerformed1)} called with ({workType},{hours})");

			return hours + 1;
		}

		private static int WorkPerformed2(int hours, WorkType workType)
		{
			Console.WriteLine(
				$"{nameof(WorkPerformed2)} called with ({workType},{hours})");

			return hours + 2;
		}

		private static int WorkPerformed3(int hours, WorkType workType)
		{
			Console.WriteLine(
				$"{nameof(WorkPerformed3)} called with ({workType},{hours})");

			return hours + 3;
		}
	}
}