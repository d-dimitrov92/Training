using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.FractionalAccuracy
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int integer = Int32.Parse(Console.ReadLine());
            double sum = 1.0;

            for (int i = 2; i <= integer; i++)
            {
                sum += (1.0 / i);
            }

            Console.WriteLine("{0:F3}", sum);
        }
    }
}
