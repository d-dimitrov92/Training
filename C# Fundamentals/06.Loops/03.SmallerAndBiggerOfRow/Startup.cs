using System;

namespace _03.SmallerAndBiggerOfRow
{
    class Startup
    {
        static void Main()
        {
            int lowest = 0, highest = 0, temp;

            Console.Write("Enter row length: ");
            int lenght = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter number: ");
                temp = Int32.Parse(Console.ReadLine());

                if (i == 0)
                {
                    lowest = highest = temp;
                }

                else
                {
                    if (lowest > temp)
                    {
                         lowest = temp;
                    }

                    if (highest < temp)
                    {
                         highest = temp;
                    }
                }
            }
            Console.WriteLine("\nLowest - {0}\nHighest - {1}\n", lowest, highest);
        }
    }
}
