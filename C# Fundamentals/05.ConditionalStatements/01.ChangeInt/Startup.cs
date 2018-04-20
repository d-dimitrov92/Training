using System;

namespace _01.ChangeInt
{
    class Startup
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                second = first;
                Console.WriteLine("First is bigger ! ---> " + second);
            }

            else if (first < second)
            {
                Console.WriteLine("Second is bigger!---> " + first);
            }

            else
            {
                Console.WriteLine("Equals!");
            }
        }
    }
}
