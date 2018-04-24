using System;

namespace _05.SumOfFibonacciNumbers
{
    class Startup
    {
        static void Main()
        {
            int firstNum = 0, secondNum = 1;
            int thirdNum = 1;
            int sum = 0;

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                sum += secondNum;

                if (i == n - 1)
                {
                    Console.Write(secondNum);
                    break;
                }

                Console.Write(secondNum + " + ");
                
            }
            Console.WriteLine(" = " + sum + "\n");
        }
    }
}