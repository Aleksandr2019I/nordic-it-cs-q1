using System;
using System.IO;
namespace HW14
{
    class FileLogWriter : ILogWriter
    {
        private readonly string _filename;
        private static FileLogWriter _instance;
        public static FileLogWriter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FileLogWriter("F:\\C#\\logg.log");
                }
                return _instance;
            }
        }
        private FileLogWriter(string filename)
        {
            _filename = filename;
        }

        public void LogInfo(string message)
        {
            File.AppendAllText(_filename, $"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{MessageType.Info} \t{message} " + "\n");
        }
        public void LogWarning(string message)
        {
            File.AppendAllText(_filename, $"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{MessageType.Warnig} \t{message}" + "\n");
        }
        public void LogError(string message)
        {
            File.AppendAllText(_filename, $"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{MessageType.Error} \t{message}" + "\n");
        }
    }
}
