using System;

namespace HWlesson2
{
    class Program
    {
         static void Main(string[] args)
         {


             Console.WriteLine("Здравствуйте ,введите первое целое число"); 
             var firstOperand = int.Parse(Console.ReadLine());
             Console.WriteLine("введите второе целое число");
             var secondOperand = int.Parse(Console.ReadLine());
             Console.WriteLine($"Сумма данных чисел = {firstOperand + secondOperand}");
             Console.WriteLine($"А разница чисел = {firstOperand - secondOperand}");
             Console.WriteLine($"И наконец произведение чисел  = {firstOperand * secondOperand}");
             Console.WriteLine("для завершения нажмите любую клавишу");
             Console.ReadKey();

         } 


       }   
    
}
