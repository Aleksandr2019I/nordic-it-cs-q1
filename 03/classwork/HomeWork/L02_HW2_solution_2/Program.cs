using System;

namespace L02_HW2_solution_2
{
	// Вариант домашнего задания посложнее, с проверкой входных данных и применением методов.
	// Как можно заметить, код программы довольно сильно увеличился. 
	// Однако, можно заметить, что сам основной метод Main стал сильно короче. 
	// И беглый взгляд на него позволяет понять, что программа делает в общих чертах: 
	// * выводит какой-то заголовок
	// * запрашивает у пользователя операнды
	// * запрашивает у пользователя операцию
	// * выполняет вычисления
	// * выводит результат
	// Конкретные детали реализации различных частей программы локализованы в дополнительных методах. 

	internal class Program
	{
		static void Main()
		{
			var operators = new [] { '+', '-', '*', '/', '%', '^' };

			WriteTitle(operators);

			var firstOperand = ReadOperand("1st");
			var secondOperand = ReadOperand("2nd");
			var @operator = ReadOperator(operators);
			var result = Calculate(firstOperand, secondOperand, @operator);

			WriteResult(firstOperand, secondOperand, @operator, result);
            Console.ReadKey();

		}

		/// <summary>
		/// Вспомогательный метод, реализующий логику чтения операнда из консоли. 
		/// Метод в качетсве парамера принимает название операнда, чтобы отобразить корректный заголовок. 
		/// </summary>
		static double ReadOperand(string operandDescription)
		{
			// Бесконечный цикл не дает продолжить программу, пока пользователь не введет корректные данные. 
			while (true)
			{
				Console.Write($"Enter the {operandDescription} operand: ");

				// Метод TryParse возаращает результат выполнения операции, который используется в условии
				// На текущий момент, не стоит вдаваться в подробности реализации ключевого слова out. 
				// Достаточно знать, что оно позволяет связать результат выполнения операции с аргументом. 
				// Нововведения в последних версиях C# полволяют объявлять переменные, передаваемые с out модификатором в месте вызова функции. 

				if (double.TryParse(Console.ReadLine(), out var operand))
				{
					// Здесь даже не требуется операция прерывания цикла break;
					// Т.к. в слуае успешного преобразования операнда к типу double можно просто вернуть результат. 
					// Тем самым, будет прерван как и цикл, так и выполнения кода метода, и программа продолжит свое выполнение. 
					return operand;
				}

				WriteWithColor("Wrong value! ", ConsoleColor.Red);
			}
		}

		/// <summary>
		/// Вспомогательный метод, реализующий логику чтения операции из консоли. 
		/// </summary>
		static char ReadOperator(char[] operators)
		{
			while (true)
			{
				Console.Write("Enter the operator : ");
				var input = Console.ReadLine();

				if (IsOperationAllowed(operators, input))
				{
					// Здесь даже не требуется операция прерывания цикла break;
					// Т.к. в слуае успешного совпадения операнда можно просто вернуть текущий операнд. 
					// Тем самым, будет прерван как и цикл, так и выполнения кода метода, и программа продолжит свое выполнение. 

					return input[0];
				}

				WriteWithColor("Wrong value! ", ConsoleColor.Red);
			}
		}

		/// <summary>
		/// Вспомогательный метод, реализующий логику проверки операции со списком допустимых операций. 
		/// Возвращает значение типа bool с результатом проверки. 
		/// </summary>
		static bool IsOperationAllowed(char[] operators, string input)
		{
			if (string.IsNullOrWhiteSpace(input))
			{
				return false;
			}

			// Цикл позволяет перебрать все значения массива 
			for (var i = 0; i < operators.Length; i++)
			{
				// Сранение элемента массива под индексом i с введеной ранее строкой. 
				// Используется первый сивол строки, т.к. тип операций char. 

				if (operators[i] == input[0])
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Основной метод, реализующий логику вычисления операции.
		/// Принимает параметрами операнды и тип операции. 
		/// Возвращает результат выполнения операции. 
		/// </summary>
		static double Calculate(
			double first, 
			double second, 
			char @operator)
		{
			switch (@operator)
			{
				case '+':
					return first + second;
				case '-':
					return first - second;
				case '*':
					return first * second;
				case '/':
					return first / second;
				case '%':
					return first % second;
				default:
					return Math.Pow(first, second);
			}
		}

		/// <summary>
		/// Метод выводит заголовок программы и краткую вспомогательную информацию. 
		/// </summary>
		static void WriteTitle(char[] operators)
		{
			WriteWithColor("Calculator\n", ConsoleColor.Green);
			Console.WriteLine($"  Use operands range: {double.MinValue}–{double.MaxValue}");
			Console.WriteLine($"  Use one of the following operators: {string.Join(" ", operators)}");
			Console.WriteLine();
		}

		/// <summary>
		/// Метод выводит результат выполнения операции и само выражение. 
		/// </summary>
		static void WriteResult(
			double first, 
			double second, 
			char @operator, 
			double result)
		{
			Console.Write($"\n{first} {@operator} {second} = ");
			WriteWithColor($"{result}\n", ConsoleColor.Green);
		}

		/// <summary>
		/// Вспомогательный метод, позволяет написать какую либо информацию на консоль, дополнительно, указав цвет текста. 
		/// </summary>
		static void WriteWithColor(string text, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.Write(text);
			Console.ForegroundColor = restoreColor;
		}
        
	}
}
