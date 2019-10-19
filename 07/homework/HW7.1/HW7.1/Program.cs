using System;
using System.Text;
namespace HW7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = ReadText();

            StringBuilder reverse = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse.Append(word[i]);
            }
            Console.WriteLine($"{reverse}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        static string ReadText()
        {
            while (true)
            {
                Console.WriteLine("Введите непустую строку:");
                var word = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine("Вы ввели пустую строку :( Попробуйте ещё раз:");
                    continue;
                }
                return word.ToLowerInvariant();
            }
        }
    }
}
