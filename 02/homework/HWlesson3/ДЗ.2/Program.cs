using System;

namespace ДЗ._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("какую операцию вы хотите выполнить +, -, *, /, %, ^");
            string select = Console.ReadLine(); // выбор операции
            if (select == "+")
                Console.WriteLine($"сумма = {N1 + N2}");
            else if (select == "-")
                Console.WriteLine($"вычетание = {N1 - N2}");
            else if (select == "*")
                Console.WriteLine($"умножение = {N1 * N2}");
            else if (select == "/")
                Console.WriteLine($"деление = {N1 / N2}");
            else if (select == "%")
                Console.WriteLine($"по модулю = {N1 % N2}");
            else if (select == "^")              
            {
                if (N1 == 0 & N2 == 0) //проверка освнования и степени на 0
                {
                    Console.WriteLine("Нуль в нулевой степени равен нулю");
                }
                else if (N2 == 0) // проверка степени на 0
                {
                    Console.WriteLine("число в нулевой степени равно Единице");
                }
                else if (N1 >= 0 & N2 > 0)                  
                {                  
                    var power = Math.Pow(N1, N2); // через math.pow
                    Console.WriteLine($"основание '{N1}' в степени '{N2}' = {power}");
                    // через for
                    Console.WriteLine("и еще 1 способ возведения в степень");
                    int c = 1; 
                    for (int i = 0; i < N2; i++)                        
                    {                    
                        c = c * N1;                                             
                    }
                    Console.WriteLine($"{N1}^{N2} = {c}");
                }                             
            }
            else

                Console.WriteLine("я незнаю такой операции");
                Console.WriteLine("для завершения нажмите любую клавишу");
                Console.ReadKey();
        }
    }
}
