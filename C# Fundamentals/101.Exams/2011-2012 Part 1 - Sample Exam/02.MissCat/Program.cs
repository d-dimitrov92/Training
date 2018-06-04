using System;

namespace _02.MissCat
{
    class Program
    {
        static void Main()
        {
            int judge = int.Parse(Console.ReadLine());

            int[] cats = new int[11];

            for (int i = 0; i < judge; i++) 
            {
                int mark = int.Parse(Console.ReadLine());

                cats[mark]++;
            }

            int maxVotes = 0;
            int result = 0;

            for (int i = 0; i < cats.Length; i++)
            {
                int currentValue = cats[i];

                if(maxVotes < currentValue)
                {
                    maxVotes = currentValue;
                    result = i;
                }
            }
            Console.WriteLine(result);
        } 
    }
}