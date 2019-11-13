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
            var filename = ReadFileName();
            var first = new ConsoleLogWriter();
            first.LogError("первое сообщение в консоль");
            var second = new FileLogWriter(filename);
            second.LogInfo(" запись в файл");
            var third = new MultipleLogWriter(first, second);
            third.LogWarning("и туда и туда");
            Console.ReadKey();
        }
        static string ReadFileName()
        {
            while (true)
            {
                Console.WriteLine("введите путь файла");
                var filename = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(filename))
                {
                    Console.WriteLine("Вы ввели пустую строку :( Попробуйте ещё раз:");
                    continue;
                }
                return filename;
            }
        }
    }
}