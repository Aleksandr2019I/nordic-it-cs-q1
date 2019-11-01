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
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '(':
                    case '[':
                        Console.WriteLine("записали в стек");
                        stack.Push(text[i]);
                        break;
                    case ')':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("стек пуст");
                            return false;
                        }
                        if (stack.Peek() == '(')
                        {
                            Console.WriteLine("тут скобоку вытолкнули");
                            stack.Pop();
                        }
                        break;
                    case ']':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("стек пуст");
                            return false;
                        }
                        if (stack.Peek() == '[')
                        {
                            Console.WriteLine("тут скобоку вытолкнули");
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("комбинация неверна");
                            return false;
                        }
                        break;
                    default:
                        Console.WriteLine("тут нету скобок");
                        return false;
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
