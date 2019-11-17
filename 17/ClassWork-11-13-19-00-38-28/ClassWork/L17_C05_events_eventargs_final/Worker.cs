using System;

namespace L17_C05_events_eventargs_final
{
	public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

	public class Worker
	{
		public event WorkPerformedHandler WorkPerformed;
		public event EventHandler WorkCompleted;

		public void DoWork(int hours, WorkType workType)
		{
			for (var i = 0; i < hours; i++)
			{
				OnWorkPerfomed(i + 1, workType);
			}

			OnWorkCompleted();
		}

		protected virtual void OnWorkCompleted()
		{
			if (WorkCompleted != null)
			{
				WorkCompleted(this, EventArgs.Empty);
			}
		}

		protected virtual void OnWorkPerfomed(int hours, WorkType workType)
		{
			if (WorkPerformed != null)
			{
				WorkPerformed(this, new WorkPerformedEventArgs(hours, workType));
			}
		}
	}
}
