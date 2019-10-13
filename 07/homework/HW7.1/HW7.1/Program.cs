using System;

namespace HW7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            string words;
            Console.WriteLine("Введите непустую строку:");
            while (true)
            {
                try
                {
                    word = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(word))
                    {
                        Console.WriteLine("Вы ввели пустую строку :( Попробуйте ещё раз:");
                    }
                    else
                    {
                        words = word.ToLowerInvariant();
                        for (int i = words.Length - 1; i >= 0; i--)
                        {
                            Console.Write(words[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую клавишу для выхода...");
                    }
                }
                catch (Exception) // не понимаю какое тут мб исключение, поэтому поставил общее
                {
                    Console.WriteLine("Исключение");
                }
            }
        }
    }
}
