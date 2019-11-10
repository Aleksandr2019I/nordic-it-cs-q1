using System;

namespace HW14
{
    class ConsoleLogWriter : ILogWriter
    {

        private static ConsoleLogWriter _instance;

        public static ConsoleLogWriter Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new ConsoleLogWriter();
                }
                return _instance;
            }
        }

        private ConsoleLogWriter()
        { }
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{HW14.MessageType.Info} \t{message} ");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{HW14.MessageType.Warnig} \t{message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{HW14.MessageType.Error}\t{message}");
        }
    }
}
