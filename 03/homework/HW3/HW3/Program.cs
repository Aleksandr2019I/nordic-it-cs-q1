using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW3
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("enter the names of three people"); // введите имена трех человек          
            string[] names = new string [3];
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                names[i]=name;

            }

            Console.WriteLine("enter their age"); // введите их возраст
            int[] ages = new int[3];
            for (int i = 0; i < 3; i++)
            {
                
                while (true)
                {
                    
                    var ageResult = int.TryParse(Console.ReadLine(), out var age);
                    ages[i]=age;
                    if (ageResult)
                    {
                        break;
                    }
                    Console.WriteLine("Wrong Value!");
                }

            }

            for (int i = 0; i < 3; i++)
            {
                WriteWithColor("Name: ", ConsoleColor.Gray);
                WriteWithColor($"{names[i]}", ConsoleColor.DarkYellow);
                WriteWithColor(", age in 4 years:", ConsoleColor.Gray);
                WriteWithColor($"{ages[i]}", ConsoleColor.DarkYellow);
                Console.WriteLine();
            }         
            Console.ReadKey();
        }

        

        static void WriteWithColor(string text, ConsoleColor color)
        {
            var restoreColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = restoreColor;
        }

    }
}
