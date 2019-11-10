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
            var file = FileLogWriter.Instance ;
            file.LogWarning("ВОт ЭТО ОШИБКа");
            file.LogError("Err");
            file.LogInfo("ИНфо");
            var mult = MultipleLogWriter.Instance;
            mult.LogInfo("конлсь инфо");
            mult.LogWarning("конлсь варнинг");
            mult.LogError("конлсь ерор");
            Console.ReadKey();
        }
    }
}
