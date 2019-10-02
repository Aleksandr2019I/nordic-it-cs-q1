using System;

namespace HW2
{

    /*
     Написать консольное приложение, которое будет спрашивать, “Какой объем
сока (в литрах) требуется упаковать?”.
Затем оно будет рассчитывать и выдавать в качестве ответа необходимое
количество контейнеров каждого типа.
В нашей модели будет 3 типа контейнеров: 1 литр, 5 литров, 20 литров.
Типы контейнеров должны быть определены в перечислении
(представленным битовыми флагами).
Кроме количества контейнеров необходимо посчитать значение
переменной типа Int32, в битах которой будет лежать признак наличия
контейнера того или иного этого типа (0001 - 1л, 0010 - 5л, 0100 - 20л) .
При выводе, если бит, отвечающий за наличие хотя бы одного контейнера
данного типа, равен 0, строку с данными по этому контейнеру не выводить.
         */
    class Program
    {
        [Flags]
        enum Container : byte
        {
            none = 0x0,
            liter1 = 0x1 <<1,
            liter5 = 0x1 <<2,
            liter20 = 0x1 <<3,

        };


        static void Main()
        {
            var num = ReadDouble();
            if (num >= 0)
            {
                var value = Math.DivRem((int)num, 20, out var balance);
                Console.WriteLine($"20 л: {value} шт");
                if (value >= 0)
                {
                    var value1 = Math.DivRem(balance, 5, out var balance1);
                    Console.WriteLine($"5 л: {value1} шт");

                    if (value1 >= 0)
                    {
                        var value2 = Math.DivRem(balance1, 1, out var balance2);
                        Console.WriteLine($"1 л: {value2} шт");
                    }
                    
                }

               
                
                
            }
            
            
            
        


            Console.ReadKey();
        }
        static double ReadDouble()
        {
            while (true)
            {
                Console.Write("Какой объем сока (в литрах) требуется упаковать? ");
                if (double.TryParse(Console.ReadLine(), out var input)) //проверка на число
                {
                    Console.WriteLine($"Ваше число {input}");
                    Console.WriteLine($"Вам потребуются следующие контейнеры:");
                    return input;
                    
                }
                Console.WriteLine("Wrong value");
            }
            
        }




    }
}
 