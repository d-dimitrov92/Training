using System;

namespace _11.From1ToN
{
    class Startup
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            while (num < n)
            {
                num++;
                Console.WriteLine(num);
            }
        }
    }
}
