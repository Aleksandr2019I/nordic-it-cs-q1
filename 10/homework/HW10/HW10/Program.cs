using System;

namespace HW10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя и возраст для 3 человек");
            People[] parametr = new People[3];
            for (int j = 0; j < 3; j++)
            {
                parametr[j] = new People();
            };
            for (int i = 0; i < parametr.Length; i++)
            {
                Console.WriteLine($"{parametr[i].AllDescription}");
            };
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
