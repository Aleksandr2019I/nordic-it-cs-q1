using System;

namespace HWlesson3
{

        class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            var firstOperand = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            var secondOperand = int.Parse(Console.ReadLine());
            Console.WriteLine("какую операцию вы хотите выполнить: если сложение то введи знак '+',если вычетание то знак '-',умножение знак '*',деление знак '/', остаток по модул знак '%',возвести в степень знак '^'");
            string operation = Console.ReadLine(); // выбор операции
            if (operation == "+")
            {
                Console.WriteLine($"сумма = {firstOperand + secondOperand}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"вычетание = {firstOperand - secondOperand}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"умножение = {firstOperand * secondOperand}");
            }
            else if (operation == "/")
            {
                Console.WriteLine($"деление = {firstOperand / secondOperand}");
            }
            else if (operation == "%")
            {
                Console.WriteLine($"по модулю = {firstOperand % secondOperand}");
            }
            else if (operation == "^")
            {
                if (firstOperand == 0 & secondOperand == 0) //проверка освнования и степени на 0
                {
                    Console.WriteLine("Нуль в нулевой степени равен нулю");
                }
                else if (secondOperand == 0) // проверка степени на 0
                {
                    Console.WriteLine("число в нулевой степени равно Единице");
                }
                else if (firstOperand >= 0 & secondOperand > 0)
                {
                    var powerOperand = Math.Pow(firstOperand, secondOperand); // через math.pow
                    Console.WriteLine($"основание '{firstOperand}' в степени '{secondOperand}' = {powerOperand}");       
                }
            }
            else
            {

                Console.WriteLine("я незнаю такой операции");
                
                
            }
            Console.WriteLine("для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

}
