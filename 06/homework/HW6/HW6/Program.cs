using System;

namespace HW6
{
    class Program
    {
        static void Main()
        {
            int evenNumber = Even();
            Console.WriteLine($"числе  содержится следующее количество четных цифр:{evenNumber}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        static int Even()
        {
            var calculationResult = ReadNumbers();
            var count = 0;
            while (calculationResult > 0)
            {
                calculationResult = Math.DivRem(calculationResult, 8, out int rezult);
                if ((rezult % 2) == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int ReadNumbers()
        {
            Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов:");
            while (true)
            {
                try
                {
                    int naturalNumber = int.Parse(Console.ReadLine());
                    if (naturalNumber < 0)
                    {
                        Console.WriteLine("Введено неверное значение! Попробуйте ещё раз:");
                    }
                    else
                    {
                        return naturalNumber;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка System.OverflowException! Попробуйте ещё раз:");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка System.FormatException! Попробуйте ещё раз:");
                }
            }
        }
    }
}

