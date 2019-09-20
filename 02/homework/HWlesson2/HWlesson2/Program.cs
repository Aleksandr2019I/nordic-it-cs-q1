using System;

namespace HWlesson2
{
    class Program
    {
         static void Main(string[] args)
         {


             Console.WriteLine("Здравствуйте ,введите первое целое число"); 
             var N1 = int.Parse(Console.ReadLine());
             Console.WriteLine("введите второе целое число");
             var N2 = int.Parse(Console.ReadLine());
             Console.WriteLine($"Сумма данных чисел = {N1 + N2}");
             Console.WriteLine($"А разница чисел = {N1 - N2}");
             Console.WriteLine($"И наконец произведение чисел  = {N1 * N2}");
             Console.WriteLine("для завершения нажмите любую клавишу");
             Console.ReadKey();

         } 


       }   
    
}
