using System;

namespace _02.From1ToNVer2
{
    class Startup
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
