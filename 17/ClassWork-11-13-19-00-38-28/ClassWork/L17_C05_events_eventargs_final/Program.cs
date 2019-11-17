using System;

namespace L17_C05_events_eventargs_final
{
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

		private static void OnWorkPerformed(object sender, WorkPerformedEventArgs e)
		{
			Console.WriteLine($"WorkPerformed: {e.WorkType}, {e.Hours} hour(s).");
		}
	}
}