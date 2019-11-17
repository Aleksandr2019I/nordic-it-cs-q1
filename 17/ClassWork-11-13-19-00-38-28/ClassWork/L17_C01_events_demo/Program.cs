using System;

namespace L17_C01_events_demo
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	public delegate void WorkPerformedEventHandler(
		int hours, 
		WorkType workType);

	internal class Program
	{
		private static void Main(string[] args)
		{
			WorkPerformedEventHandler del1 = WorkPerformed1;
		}

		private static void WorkPerformed1(
			int hours, WorkType workType)
		{
			Console.WriteLine($"Work of type {workType}: {hours} hours");
		}
	}
}
