using System;
using System.Collections.Generic;
namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            var alarm = new Reminderitem(new DateTime(2019, 11, 25, 8, 00, 00), "Вставай");
            alarm.WriteProperties();
            var alarm1 = new Reminderitem(new DateTime(2019, 03, 20, 8, 00, 00), "Походу проспали");
            alarm1.WriteProperties();

            List<Reminderitem> list = new List<Reminderitem>();
            list.Add(new Reminderitem(new DateTime(2018, 9, 22, 7, 00, 00), "Ух"));
            list.Add(new PhoneReminderItem(new DateTime(2019, 10, 20, 10, 00, 00), "БУХ", "89661408888"));
            list.Add(new ChatReminderItem(new DateTime(2017, 8, 3, 12, 00, 00), "АХ", "ИМЯ чата", "ИМЯ Акка"));
            foreach (Reminderitem display in list)
            {
                display.WriteProperties();
            }
            Console.ReadKey();
        }
    }
}
