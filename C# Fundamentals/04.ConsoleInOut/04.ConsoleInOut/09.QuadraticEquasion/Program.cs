using System;

namespace _09.QuadraticEquasion
{
    class Program
    {
        static void Main()
        {
            double a;
            bool parseSucceed = false;
            do
            {
                Console.Write("Enter A=");
                parseSucceed = double.TryParse(Console.ReadLine(), out a);
                if (a == 0)
                {
                    Console.WriteLine("Only numbers and not 0!!!");
                }
            }
            while (a == 0);

            Console.Write("Enter B=");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter C=");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
            else if (d == 0)
            {
                double x = - b / 2 * a;
                Console.WriteLine("Only one root: x= " + x);
            }

            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;

                Console.WriteLine("Two roots: x1= {0} and x2= {1} .", x1, x2);
            }
        }
    }
}
