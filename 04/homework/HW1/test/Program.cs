using System;

public class EnumTest
{
    enum Days { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };
    enum BoilingPoints { Celsius = 100, Fahrenheit = 212 };
    [FlagsAttribute]
    enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

    public static void Main()
    {

        Type weekdays = typeof(Days);
        Type boiling = typeof(BoilingPoints);

        Console.WriteLine("Дни недели и их соответствующие значения в перечислении дней: ");

        foreach (string s in Enum.GetNames(weekdays))
            Console.WriteLine("{0,-11}= {1}", s, Enum.Format(weekdays, Enum.Parse(weekdays, s), "d"));

        Console.WriteLine();
        Console.WriteLine("Также могут быть созданы перечисления, значения которых представляют некоторую значимую сумму.");
        Console.WriteLine("Перечисление BoilingPoints определяет следующие элементы и соответствующие значения:");

        foreach (string s in Enum.GetNames(boiling))
            Console.WriteLine("{0,-11}= {1}", s, Enum.Format(boiling, Enum.Parse(boiling, s), "d"));

        Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
        Console.WriteLine();
        Console.WriteLine("myColors содержит комбинацию цветов. А именно: {0}", myColors);
        Console.ReadKey();
    }
}