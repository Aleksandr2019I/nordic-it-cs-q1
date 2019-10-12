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
            string word = Console.ReadLine();

            string[] massiv = word.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                

            if (massiv.Length < 2)
            {
                Console.WriteLine("Слишком мало слов :( Попробуйте ещё раз:");
            }
            else
            {
                    for (int i = 0; i < massiv.Length; i++)
                    {

                    }
                    Console.WriteLine($"Количество слов, начинающихся с буквы 'А': ");
                    
            }

                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
            
        }
    }
}
