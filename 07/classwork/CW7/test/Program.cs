using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "my test string";
            string[] words = test.Split(' ');
            foreach (string word in words)
                Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
