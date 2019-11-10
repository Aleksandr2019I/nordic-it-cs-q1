using System;
using System.IO;

namespace HW15
{
    class FileLogWriter : ILogWriter
    {

        public readonly string _filename;

        public FileLogWriter(string filename)
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