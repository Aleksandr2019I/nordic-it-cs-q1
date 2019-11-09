using System;

namespace HW13._1abstract
{
    class ConsoleLogWriter : LogWriter
    {
        protected override void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }

}
