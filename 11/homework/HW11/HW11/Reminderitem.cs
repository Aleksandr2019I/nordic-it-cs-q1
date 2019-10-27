using System;
namespace HW11
{
    class Reminderitem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm
        {
            get { return DateTime.Now - AlarmDate; }
        }
        public bool IsOutdated
        {
            get
            {
                return TimeToAlarm.TotalMilliseconds >= 0;
            }
        }
        public Reminderitem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }
        public void WriteProperties()
        {
            Console.WriteLine($"AlarmDate = {AlarmDate},AlarmMessage = {AlarmMessage},TimeToAlarm = {TimeToAlarm},IsOutdated = {IsOutdated}");
        }
    }
}
