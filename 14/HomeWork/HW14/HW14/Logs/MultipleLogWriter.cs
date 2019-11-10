using System.Collections.Generic;

namespace HW14
{
    class MultipleLogWriter : ILogWriter
    {
        private static MultipleLogWriter _instance;

        public static MultipleLogWriter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MultipleLogWriter(ConsoleLogWriter.Instance, FileLogWriter.Instance);
                }
                return _instance;
            }
        }

        readonly List<ILogWriter> list = new List<ILogWriter>
        {
        };
        private  MultipleLogWriter(ConsoleLogWriter cLog, FileLogWriter fLog)
        {
            list.Add(cLog);
            list.Add(fLog);
        }
        public void LogInfo(string message)
        {
            list[0].LogInfo(message);
            list[1].LogInfo(message);
        }
        public void LogWarning(string message)
        {
            list[0].LogWarning(message);
            list[1].LogWarning(message);
        }
        public void LogError(string message)
        {
            list[0].LogError(message);
            list[1].LogError(message);
        }
    }
}
