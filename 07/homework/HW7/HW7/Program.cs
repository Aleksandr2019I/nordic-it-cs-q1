using System;
using System.Text;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из нескольких слов:");
            while (true)
            {
                string word = Readtext();
                string[] massiv = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
                if (massiv.Length < 2)
                {
                    Console.WriteLine("Слишком мало слов :( Попробуйте ещё раз:");
                }
                else
                {
                    int j = default;
                    for (int i = 0; i < massiv.Length; i++)
                    {
                        if (massiv[i].StartsWith('A') | massiv[i].StartsWith('a') | massiv[i].StartsWith('А') | massiv[i].StartsWith('а'))
                        {
                            j++;
                        }
                    }
                    Console.WriteLine($"Количество слов, начинающихся с буквы 'А':{j}");
                    Console.WriteLine("Нажмите любую клавишу для выхода...");
                    Console.ReadKey();
                }
            }
        }
        static string Readtext()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    return input;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }
    }
}
