using System;
using System.Collections.Generic;
namespace HW8
{
    class Program
    {
        static void Main()
        {
            var text = ReadText();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    switch (text[i])
                    {
                        case '(':
                        case '[':
                            stack.Push(text[i]);
                            break;
                        case ')':
                        //if (stack.Count == 0)
                        //{
                        //    throw new InvalidOperationException();
                        //}
                        //if (stack.Peek() == '(')
                        //{
                        //    stack.Pop();
                        //}
                        //break;
                        case ']':
                            if (stack.Count == 0)
                            {
                                throw new InvalidOperationException();
                            }
                            if (stack.Peek() == '[' || stack.Peek() == '[')
                            {
                                stack.Pop();
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("стек пустой");
                }
            }
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
    }
}
