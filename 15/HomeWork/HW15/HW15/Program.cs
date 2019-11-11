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
            var filename = Console.ReadLine();
            var first = LogWriterFactory.Instance;
            first.GetLogWriter<ConsoleLogWriter>(new ConsoleLogWriter());

            var second = LogWriterFactory.Instance;
            second.GetLogWriter<FileLogWriter>(new FileLogWriter(filename));
            
            var third = LogWriterFactory.Instance;
            third.GetLogWriter<MultipleLogWriter>(new MultipleLogWriter(first, second));



            Console.ReadKey();
        }
    }
}