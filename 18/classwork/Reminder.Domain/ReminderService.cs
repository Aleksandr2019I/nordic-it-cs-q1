using System;
using System.Threading;
using Reminder.Storage;
namespace Reminder.Domain

{
	public class CreateReminderModel
	{
		public string ContactId { get;  set; }
		public string Message { get;  set; }
		public DateTimeOffset MessageDate { get;  set; }
	}
	public class ReminderService
	{
		private readonly Timer _timer;

		private readonly IReminderStorage _storage;

		public ReminderService(IReminderStorage storage)
		{
			_storage = storage;
			_timer = new Timer(OnTimertick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1))
			{ };
		}
		public void Create(CreateReminderModel model)
		{
			var item = new ReminderItem(
				Guid.NewGuid(),
				model.ContactId,
				model.Message,
				model.MessageDate);
			_storage.Create(item);
		}

		private void OnTimertick(object state)
		{

		}

	}
}
