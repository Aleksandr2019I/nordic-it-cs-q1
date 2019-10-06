using System;

namespace test
{
    [Flags]
    enum Figures
    {

        Circle = 1,     // круг
        EquilateralTriangle = 2, // равносторонний треугольник equilateralTriangle
        Rectangle = 3 // прямоугольник rectangle
    }
    class Program
    {
        static void Main()
        {
            var color = typeof(Figures);
            Console.Write("цвета и их соответствующие значения: ");
            foreach (string s in Enum.GetNames(color))
                Console.Write("{0,2} = {1} ", s, Enum.Format(color, Enum.Parse(color, s), "d"));


            Console.ReadKey();
        }






    }
}
