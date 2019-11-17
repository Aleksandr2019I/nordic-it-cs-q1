using System;

namespace L17_C05_events_eventargs_final
{
	public class WorkPerformedEventArgs : EventArgs
	{
		public int Hours { get; set; }
		public WorkType WorkType { get; set; }

		public WorkPerformedEventArgs(int hours, WorkType workType)
		{
			Hours = hours;
			WorkType = workType;
		}
	}
}
