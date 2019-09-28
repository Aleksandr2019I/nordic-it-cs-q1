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

        enum Colors  
    {
       // сдиваг делаем для того чтобы небыло пересечений 
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
                int num = (int)Colors.Black;
            var color = Colors.Black | Colors.Blue | Colors.Cyan | Colors.Green | Colors.Grey | Colors.Magenta | Colors.Red | Colors.White | Colors.Yellow;
            Console.WriteLine($"цвета {color}");
            Console.WriteLine($"{num}");
            Console.ReadKey();
     */

namespace HW1
{
    [Flags]
    enum Colors 
    {
        
        Blue = 0 ,
        Grey = 1,
        Green  = 2,
        Magenta = 3,
        Red = 4,
        White = 5,
        Yellow = 6,
        Black = 7,
        Cyan = 10,
    }

    class Program
    {
        static void Main(string[] args)
        {
            
             Console.WriteLine($"выбирите цвета и введите равное им значение {Colors.Black} = {(int)Colors.Black},{Colors.Blue} = {(int)Colors.Blue}," +
                 $"{Colors.Grey} = {(int)Colors.Grey},{Colors.Green} = {(int)Colors.Green}," +
                 $"{Colors.Magenta} = {(int)Colors.Magenta},{Colors.Red} = {(int)Colors.Red},{Colors.White} = {(int)Colors.White}," +
                 $"{Colors.Yellow} = {(int)Colors.Yellow},{Colors.Cyan} = {(int)Colors.Cyan},");
           
            

            for (int i = 0; i < 4; i++)
            {               
                var operation = int.Parse(Console.ReadLine());
            if (operation == 0)
            {
                Console.WriteLine($"Вы выбрали {Colors.Blue}") ;
            }
            if (operation == 1)
            {
                Console.WriteLine($"Вы выбрали {Colors.Grey}");
            }
            if (operation == 2)
            {
                Console.WriteLine($"Вы выбрали {Colors.Green}");
            }
            if (operation == 3)
            {
                Console.WriteLine($"Вы выбрали {Colors.Magenta}");
            }
            if (operation == 4)
            {
                Console.WriteLine($"Вы выбрали {Colors.Red}");
            }
            if (operation == 5)
            {
                Console.WriteLine($"Вы выбрали {Colors.White}");
            }
            if (operation == 6)
            {
                Console.WriteLine($"Вы выбрали {Colors.Yellow}");
            }
            if (operation == 7)
            {
                Console.WriteLine($"Вы выбрали {Colors.Black}");
            }
            if (operation == 10)
            {
                Console.WriteLine($"Вы выбрали {Colors.Cyan}");
            }
            }
            Console.ReadKey();

        }
    }
}
