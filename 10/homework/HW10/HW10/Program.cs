using System;

namespace HW10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя и возраст для 3 человек");
            People[] characteristics = new People[3];
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"имя {j}");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("некоректный ввод");
                }
                Console.WriteLine($"Возраст {j}");
                var age = byte.Parse(Console.ReadLine());
                if (age < 0)
                {
                    Console.WriteLine("возраст должен быть больше нуля");
                }
                characteristics[j] = new People(name, age);
            };
            for (int i = 0; i < characteristics.Length; i++)
            {
                Console.WriteLine($"{characteristics[i].AllDescription}");
            };
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
