using System;
namespace HW12
{
    class PhoneReminderItem : Reminderitem
    {
        public string PhoneNumber { get; set; }
        public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber) : base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
        }
        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine($"PhoneNumber = {PhoneNumber}");
        }
    }
}
