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

                    if (number > 0)
                    {
                        var count = 0;
                        var numbers = 0;                           
                            numbers = Math.DivRem(number, 10, out int rezult);

                            if ((rezult % 2) == 0)
                            {
                                 count++;
                            
                            }
                            
                        Console.WriteLine($"в числе {number} содержится следующее количество четных цифр:{count} ");
                        Console.WriteLine("Нажмите любую клавишу для выхода...");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение! Попробуйте ещё раз:");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка {ex.Message}! Попробуйте еще раз:");

                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка {ex.Message}! Попробуйте еще раз:");
                }
            }
            
        }


    }


}

