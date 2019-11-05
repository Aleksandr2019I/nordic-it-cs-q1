using System;
using System.IO;
//YYYY-MM-DDTHH:MM:SS+0000 <tab> MessageType<tab> Message
//, где MessageType может быть “Info”, “Warning” или “Error”.
//WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{message}");

namespace HW13
{
    class FileLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"{message}");
            //File.AppendAllLines(@"F:\c#\nordic-it-cs-q1\13\log.log", $"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{MessageType.Info} \t{message}");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{MessageType.Warnig} \t{message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{MessageType.Error}\t{message}");
        }
    }

}
