using System;
using System.Text;

namespace L02_HW2_solution_1
{
	// Вариант домашнего задания посложнее, с проверкой входных данных. 
	// Как можно заметить, код программы довольно сильно увеличился и усложнился. 
	// Проверки входных данных в теле основного метода Main затрудняют чтение кода и усложняют понимание программы. 
	// Также нетрудно дублирование кода, что в общем случае - плохая пракика, т.к. усложняет поддержку программы в будующем (банально приходиться править код в двух местах). 

	class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			Console.WriteLine("Calculator");
			Console.WriteLine($"Operands range: {double.MinValue}–{double.MaxValue}");

			var operations = new char[] { '+', '-', '*', '/', '%', '^' };
			Console.WriteLine($"Use one of the following operators: {string.Join(", ", operations)}");
			Console.WriteLine();

			double firstOperand;

			// Бесконечный цикл не дает продолжить программу, пока пользователь не введет корректные данные. 
			while (true)
			{
				Console.Write("Enter the first value: ");

				// Метод TryParse возаращает результат выполнения операции, который используется в условии
				// На текущий момент, не стоит вдаваться в подробности реализации ключевого слова out. 
				// Достаточно знать, что оно позволяет связать результат выполнения операции с аргументом. 

				if (double.TryParse(Console.ReadLine(), out firstOperand))
				{
					// Прерывание бесконечного цикла while(true), в случае успешного ввода. 
					break;
				}

				Console.WriteLine("Wrong value");
			}

			// Бесконечный цикл не дает продолжить программу, пока пользователь не введет корректные данные. 
			double secondOperand;
			while (true)
			{
				Console.Write("Enter the first value: ");

				// Метод TryParse возаращает результат выполнения операции, который используется в условии
				// На текущий момент, не стоит вдаваться в подробности реализации ключевого слова out. 
				// Достаточно знать, что оно позволяет связать результат выполнения операции с аргументом. 

				if (double.TryParse(Console.ReadLine(), out secondOperand))
				{
					// Прерывание бесконечного цикла while(true), в случае успешного ввода. 
					break;
				}

				Console.WriteLine("Wrong value");
			}

			// Бесконечный цикл не дает продолжить программу, пока пользователь не введет корректные данные. 
			var operation = default(char);
			while(true)
			{
				Console.Write("Enter the operation: ");

				var input = Console.ReadLine();

				// Здесь усложняется логика проверки входных данных. 
				// Для начала необходимо убедиться, что входная строка не null или не пустая. 
				// В противном случае, обращение к первому символу приведет к NullReferenceException или IndexOutOfRangeException. 

				if (!string.IsNullOrWhiteSpace(input))
				{
					// Внутренний цикл реализует проверку на принадлежность введенных данных и массива поддерживаемых операторов. 
					var isAllowed = false;
					for (var i = 0; i < operations.Length; i++)
					{
						// В случае совпадения, результат фиксируется во временную переменную isAllowed
						if (operations[i] == input[0])
						{
							isAllowed = true;
						}
					}

					// Которая в дальнейшем используется для выхода из основного цикла
					if (isAllowed)
					{
						break;
					}
				}

				Console.WriteLine("Wrong value");
			}

			// Как можно заметить, помещение всего кода программы в единтственный метод сильно усложняет логику и понимание работы программы. 
			// Чтобы как-либо упростить чтение кода, используют методы. 
			// Методы позволяют локализовать куски логики, тем самым, устранив дублирование кода и упростив программу. 

			var result = double.NaN;
			switch (operation)
			{
				case '+':
					result = firstOperand + secondOperand;
					break;
				case '-':
					result = firstOperand - secondOperand;
					break;
				case '*':
					result = firstOperand * secondOperand;
					break;
				case '/':
					result = firstOperand / secondOperand;
					break;
				case '%':
					result = firstOperand % secondOperand;
					break;
				case '^':
					result = Math.Pow(firstOperand, secondOperand);
					break;
				default:
					Console.WriteLine("Wrong value");
					break;
			}

			Console.Write($"\n{firstOperand} {operation} {secondOperand} = ");
			Console.WriteLine($"{result}");
		}
	}
}
