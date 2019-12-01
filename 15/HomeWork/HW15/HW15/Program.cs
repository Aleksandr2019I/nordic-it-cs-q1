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
;
            var first = LogWriterFactory.Instance.GetLogWriter<ConsoleLogWriter>("");
            first.LogError("первый лог");

            var filename = ReadFileName();
            var second = LogWriterFactory.Instance.GetLogWriter<FileLogWriter>(filename);
            second.LogInfo(" запись в файл 2 лог");

            var third = LogWriterFactory.Instance.GetLogWriter<MultipleLogWriter>(filename);
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