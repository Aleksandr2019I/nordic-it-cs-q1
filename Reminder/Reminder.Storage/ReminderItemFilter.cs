using System;

namespace Reminder.Storage
{
	public class ReminderItemFilter
	{
		public DateTimeOffset? DateTime { get; set; }
		public ReminderItemStatus? Status { get; set; }
		public ReminderItemFilter At(DateTimeOffset dateTime)
		{
			DateTime = dateTime;
			return this;
		}

		public ReminderItemFilter Created()
		{
			Status = ReminderItemStatus.Created;
			return this;
		}
	}
}
