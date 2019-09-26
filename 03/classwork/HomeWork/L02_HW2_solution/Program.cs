using System;
using System.Text;

namespace L02_HW2_solution
{
	// Первый вариант домашнего задания. 
	// Здесь представлен пример реализации без каких-либо проверок входных параметров. 
	// Несмотря на то, что програма работает в общем случае, какая либо ошибка ввода приводит к ее падению. 

	class Program
	{
		static void Main()
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.WriteLine("Calculator");
			Console.WriteLine($"Operands range: {double.MinValue}–{double.MaxValue}");
			Console.WriteLine($"Use one of the following operators: +, -, *, /, %, ^");
			Console.WriteLine();

			var firstOperand = double.Parse(Console.ReadLine());
			var secondOperand = double.Parse(Console.ReadLine());
			var operation = Console.ReadLine();
			var result = double.NaN;

			if (operation == "+")
			{
				result = firstOperand + secondOperand;
			}
			else if (operation == "-")
			{
				result = firstOperand - secondOperand;
			}
			else if (operation == "*")
			{
				result = firstOperand * secondOperand;
			}
			else if (operation == "/")
			{
				result = firstOperand / secondOperand;
			}
			else if (operation == "%")
			{
				result = firstOperand % secondOperand;
			}
			else if (operation == "^")
			{
				result = Math.Pow(firstOperand, secondOperand);
			}
			else
			{
				Console.WriteLine("Wrong value");
			}

			Console.Write($"\n{firstOperand} {operation} {secondOperand} = ");
			Console.WriteLine($"{result}");
		}
	}
}
