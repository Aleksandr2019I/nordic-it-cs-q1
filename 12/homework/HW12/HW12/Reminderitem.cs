using System;
namespace HW12
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
        public virtual void WriteProperties()
        {
            Console.WriteLine($"Type = {GetType()},  AlarmDate = {AlarmDate},AlarmMessage = {AlarmMessage},TimeToAlarm = {TimeToAlarm},IsOutdated = {IsOutdated}");
        }
    }
}
