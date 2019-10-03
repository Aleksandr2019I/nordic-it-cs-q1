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
			liter1 = 0x1 << 1,
			liter5 = 0x1 << 2,
			liter20 = 0x1 << 3,

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

			var countContainer20 = Math.Floor (numberOfLiters / (int)ContainerVolume.volume20);

			if (countContainer20 > 0)
			{
				numberOfLiters %= (int)ContainerVolume.volume20; //numberOfLiters ненужное присваивание значения
				valueContainer |= ContainerSign.liter20;

			}

			var countContainer5 = Math.Floor (numberOfLiters / (int)ContainerVolume.volume5);
			if (countContainer5 > 0)
			{
				numberOfLiters %= (int)ContainerVolume.volume5;
				valueContainer |= ContainerSign.liter5;

			}
			var countContainer1 = Math.Ceiling (numberOfLiters / (int)ContainerVolume.volume1);
			if (countContainer1 > 0)
			{
				numberOfLiters %= (int)ContainerVolume.volume1;
				valueContainer |= ContainerSign.liter1; //valueContainer ненужное присваивание значения

			}

	

			// в битах которой будет лежать признак наличия контейнера того или иного этого типа(0001 - 1л, 0010 - 5л, 0100 - 20л).
			// При выводе,

			//если бит, отвечающий за наличие хотя бы одного контейнера данного типа, равен 0,

			// 0000
			// 0001
			// 0010
			// 0011
			// 0100
			// 0101
			// 0110
			// 0111

			// 0001
			if ((valueContainer & ContainerSign.liter1) == ContainerSign.liter1) //
			{
				Console.WriteLine($"1 л: {countContainer1} шт");
			}
			if ((valueContainer & ContainerSign.liter5) == ContainerSign.liter5)
			{
				Console.WriteLine($"5 л: {countContainer5} шт");
			}
			if ((valueContainer & ContainerSign.liter20) == ContainerSign.liter20)
			{
				Console.WriteLine($"20 л: {countContainer20}шт");
			}
			//строку с данными по этому контейнеру не выводить.




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
