using System.Collections.Generic;

namespace HW13._1abstract
{
    class MultipleLogWriter : ILogWriter
    {
        private readonly List<ILogWriter> list = new List<ILogWriter>
        {
        };
        public MultipleLogWriter(ConsoleLogWriter cLog, FileLogWriter fLog)
        {
            list.Add(cLog);
            list.Add(fLog);
        }
        public void LogInfo(string message)
        {
            foreach (var i in list)
            {
                i.LogInfo(message);
            }

            //list[0].LogInfo(message);
            //list[1].LogInfo(message);
        }
        public void LogWarning(string message)
        {
            foreach (var i in list)
            {
                i.LogWarning(message);
            }
            //    list[0].LogWarning(message);
            //    list[1].LogWarning(message);
        }
        public void LogError(string message)
        {
            foreach (var i in list)
            {
                i.LogError(message);
            }
            //list[0].LogError(message);
            //list[1].LogError(message);
        }
    }


}
