using System;
using System.Text;

namespace HW7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку из нескольких слов:");

			var word = Readtext();

			int j = default(int);
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i].ToLowerInvariant().StartsWith('a') | word[i].ToLowerInvariant().StartsWith('а'))
				{
					j++;
				}
			}
			Console.WriteLine($"Количество слов, начинающихся с буквы 'А':{j}");
			Console.WriteLine("Нажмите любую клавишу для выхода...");
			Console.ReadKey();
		}
		static string[] Readtext()
		{
			while (true)
			{
				
					string input = Console.ReadLine();
					string[] massiv = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
					if (massiv.Length < 2 |)
					{
						Console.WriteLine("Слишком мало слов :( Попробуйте ещё раз:");
					}
					return massiv;
				
		
			}
		}
	}
}
