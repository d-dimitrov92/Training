using System;

namespace _12.FibonacciSequence
{
    class Startup
    {
        static void Main()
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            int count = 0;

            Console.Write(num1 + ", ");

            while (count < 100)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.Write(num2 + ", ");
                count++;
            }
            Console.WriteLine("\n");
        }
    }
}
