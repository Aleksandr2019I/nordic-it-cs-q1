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
                var name = ReadName();
                Console.WriteLine($"Возраст {j}");
                var age = ReadAge();
                characteristics[j] = new People(name, age);
            };
            for (int i = 0; i < characteristics.Length; i++)
            {
                Console.WriteLine($"{characteristics[i].AllDescription}");
            };
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
        static byte ReadAge()
        {
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out var input)) //проверка на число
                {
                    return input;
                }
                Console.WriteLine("неверное значение");
            }
        }
        static string ReadName()
        {
            while (true)
            {
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("некоректный ввод");
                }
                return name;
            }
        }
    }
}
