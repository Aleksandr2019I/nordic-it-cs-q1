using System;

namespace HW15
{
    enum MessageType
    {
        Info,
        Warnig,
        Error
    }
    class Program
    {
        static void Main()
        {
            //var first = LogWriterFactory.Instance;
            //first.GetLogWriter(ConsoleLogWriter);
            var second = LogWriterFactory.Instance;



            Console.ReadKey();
        }
    }
}