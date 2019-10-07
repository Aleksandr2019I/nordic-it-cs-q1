using System;

namespace CW6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new[]
            {
                new [] { 2,3,3,2,3},
                new [] {2,4,5,3},
                null,
                new [] {5,5,5,5},
                new [] {4},
            };

            double sumNed = 0.0;
            for (var i = 0; i < marks.Length; i++)

            {

                if (marks[i] == null)
                {
                    Console.WriteLine($"The average mark for day #{i}, is N/A");
                    continue;
                }
                double bal = 0;

                for (var j = 0; j < marks[i].Length; j++)

                {
                    bal += marks[i][j];
                }

                double sum = bal / marks[i].Length;
                Console.WriteLine("The average mark for day #{0}, is {1:0.0}",i,sum);

                sumNed = sum / marks[i].Length;

            }
            Console.WriteLine("The average mark for all the week is {0:0.0}",sumNed);

            Console.ReadKey();
        }
    }
}
