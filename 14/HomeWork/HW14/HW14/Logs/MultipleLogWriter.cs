using System.Collections.Generic;

namespace HW14
{
    class MultipleLogWriter : ILogWriter
    {
        private readonly List<ILogWriter> list;
        public MultipleLogWriter(ConsoleLogWriter cLog, FileLogWriter fLog)
        {
            list = new List<ILogWriter> { cLog, fLog };
        }
        public void LogInfo(string message)
        {
            foreach (var i in list)
            {
                i.LogInfo(message);
            }
        }
        public void LogWarning(string message)
        {
            foreach (var i in list)
            {
                i.LogWarning(message);
            }
        }
        public void LogError(string message)
        {
            foreach (var i in list)
            {
                i.LogError(message);
            }
        }
    }
}
