using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            var alarm = new Reminderitem(new DateTime(2019, 11, 25,8, 00, 00), "Вставай");
            alarm.WriteProperties();
            var alarm1 = new Reminderitem(new DateTime(2019, 03, 20, 8, 00, 00), "Походу проспали");
            alarm1.WriteProperties();
            Console.ReadKey();
        }
    }
 
}
