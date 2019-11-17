using System;

namespace L17_C03_events_demo_worker
{
	public delegate void WorkPerformedHandler(int hours, WorkType workType);

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
				WorkPerformed(hours, workType);
			}
		}
	}
}
