using System;

namespace _03.ForestRoad
{
    class Program
    {
        static void Main()
        {

            byte n = byte.Parse(Console.ReadLine());
            for (int path = 0; path < n; path++)
            {
                Console.Write(new string('.', path));
                Console.Write('*');
                Console.Write(new string('.', (n - 1) - path));
                Console.WriteLine();
            }
            for (int path = n - 1; path > 0; path--)
            {
                Console.Write(new string('.', path - 1));
                Console.Write('*');
                Console.Write(new string('.', n - path));
                Console.WriteLine();
            }
        }
    }
}