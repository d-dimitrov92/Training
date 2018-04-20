using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GreaterOfThreeNumbers
{
    class Startup
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers.");
            Console.Write("First number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("First number is biggest!");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Second number is biggest!");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Third number is biggest!");
            }
        }
    }
}