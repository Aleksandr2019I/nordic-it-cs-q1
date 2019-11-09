using System;
using System.IO;

namespace HW13
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
            var cons = new ConsoleLogWriter();
            cons.LogWarning("ВОт ЭТО ОШИБКа");
            cons.LogError("Err");
            cons.LogInfo("ИНфо");
            var file = new FileLogWriter();
            file.LogWarning("ВОт ЭТО ОШИБКа");
            file.LogError("Err");
            file.LogInfo("ИНфо");
            var mult = new MultipleLogWriter(cons, file);
            mult.LogInfo("конлсь инфо");
            mult.LogWarning("конлсь варнинг");
            mult.LogError("конлсь ерор");
            Console.ReadKey();
        }
    }
}
