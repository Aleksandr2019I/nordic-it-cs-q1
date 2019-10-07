using System;

namespace HW5


{


    /*  Написать консольное приложение, которое спросит у пользователя тип
   фигуры(1 - круг, 2 - равносторонний треугольник, 3 - прямоугольник), затем
   спросит параметры фигуры:
   1. для круга - диаметр
   2. для треугольника - длину стороны
   3. для прямоугольника - ширину и высоту
   В качестве результата программа должна вывести площадь поверхности и
   длину периметра соответствующей фигуры.
   Тип фигур должен быть объявлен в виде перечисления.
   Необходимо обработать все предсказуемые исключения
    
        треугольник 


   */
    [Flags]
    enum Figures
    {
        None = 0,
        Circle = 1,     // круг
        EquilateralTriangle = 2, // равносторонний треугольник equilateralTriangle
        Rectangle = 3 // прямоугольник rectangle
    }
    class Program
    {
        static void Main()
        {

            Console.WriteLine($"Выбрите тип фигуры ({(int)Figures.Circle} - {Figures.Circle}," +
                $"{(int)Figures.EquilateralTriangle} - {Figures.EquilateralTriangle}," +
                $"{(int)Figures.Rectangle} - {Figures.Rectangle})");

            int input = ReadTypeFigures();

            try
            {
                switch (input)

                {

                    case (int)Figures.Circle:
                        Console.WriteLine("Вы выбрали круг, введите его диаметр");
                        double diameter = ReadParametersCircle();
                        break;
                    case (int)Figures.EquilateralTriangle:
                        Console.WriteLine("Вы выбрали треугольник, введите длину строны");
                        double sideLength = ReadParametersTriangle();
                        break;
                    case (int)Figures.Rectangle:
                        Console.WriteLine("Вы выбрали прямоугольник");
                        double heightRectanle = ReadParametersRectangle();
                        break;
                    default:
                        Console.WriteLine("введено невереное значение");
                        break;
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
        static int ReadTypeFigures()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите номер фигуры от 1 до 3");
                    var input = int.Parse(Console.ReadLine());
                    if (input == 1 || input == 2 || input == 3)
                    {
                        return input;
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static double ReadParametersCircle()
        {

            while (true)
            {
                try
                {
                    double diameter = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{diameter}");
                    var radius = diameter / 2; // радиус
                    var areaCircle = Math.PI * Math.Pow(radius, 2); // Площадь поверхности круга
                    var circleLength = 2 * Math.PI * radius; // Длина периметра круга
                    Console.WriteLine($"Площадь поверхности: {areaCircle} ");
                    Console.WriteLine($"Длина периметра: {circleLength} ");
                    return diameter;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static double ReadParametersTriangle()
        {

            while (true)
            {
                try
                {
                    double sideLength = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{sideLength}");
                    var triangleLength = 3 * sideLength; // длина периметра равн.треугольника
                    var areaTriangle = (Math.Sqrt(3) / 4) * Math.Pow(sideLength, 2); // Площадь поверхности равн.треугольника
                    Console.WriteLine($"Площадь поверхности: {areaTriangle} ");
                    Console.WriteLine($"Длина периметра: {triangleLength} ");
                    return sideLength;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static double ReadParametersRectangle()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("введите высоту");
                    var heightRectanle = ParametersRectangle();
                    Console.WriteLine("введите ширину");
                    var widthRectangle = ParametersRectangle();
                    var areaRectanle = heightRectanle * widthRectangle; // площадь прямоугольника
                    var rectanleLength = 2 * (heightRectanle + widthRectangle); // длина прямоугольника
                    Console.WriteLine($"Площадь поверхности: {areaRectanle} ");
                    Console.WriteLine($"Длина периметра: {rectanleLength} ");
                    return heightRectanle;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static double ParametersRectangle()
        {
            while (true)
            {
                double valueRectangle = double.Parse(Console.ReadLine()); // высота прямоугольник
                Console.WriteLine($" число {valueRectangle}");
                return valueRectangle;
            }

        }


    }
}
