using System;
using System.Collections.Generic;
namespace HW8
{
    class Program
    {
        static void Main()
        {

            var text = Console.ReadLine();
            char[] array = text.ToCharArray();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case '(':
                        stack.Push('(');
                        break;
                    case '[':
                        stack.Push('[');
                        break;
                    case ')':
                        stack.Contains('(');
                        stack.Pop();
                        break;
                    case ']':
                        stack.Contains('[');
                        stack.Pop();
                        break;
                    default:
                        if (stack.Count == 0)
                        {
                            throw new ArgumentException("кегли закончились");
                            
                        }
                        continue;
                        
                }

            }

            Console.ReadKey();
        }
    }
}
