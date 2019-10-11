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

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = " lorem ipsum dolor sit amet ";
            StringBuilder sb = new StringBuilder(text);

            sb
               .Replace("ipsum", "IPSUM")
               .Remove(21,5)
               .Remove(0,1);
                

            Console.WriteLine($"{sb}");

            Console.ReadKey();
            
        }
    }
}
