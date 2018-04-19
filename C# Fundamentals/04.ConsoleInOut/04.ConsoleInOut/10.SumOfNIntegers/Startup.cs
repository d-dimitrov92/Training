using System;

namespace _10.SumOfNIntegers
{
    class Startup
    {
        static void Main()
        {
            int num;
            int sum = 0;
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} more integers: ", n);

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
