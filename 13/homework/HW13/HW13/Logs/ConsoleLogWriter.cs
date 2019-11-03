using System;
namespace HW13
{
    class ConsoleLogWriter : ILogWriter
    {
        public string Message { get; set; }
        public string MessageType { get; set; }

        public ConsoleLogWriter(string message,string messageType)
        {
            MessageType = messageType;
            Message = message;

        }
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{message}");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{message}");
        }
    }


}
