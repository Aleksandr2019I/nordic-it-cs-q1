using System;
using System.Collections.Generic;
namespace HW8
{
    class Program
    {
        static void Main()
        {
            var text = "[]()"; //Console.ReadLine();
            char[] array = text.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case '(':
                    case '[':
                        stack.Push(array[i]);
                        break;
                    case ')':
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        else if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        break;
                    case ']':
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        else if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
