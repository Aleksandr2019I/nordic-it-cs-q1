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
        none = 0,
        circle = 1,     // круг
        equilateralTriangle = 2, // равносторонний треугольник
        rectangle = 3 // прямоугольник
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Выбрите тип фигуры ({(int)Figures.circle} - {Figures.circle}," + 
                $"{(int)Figures.equilateralTriangle} - {Figures.equilateralTriangle}," +
                $"{(int)Figures.rectangle} - {Figures.rectangle})");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case (int)Figures.circle:
                    Console.WriteLine("Вы выбрали круг, введите его диаметр");
                    double diameter = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{diameter}");
                    var radius = diameter / 2; // радиус
                    var areaCircle = Math.PI * Math.Pow(radius, 2); // Площадь поверхности круга
                    var circleLength = 2 * Math.PI * radius; // Длина периметра круга
                    Console.WriteLine($"Площадь поверхности: {areaCircle} ");
                    Console.WriteLine($"Длина периметра: {circleLength} ");
                    break;
                case (int)Figures.equilateralTriangle:
                    Console.WriteLine("Вы выбрали треугольник, введите длину строны");
                    double sideLength = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{sideLength}");
                    var triangleLength = 3 * sideLength; // длина периметра равн.треугольника
                    var areaTriangle = (Math.Sqrt(3) / 4) * Math.Pow(sideLength,2); // Площадь поверхности равн.треугольника
                    Console.WriteLine($"Площадь поверхности: {areaTriangle} ");
                    Console.WriteLine($"Длина периметра: {triangleLength} ");                   
                    break;
                case (int)Figures.rectangle:
                    Console.WriteLine("Вы выбрали прямоугольник, введите высоту");
                    double heightRectanle = double.Parse(Console.ReadLine()); // высота прямоугольник
                    Console.WriteLine($" высота {heightRectanle}"); 
                    Console.WriteLine("введите ширину");
                    double widthRectangle = double.Parse(Console.ReadLine()); // ширина прямоугольник
                    Console.WriteLine($" ширина {widthRectangle}");
                    var areaRectanle = heightRectanle * widthRectangle; // площадь прямоугольника
                    var rectanleLength = 2 * (heightRectanle + widthRectangle); // длина прямоугольника
                    Console.WriteLine($"Площадь поверхности: {areaRectanle} ");
                    Console.WriteLine($"Длина периметра: {rectanleLength} ");
                    break;
            }

            Console.ReadKey();
        }


       




    }
}
