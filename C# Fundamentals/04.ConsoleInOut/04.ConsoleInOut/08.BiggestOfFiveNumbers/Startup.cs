using System;

namespace _08.BiggestOfFiveNumbers
{
    class Startup
    {
        static void Main()
        {
            int a,b,c,d,e;
            bool parseSucceed = false;
            do
            {
                Console.Write("Enter first number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out a);
                if (parseSucceed == false)
                {
                    Console.WriteLine("Enter an integer!");
                }
            }
            while (!parseSucceed);

            do
            {
                Console.Write("Enter second number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
                if (parseSucceed == false)
                {
                    Console.WriteLine("Enter an integer!");
                }
            }
            while (!parseSucceed);

            do
            {
                Console.Write("Enter third number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
                if (parseSucceed == false)
                {
                    Console.WriteLine("Enter an integer!");
                }
            }
            while (!parseSucceed);

            do
            {
                Console.Write("Enter fourth number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
                if (parseSucceed == false)
                {
                    Console.WriteLine("Enter an integer!");
                }
            }
            while (!parseSucceed);

            do
            {
                Console.Write("Enter fifth number: ");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
                if (parseSucceed == false)
                {
                    Console.WriteLine("Enter an integer!");
                }
            }
            while (!parseSucceed);

            if (a > b && a > c && a > d && a > e) Console.WriteLine("Biggest is a!");
            else if (b > a && b > c && b > d && b > e) Console.WriteLine("Biggest is b!");
            else if (c > a && c > b && c > d && c > e) Console.WriteLine("Biggest is c!");
            else if (d > a && d > b && d > c && d > e) Console.WriteLine("Biggest is d!");
            else if (e > a && e > b && e > c && e > d) Console.WriteLine("Biggest is e!");

        }
    }
}
