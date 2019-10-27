﻿using System;
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
                if (TimeToAlarm.TotalMilliseconds >= 0)
                {
                    return true;
                }
                return false;
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



    class PhoneReminderItem : Reminderitem 
    { 
        public string PhoneNumber { get; set; }

        public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage,string phoneNumber): base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;


        }

        public new void WriteProperties()
        {
            Console.WriteLine($"AlarmDate = {AlarmDate},AlarmMessage = {AlarmMessage},TimeToAlarm = {TimeToAlarm},IsOutdated = {IsOutdated}");

        }

    }

    class ChatReminderItem : Reminderitem 
    {
        
    }
    
}
