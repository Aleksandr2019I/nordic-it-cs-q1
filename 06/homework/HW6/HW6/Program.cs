using System;

namespace HW6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов:");
            while (true)
            {

                try
                {

                    int number = int.Parse(Console.ReadLine());

                    else 
                    {
                        Console.WriteLine("Введено неверное значение! Попробуйте ещё раз:");
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Ошибка {ex.StackTrace}! Попробуйте еще раз:");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Ошибка {ex.Message}! Попробуйте еще раз:");
                }
            }


        }
        static int Bll()
        {
            if (number > 0)
            {
                int count = 0;

                var x = Math.DivRem(number, 10, out int result);
                if ((result % 2) == 0)
}
            Console.WriteLine($"в числе {number} содержится следующее количество четных цифр:{count} ");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
            break;
        }
    }

    }
}
