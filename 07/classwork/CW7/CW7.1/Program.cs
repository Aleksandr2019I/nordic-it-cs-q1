using System;
using System.Text;

/*
 Дана строка с “грязными” пробелами, например:
string text = " lorem ipsum dolor sit amet ";
Необходимо произвести над ней следующие операции:
1. “Очистить” исходную строку от лишних пробелов в начале, в конце
строки, а также между словами, а также поднять регистр второго слова:
○ “ lorem ipsum dolor sit amet ” → “lorem IPSUM dolor sit amet”
2. Удалить из исходной строки последнее слово и пробелы перед ним:
○ “ lorem ipsum dolor sit amet ” → “ lorem ipsum dolor sit”
Результаты по каждому пункту вывести отдельной строкой. Пример:
lorem IPSUM dolor sit amet
lorem ipsum dolor sit
     */
namespace CW7._1
{
	class Program
	{
		static void Main(string[] args)
		{
            string text = " lorem ipsum dolor sit amet ";
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            words[1] = words[1].ToUpperInvariant(); // uppercase for the second word

            Console.WriteLine(string.Join(' ', words)); // join words using single space char

            var x = text.Substring(0,22); // узнать в классе
            Console.WriteLine($"{x}");

            string textClean = text.TrimEnd(); // remove the spaces at the end of the line
            int lastSpaceIndex = textClean.LastIndexOf(' '); // looking for the position of the last space char
            textClean = textClean.Substring(0, lastSpaceIndex); // cutting string from 0 to lastSpaceIndex
            textClean = textClean.TrimEnd(); // clean up the tail А зачем тут еще раз?
            Console.WriteLine(textClean); // this is it :)          

            Console.ReadKey();
		}      


	}
}
