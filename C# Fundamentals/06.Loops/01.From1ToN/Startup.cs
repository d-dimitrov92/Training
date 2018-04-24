using System;

namespace _01.From1ToN
{
    class Startup
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            while (count <= n)
            {
                Console.Write(count + ", ");
                count++;
            }
        }
    }
}
