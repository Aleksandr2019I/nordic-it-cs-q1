using System;

namespace HW14
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
            var cons = ConsoleLogWriter.Instance;
            cons.LogWarning("ВОт ЭТО ОШИБКа");
            cons.LogError("Err");
            cons.LogInfo("ИНфо");
            var filename = ReadFileName();
            var file = FileLogWriter.Instance ;
            file.LogWarning("ВОт ЭТО ОШИБКа");
            file.LogError("Err");
            file.LogInfo("ИНфо");
            var mult = new MultipleLogWriter(cons, file);
            mult.LogInfo("конлсь инфо");
            mult.LogWarning("конлсь варнинг");
            mult.LogError("конлсь ерор");
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
