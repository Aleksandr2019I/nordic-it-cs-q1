using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2;
            for (int power = 0; power <= 32; power++)
                Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})",
                                  value, power, (int)Math.Pow(value, power));
            Console.ReadKey();
        }
    }
}
