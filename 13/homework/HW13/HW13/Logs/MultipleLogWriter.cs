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