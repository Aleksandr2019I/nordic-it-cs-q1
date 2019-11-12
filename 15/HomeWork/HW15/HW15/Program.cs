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
			var first = new ConsoleLogWriter();
			first.LogError("первое сообщение в консоль");
			var second = new FileLogWriter(filename);
			second.LogInfo(" запись в файл");
			var third = new MultipleLogWriter(first, second);
			third.LogWarning("и туда и туда");




            Console.ReadKey();
        }
    }
}