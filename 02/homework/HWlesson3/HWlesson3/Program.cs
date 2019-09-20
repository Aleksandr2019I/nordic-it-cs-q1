using System;

namespace HWlesson3
{
   
        class Medical
        {
            public static string getDozaLekarstva(int ves)
            {
                if (ves >= 60) return "Вам нужно принимать по 2 таблетки витамина";
                else
                    return "Ваша норма -одна таблетка";
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {

                Console.ReadLine(Medical.getDozaLekarstva(60));
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
            }
        }

}
