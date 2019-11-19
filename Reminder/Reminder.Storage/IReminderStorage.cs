using System;
using System.Collections.Generic;

namespace Reminder.Storage
{
	/// <summary>
	/// Определяет основные методы хранилища напоминаний
	/// </summary>
	public interface IReminderStorage
	{
		/// <summary>
		/// Сохраняет новый элемент ReminderItem <see cref="ReminderItem"/>
		/// </summary>
		/// <param name="item">элемент ReminderItem</param>
		void Create(ReminderItem item);

		/// <summary>
		/// Обновляет данные элемента ReminderItem  <see cref="ReminderItem"/>
		/// </summary>
		/// <param name="item">элемент ReminderItem</param>
		void Update(ReminderItem item);

		/// <summary>
		/// Реализует поиск элемента  <see cref="ReminderItem"/> по индентификатору
		/// </summary>
		/// <param name="id">Идентификатор Элемента</param>
		/// <returns>Найденный элемент  <see cref="ReminderItem"/></returns>
		ReminderItem FindById(Guid id);

		/// <summary>
		///Возвращает все элементы <see cref="ReminderItem"/> не позднее указанной даты
		/// </summary>
		/// <param name="filter">параметры фильтра </param>
		/// <returns>Коллекция элементов  <see cref="ReminderItem"/></returns>
		List<ReminderItem> FindByDateTime(ReminderItemFilter filter);
	}
}
