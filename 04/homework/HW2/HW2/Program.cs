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
        enum ContainerSign
        {
            none = 0x0,
            liter1 = 0x1 <<1,
            liter5 = 0x1 <<2,
            liter20 = 0x1 <<3,

        };

        enum ContainerVolume
        { 
        
            volume1 = 1,
            volume5 = 5,
            volume20 = 20,
        };


        static void Main()
        {
            var numberOfLiters = ReadDouble();

            ContainerSign valueContainer = ContainerSign.none;

                       var countContainer20 = numberOfLiters / (int)ContainerVolume.volume20;
                       
                       if (countContainer20 > 0)
                        {
                            numberOfLiters %= (int)ContainerVolume.volume20;
                           valueContainer |= ContainerSign.liter20;

                        }
            
   
            var countContainer5 = countContainer20 / (int)ContainerVolume.volume5;
                        if (countContainer5 > 0)
                        {
                countContainer20 %= (int)ContainerVolume.volume5;
                            valueContainer |= ContainerSign.liter5;

                        }
                       var countContainer1 = countContainer5 / (int)ContainerVolume.volume1;
                        if (countContainer1 > 0)
                        {
                         countContainer5 %= (int)ContainerVolume.volume1;
                            valueContainer |= ContainerSign.liter1;

                        }

            Console.WriteLine($"20 л: {countContainer20}шт");
            Console.WriteLine($"5 л: {countContainer5} шт");
          Console.WriteLine($"1 л: {countContainer1} шт");

            // в битах которой будет лежать признак наличия контейнера того или иного этого типа(0001 - 1л, 0010 - 5л, 0100 - 20л).
            // При выводе,

            //если бит, отвечающий за наличие хотя бы одного контейнера данного типа, равен 0,
            /*
                                    if ((valueContainer | Container.liter1)  == 1)
                                    {
                                        Console.WriteLine($"1 Л: {z} шт");
                                    }
                                    if ((valueContainer | Container.liter5)== 1)
                                    {
                                        Console.WriteLine($"5 Л: {y} шт");
                                    }
                                    if ((valueContainer | Container.liter20) == 1)
                                    {
                                        Console.WriteLine($"20 Л: {x} шт");
                                    }
                                    //строку с данными по этому контейнеру не выводить.

             
            Console.WriteLine($"20 л: {countContainer20} шт");
            Console.WriteLine($"5 Л: {countContainer5} шт");        
           Console.WriteLine($"1 Л: {countContainer1} шт");
            */


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
 