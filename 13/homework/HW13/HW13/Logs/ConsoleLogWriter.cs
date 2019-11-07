using System;
namespace HW13
{
    class ConsoleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{HW13.MessageType.Info} \t{message} ");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{HW13.MessageType.Warnig} \t{message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{HW13.MessageType.Error}\t{message}");
        }
    }


}
