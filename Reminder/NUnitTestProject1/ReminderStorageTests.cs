using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderStorageTests
    {
        [Test] // Whenunit_IfCondition_ShouldExpectedResult
        public void WhenCreate_IfEmptyStorage_ShouldFindItemById()
        {
            //Arrenge
            var item = new ReminderItem(
                Guid.NewGuid(),
                "123",
                "Some text",
                DateTimeOffset.Now);
            var storage = new ReminderStorage();
            //Act
            storage.Create(item);
            //Assert
            var result = storage.FindById(item.Id);
            Assert.AreEqual(item.Id, result.Id);
        }
        [Test]
        public void WhenCreate_IfNullSpecified_ShouldThrowException()
        {
            var storage = new ReminderStorage();

            Assert.Catch<ArgumentNullException>(() =>
            storage.Create(null));
        }
        [Test]
        public void WhenCreate_IfExistsElementWithKey_ShouldThrowException()
        {
            var item = new ReminderItem(
                Guid.NewGuid(),
                "123",
                "Some text",
                DateTimeOffset.Now);
            var storage = new ReminderStorage(
                item);
            Assert.Catch<ArgumentException>(() =>
            storage.Create(item)
                );
        }
        [Test]
        public void WhenUpdate_IfNullSpecified_ShouldThrowException()
        {
            var storage = new ReminderStorage();
            Assert.Catch<ArgumentNullException>(() =>
            storage.Update(null));
        }


        [Test]
        public void WhenFindByDateTime_IfNullSpecified_ShouldThrowException()
        {
			var storage = new ReminderStorage();
			Assert.Catch<ArgumentException>(() => storage.FindByDateTime(default));
        }
		[Test]
		public void WhenFindByDateTime_IsSpecifiedDateTime_ShouldFilterBy()
		{
			var datetime = DateTimeOffset.Parse("12.11.2019 14:30:00.120");
			var storage = new ReminderStorage(new ReminderItem(
				Guid.NewGuid(),
				"123",
				"Some text",
				DateTimeOffset.Parse("12.11.2019 14:28:00.120"))
				 );

			var result = storage.FindByDateTime(datetime);

			Assert.IsNotEmpty(result);

		}




	}
}