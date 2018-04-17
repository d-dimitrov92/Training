using System;

namespace _06.CompareWithoutIf
{
    class Startup
    {
        static void Main()
        {
            Console.Write("a = ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("{0} is greater!\n\n", Math.Max(first, second));
        }
    }
}