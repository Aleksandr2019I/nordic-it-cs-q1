using System;

/*
Написать консольное приложение, которое запрашивает 
1) сумму первоначального взноса, down payment amount
2) ежедневный процент дохода daily Income Percentage
3) желаемую сумму накопления. desired accumulation amount
Программа должна вывести номер дня, когда накопление впервые превысит желаемое.
     */
namespace HW7
{
    class Program
    {
        static void Main()
        {
            //var downPaymentAmount = decimal.Parse(Console.ReadLine());
            //var dailyIncomePercentage = decimal.Parse(Console.ReadLine());
            //var desiredAccumulationAmount = decimal.Parse(Console.ReadLine());
            decimal x = 100;
            decimal y = 0.0003m;
            decimal z = 200;
            decimal b = 0;

            for (int i = 0; i < x; i++)
            {
                var procent = x * y;
               
                Console.WriteLine($"{i},{a}");
            }
            Console.ReadKey();
            
        }
    }
}
