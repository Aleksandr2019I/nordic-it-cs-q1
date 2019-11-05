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

        static void Main(string[] args)
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
            mult.LogWarning("ВОт 1ЭТО ОШИБКа");
            mult.LogError("1Err");
            mult.LogInfo("1ИНфо");

            //var consoleLogWriter = new ConsoleLogWriter();

            //var multipleLogWriter = new MultipleLogWriter();

            //File.AppendAllLines(@"F:\C#\nordic-it-cs-q1\13\homework\HW13\File",); //добовляет в конец
            //File.WriteAllText(); //замена содержимого
            //File.AppendAllLines();
            //File.ReadAllText();

            Console.ReadKey();

        }

    }
}
