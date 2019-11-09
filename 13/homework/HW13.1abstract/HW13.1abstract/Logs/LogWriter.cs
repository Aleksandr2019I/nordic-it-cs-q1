using System;

namespace HW13._1abstract
{
    abstract class LogWriter : ILogWriter
    {

        public void LogInfo(string message)
        {
            LogMessage(message, MessageType.Info.ToString());
        }
        public void LogWarning(string message)
        {
            LogMessage(message, MessageType.Warnig.ToString());
        }
        public void LogError(string message)
        {

            LogMessage(message, MessageType.Error.ToString());
        }

        protected abstract void WriteLine(string line);

        protected void LogMessage(string message, string type)
        {
            var line = FormatMessage(message, type);
            WriteLine(line);
        }
        protected string FormatMessage(string message, string type)
        {
            return $"{DateTime.Now:yyyy:MM:ddThh:mm:ss}+00:00\t{type} \t{message} ";
        }



    }

}
