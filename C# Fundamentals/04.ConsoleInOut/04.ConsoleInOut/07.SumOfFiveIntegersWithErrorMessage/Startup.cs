using System;

namespace _07.SumOfFiveIntegersWithErrorMessage
{
    class Startup
    {
        static void Main()
        {
            int a,b,c,d,e;
            bool parseSucceed = false;
            
            //for (int i = 1; i <= 5; i++)
            //{
                //int a;

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
            //}

            Console.WriteLine("Sum of numbers is: " + (a + b + c + d + e) + " .\n");
        }
    }
}