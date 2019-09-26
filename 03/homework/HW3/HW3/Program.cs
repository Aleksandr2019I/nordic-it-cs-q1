using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW3
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("enter the names of three people"); // введите имена трех человек          
            List<string> names = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string name = Convert.ToString(Console.ReadLine());
                names.Add(name);            
                
            }

            Console.WriteLine("enter their age"); // введите их возраст
            List<string> ages = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string age = Convert.ToString(Console.ReadLine());
                ages.Add(age);

            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Name:{names[i]}, age in 4 years :{ages[i]}");
            }

           
            Console.ReadKey();


        }

    }
}
