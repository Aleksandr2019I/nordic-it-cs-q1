using System;
/*
 Написать программу для добавления цветов
заданной палитры в “избранное”. // favorites
Программа выводит список цветов с их
порядковыми номерами и просит пользователя
в цикле выбрать 4 цвета для добавления их в
палитру “Избранное”.
Выбор производится путём введения
порядковых номеров этих цветов.
После завершения ввода программа выводит
список любимых цветов, а также отдельно
список нелюбимых цветов.
Самостоятельная работа: enum [Flags]
Список допустимых
цветов в палитре:
● Black
● Blue
● Cyan
● Grey
● Green
● Magenta
● Red
● White
● Yellow

                int num = (int)Colors.Black;
            var color = Colors.Black | Colors.Blue | Colors.Cyan | Colors.Green | Colors.Grey | Colors.Magenta | Colors.Red | Colors.White | Colors.Yellow;
            Console.WriteLine($"цвета {color}");
            Console.WriteLine($"{num}");
            Console.ReadKey();

     var color = typeof(Colors);
            Console.WriteLine("цвета и их соответствующие значения: ");

             foreach (string s in Enum.GetNames(color))
            Console.WriteLine("{0,-11}= {1}", s, Enum.Format(color, Enum.Parse(color, s), "d"));                
            Console.ReadKey();


     */

namespace HW1
{

    [Flags]
    enum Colors
    {
        // сдвиг делаем для того чтобы небыло пересечений 
        Blue = 0x1,
        Grey = 0x1 << 1,
        Green = 0x1 << 2,
        Magenta = 0x1 << 3,
        Red = 0x1 << 4,
        White = 0x1 << 5,
        Yellow = 0x1 << 6,
        Black = 0x1 << 7,
        Cyan = 0x1 << 8,
    }
    class Program
    {

        static void Main()
        {
            
            var values = Enum.GetValues(typeof(Colors));
           
            

            Type color = typeof(Colors);
            foreach (string s in Enum.GetNames(color))
                Console.WriteLine("{0, -11}= {1}", s, Enum.Format(color, Enum.Parse(color, s), "d"));

            Console.WriteLine("введите цвет числом"); // ввести номер цвета
            int[] favorites = new int[4];
            for (int i = 0; i < 4; i++)
            {

                while (true)
                {

                    if (int.TryParse(Console.ReadLine(), out var num))
                    {
                        favorites[i] = num;
                        break;
                    }
                    Console.WriteLine("Wrong Value!");
                }

            }

            Console.WriteLine($"{favorites}");

          /*
            


            Console.WriteLine("The values of the Colors Enum are:");
            foreach (int i in Enum.GetValues(typeof(Colors)))
                Console.WriteLine(i);



            Console.WriteLine();
            */

            Console.ReadKey();

        }





    }

}









