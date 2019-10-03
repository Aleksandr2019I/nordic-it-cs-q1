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
        enum Container 
        {
            none = 0x0,
            liter1 = 0x1 <<1,
            liter5 = 0x1 <<2,
            liter20 = 0x1 <<3,

        };


        static void Main()
        {
            var num = ReadDouble();

            Container flag = Container.none;

                       var x = num / (int)Container.liter20;
                       if (x > 0)
                        {
                           num %= (int)Container.liter20;
                           flag |= Container.liter20;

                        }
            Console.WriteLine($"20 л: {x} шт");
            
            var y = x / (int)Container.liter5;
                        if (y > 0)
                        {
                            x %= (int)Container.liter5;
                            flag |= Container.liter5;

                        }
                       var z = y / (int)Container.liter1;
                        if (z > 0)
                        {
                            y %= (int)Container.liter1;
                            flag |= Container.liter1;

                        }

                        // в битах которой будет лежать признак наличия контейнера того или иного этого типа(0001 - 1л, 0010 - 5л, 0100 - 20л).
                        // При выводе,

                        //если бит, отвечающий за наличие хотя бы одного контейнера данного типа, равен 0,
/*
                        if (flag | Container.liter1  == 0)
                        {
                            Console.WriteLine($"1 Л: {z} шт");
                        }
                        if (flag | Container.liter5 == 0)
                        {
                            Console.WriteLine($"5 Л: {y} шт");
                        }
                        if (flag | Container.liter20 == 0)
                        {
                            Console.WriteLine($"20 Л: {x} шт");
                        }
                        //строку с данными по этому контейнеру не выводить.

  */          
            Console.WriteLine($"20 л: {x} шт");
            Console.WriteLine($"5 Л: {y} шт");        
           Console.WriteLine($"1 Л: {z} шт");



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
 