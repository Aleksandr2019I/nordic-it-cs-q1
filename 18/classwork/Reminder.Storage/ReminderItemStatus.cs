namespace Reminder.Storage
{
	public enum ReminderItemStatus
	{
		Created,
		Ready, //должны отправить но еще не отправили
		Sent,
		Failure,
	}
}
