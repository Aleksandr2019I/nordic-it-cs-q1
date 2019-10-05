using System;

namespace test
{
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
            var fig = GetColors();
            Console.WriteLine($"{fig}");
            Console.ReadKey();
           
        }
        static Figures GetColors()
        {
            var result = Figures.None;
            var values = (Figures[])Enum.GetValues(typeof(Figures));

            for (var i = 0; i < values.Length; i++)
            {
                result = result | values[i];
            }

            return result;
        }



    }
}
