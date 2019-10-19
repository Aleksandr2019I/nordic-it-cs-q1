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
                Console.WriteLine($"Введит име и возраст");
                parametr[j] = new People(Console.ReadLine(),int.Parse(Console.ReadLine()));
            };          

            for (int i = 0; i < parametr.Length; i++)
            {
                Console.WriteLine($"{parametr[i].AllDescription}");
            }
            
            Console.ReadKey();
        }
    }
}
