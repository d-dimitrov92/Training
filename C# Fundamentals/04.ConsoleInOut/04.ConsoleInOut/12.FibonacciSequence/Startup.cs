﻿using System;

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

            Console.WriteLine(num1);

            while (count < 100)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(num2);
                count++;
            }
        }
    }
}
