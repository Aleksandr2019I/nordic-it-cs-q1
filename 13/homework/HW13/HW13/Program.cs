using System;
using System.IO;

namespace HW13
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var file1 = new ConsoleLogWriter("sdsd","info");
            file1.LogWarning("ВОт ЭТО ОШИБКа");


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
