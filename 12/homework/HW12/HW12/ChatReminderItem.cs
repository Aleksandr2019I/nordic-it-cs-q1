﻿using System;
namespace HW12
{
    class ChatReminderItem : Reminderitem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }
        public ChatReminderItem(DateTimeOffset alarmDate, string alarmMessage, string chatName, string accountName) : base(alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
        }
        public override void WriteProperties()
        {
            Console.WriteLine($"Type = {GetType()} ,AlarmDate = {AlarmDate},AlarmMessage = {AlarmMessage},TimeToAlarm = {TimeToAlarm},IsOutdated = {IsOutdated},ChatName = {ChatName},AccountName = {AccountName} ");
        }
    }
}
