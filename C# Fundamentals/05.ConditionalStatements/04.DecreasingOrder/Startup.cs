using System;

namespace _04.DecreasingOrder
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
                if (b > c)
                {
                    Console.WriteLine("Decreasing order: {0} - {1} - {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("Decreasing order: {0} - {1} - {2}", a,  c, b);
                }
            }

            if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Decreasing order: {0} - {1} - {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("Decreasing order: {0} - {1} - {2}", b, c, a);
                }
            }

            if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("Decreasing order: {0} - {1} - {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("Decreasing order: {0} - {1} - {2}", c, b, a);
                }
            }
        }
    }
}
