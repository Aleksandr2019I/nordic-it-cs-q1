using System;
using System.Collections.Generic;

namespace HW13
{
    class MultipleLogWriter : ILogWriter
    {


        List<ILogWriter> list = new List<ILogWriter>
        {
        };


        public MultipleLogWriter(ConsoleLogWriter cLog, FileLogWriter fLog)
        {
            list.Add(cLog);
            list.Add(fLog);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{HW13.MessageType.Info} \t{message} ");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{HW13.MessageType.Warnig} \t{message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy:MM:ddThh:mm:ss}+00:00\t{HW13.MessageType.Error}\t{message}");
        }
    }

}