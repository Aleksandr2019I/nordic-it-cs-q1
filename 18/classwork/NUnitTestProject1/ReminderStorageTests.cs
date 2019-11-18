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
           var list = DateTimeOffset.Now;
            Assert.Catch<ArgumentNullException>(() =>
            list.;
        }

        public List<ReminderItem> FindByDateTime(DateTimeOffset dateTime)
        {
            if (dateTime == null)
            {
                throw new ArgumentNullException(nameof(dateTime));
            }
            return new List<ReminderItem>();
        }
    }
}