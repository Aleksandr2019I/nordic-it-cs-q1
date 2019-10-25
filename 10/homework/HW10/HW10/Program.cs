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
                Console.WriteLine($"имя {j}");
                var name = Console.ReadLine();
                Console.WriteLine($"Возраст {j}");
                var age = byte.Parse(Console.ReadLine());
                parametr[j] = new People(name, age);
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
