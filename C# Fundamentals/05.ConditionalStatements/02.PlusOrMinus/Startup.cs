using System;

namespace _02.PlusOrMinus
{
    class Startup
    {
        private static void Main()
        {
            Console.Write("Enter an integer: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter another integer: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Enter another integer: ");
            int third = int.Parse(Console.ReadLine());

            if (first < 0 || second < 0 || third < 0)
            {
                if (first == 0 || second == 0 || third == 0)
                {
                    Console.WriteLine("Zero!");
                }

                else
                {
                    Console.WriteLine("Negative result!");
                }
            }
            
            else
            {
                Console.WriteLine("Positive result!");
            }
        }
    }
}