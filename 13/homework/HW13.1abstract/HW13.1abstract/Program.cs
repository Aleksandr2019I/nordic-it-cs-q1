using System;

namespace HW13._1abstract
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
            var cons = new ConsoleLogWriter();
            cons.LogWarning("ВОт ЭТО ОШИБКа");
            cons.LogError("Err");
            cons.LogInfo("ИНфо");
            var file = new FileLogWriter(filename);
            file.LogWarning("ВОт ЭТО ОШИБКа");
            file.LogError("Err");
            file.LogInfo("ИНфо");
            var mult = new MultipleLogWriter(cons, file);
            mult.LogInfo("конлсь инфо");
            mult.LogWarning("конлсь варнинг");
            mult.LogError("конлсь ерор");
            Console.ReadKey();
        }
        static string  ReadFileName()
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
