using System;

namespace HW2
{

    
    class Program
    {
        [Flags]
        enum Container : byte
        {
            liter1 = 0x1 << 1,
            liter5 = 0x1 << 2,
            liter20 = 0x1 << 3,

        };


        static void Main()
        {
            double pCont;
            while (true)
            {
                Console.Write("Какой объем сока (в литрах) требуется упаковать? ");             
                if (double.TryParse(Console.ReadLine(), out pCont))
                {                   
                    break ;
                }
                Console.WriteLine("Wrong value");
            }

            Console.WriteLine($"Вам потребуются следующие контейнеры:");
            Console.ReadKey();
        }
     
    }
}
 