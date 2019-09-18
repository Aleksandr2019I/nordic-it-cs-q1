using System;
using System.Threading;
using System.Text;

namespace L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Hello {name}!");
            Thread.Sleep(5000);
            Console.WriteLine($"Пока {name}!");
            Thread.Sleep(1000);
            Console.WriteLine("Нажмите любую клваишу для завершения работы программы");
            Console.ReadKey();
        }
    }
}


