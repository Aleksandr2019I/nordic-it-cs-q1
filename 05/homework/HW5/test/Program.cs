using System;

namespace test
{
    [Flags]
    enum Figures
    {
        none = 0,
        circle = 1,
        equilateral = 2,
        rectangle = 3
    }
    class Program
    {
        static void Main()
        {   
            var a = 6;
            var x = (Math.Sqrt(9)/4) * Math.Pow(a,2);
            Console.WriteLine(x);
            var y = Math.Pow(a, 2);
            Console.WriteLine(y);



            Console.ReadKey();
        }
    }
}
