using System;

namespace test
{
    class Program
    {
        static void Main()
        {
            var x = TopL();
            Console.WriteLine($"{x}");
            Console.ReadKey();
        }
        static int TopL()
        {
            var number = int.Parse(Console.ReadLine());
            var count = 0;

            while (number > 0)
            { 
            number = Math.DivRem(number, 10, out int rez);
            if ((rez % 2) == 0)
            {
                count++;
            }
            
            }
            return count;
        }
           
    }
}
