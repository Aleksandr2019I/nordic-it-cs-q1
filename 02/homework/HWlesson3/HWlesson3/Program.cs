using System;

namespace HWlesson3
{

        class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("какую операцию вы хотите выполнить , +, -, *, /, %, ^");
            string select = Console.ReadLine(); // выбор операции
            if (select == "+")
                Console.WriteLine($"сумма {N1 + N2}");
            else if (select == "-")
                Console.WriteLine($"вычетание {N1 - N2}");
            else if (select == "*")
                Console.WriteLine($"умножение {N1 * N2}");
            else if (select == "/")
                Console.WriteLine($"деление {N1 / N2}");
            else if (select == "%")
                Console.WriteLine($"по модулю {N1 % N2}");
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
                    var power = power * (N2); // возведение в степень

                    Console.WriteLine(power);
                }

            }


            else

                Console.WriteLine("я незнаю такой операции");
            Console.WriteLine("для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

}
