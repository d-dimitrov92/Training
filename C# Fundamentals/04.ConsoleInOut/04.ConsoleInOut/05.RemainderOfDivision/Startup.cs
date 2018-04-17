using System;

namespace _05.RemainderOfDivision
{
    class Startup
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = first; i <= second; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("In interval of ({0}, {1}) --> {2} numbers are multiples of 5!",first, second, counter);
        }
    }
}


    //Напишете програма, която чете от конзолата две цели числа(int) и отпечатва колко числа има между тях, 
    //такива, че остатъкът им от деленето на 5 да е 0. Пример: в интервала(17, 25) има 2 такива числа.