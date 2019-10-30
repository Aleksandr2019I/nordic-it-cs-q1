using System;
using System.Collections.Generic;
namespace HW8
{
    class Program
    {
        static void Main()
        {
            var text = ReadText();
            bool result = Check(text);
            Console.WriteLine($"{ result}");
            Console.ReadKey();
        }
        static string ReadText()
        {
            while (true)
            {
                Console.WriteLine("Введите строку:");
                var text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Вы ввели пустую строку :( Попробуйте ещё раз:");
                    continue;
                }
                return text;
            }
        }
        static bool Check(string text)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < text.Length;)
            {
                switch (text[i])
                {
                    case '(':
                    case '[':
                        stack.Push(text[i]);
                        break;
                    case ')':
                    case ']':
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        if (stack.Peek() == '(' || stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
                return true;
            }
            return false;
        }
    }
}
