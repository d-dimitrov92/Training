using System;

namespace _06.Factorial
{
    class Startup
    {
        static void Main()
        {
            decimal nFact = 1;
            decimal kFact = 1;

            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K = ");
            int k = int.Parse(Console.ReadLine());

            if (1 < k && k < n)
            {
                do
                {
                    nFact *= n;
                    n--;
                }
                while (n > 0);

                do
                {
                    kFact *= k;
                    k--;
                }
                while (k > 0);

                Console.WriteLine(nFact / kFact);
            }
            else
            {
                Console.WriteLine(" 1 < K < N ");
            }
        }
    }
}