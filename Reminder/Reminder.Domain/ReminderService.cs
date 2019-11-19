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

		private readonly Timer _createdItemTimer;

		private readonly IReminderStorage _storage;

		public ReminderService(IReminderStorage storage)
		{
			_storage = storage;
			_createdItemTimer = new Timer(OnTimertick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1))
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

			var filter = new ReminderItemFilter()
				.At(DateTimeOffset.Now)
				.Created();

			var items = _storage.FindByDateTime(new ReminderItemFilter());
			foreach (var item in items)
			{
				item.ReadyToSend(ReminderItemStatus.Ready);
				_storage.Update(item);
			}


		}

	}
}
