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
            Console.WriteLine("Введите сумму первоначального взноса в рублях:");
            decimal downPaymentAmount = ReadValue();  // начальная сумма
            Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01):");
            decimal dailyIncomePercentage = ReadValue();  // процент в день
            Console.WriteLine("Введите желаемую сумму накопления в рублях:");
            decimal desiredAccumulationAmount = ReadValue(); // сумма к которой стремимся
            var day = 0; // кличество дней
            do
            {
                downPaymentAmount += (downPaymentAmount * dailyIncomePercentage);
                day++;
            }
            while (downPaymentAmount <= desiredAccumulationAmount);
            Console.WriteLine($"Необходимое количество дней для накопления желаемой суммы:{day}.");
            Console.WriteLine($"Нажмите любую клавишу для выхода…");
            Console.ReadKey();
        }
        static decimal ReadValue()
        {
            while (true)
            {
                try
                {
                    decimal input = decimal.Parse(Console.ReadLine());
                    return input;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы вышли за предел значений");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели строку , а нужно число");
                }
            }
        }

    }
}
