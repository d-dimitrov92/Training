using System;

namespace _06.Factoriel
{
    class Startup
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            int nFact = 1;
            int kFact = 1;

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

                Console.WriteLine("\nResult = " + (nFact / kFact) + "\n");
            }

            else
            {
                Console.WriteLine("\nError!\n\n");
            }
        }
    }
}
