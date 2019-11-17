using NUnit.Framework;
using System;


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
            storage.Create(null)
                );
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
                item
                );
            Assert.Catch<ArgumentException>(() =>
            storage.Create(item)
                );
        }

    }
}