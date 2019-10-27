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
            Console.WriteLine($"Type = {GetType()} AlarmDate = {AlarmDate},AlarmMessage = {AlarmMessage},TimeToAlarm = {TimeToAlarm},IsOutdated = {IsOutdated},PhoneNumber = {PhoneNumber}");
        }
    }
}
