using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Reminder.Storage.Memory.Tests") ]
namespace Reminder.Storage.Memory
{
	public class ReminderStorage : IReminderStorage
	{
		private readonly Dictionary<Guid, ReminderItem> _map;
			

		internal ReminderStorage(params ReminderItem[] items)
		{
			_map = items.ToDictionary(item => item.Id);
		}
		public ReminderStorage()
		{
			_map= new Dictionary<Guid, ReminderItem>();


		}


		public void Create(ReminderItem item)
		{
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}

			if (_map.ContainsKey(item.Id))
			{
				throw new ArgumentNullException($"Уже существует элемент с идентификатором {item.Id}");
			}

			_map[item.Id] = item;
		}

		public List<ReminderItem> FindByDateTime(DateTimeOffset dateTime)
		{
			throw new NotImplementedException();
		}
		public ReminderItem FindById(Guid id)
		{
			if (!_map.ContainsKey(id))
			{
				throw new ArgumentException($"не найден эелемент с ключом {id}", nameof(id));			
			}
			return _map[id];
		}

		public void Update(ReminderItem item)
		{
			throw new NotImplementedException();
		}
	}
}
