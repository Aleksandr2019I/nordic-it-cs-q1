using System;

namespace L17_C03_events_demo_worker
{
	public enum WorkType
	{
		Work,
		DoNothing
	}

	internal class Program
	{
		private static void Main(string[] args)
		{
			var worker = new Worker();
			worker.WorkPerformed += OnWorkPerformed;
			worker.WorkCompleted += OnWorkCompleted;

			worker.DoWork(7, WorkType.Work);
			worker.DoWork(5, WorkType.DoNothing);
		}

		private static void OnWorkCompleted(object sender, EventArgs e)
		{
			Console.WriteLine($"WorkCompleted: {sender}.");
		}

		private static void OnWorkPerformed(int hours, WorkType workType)
		{
			Console.WriteLine($"WorkPerformed: {workType}, {hours} hour(s).");
		}
	}
}