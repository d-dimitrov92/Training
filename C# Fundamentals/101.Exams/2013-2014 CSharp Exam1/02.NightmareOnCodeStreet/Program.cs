using System;

namespace _02.NightmareOnCodeStreet
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int oddPos = str.Length / 2;
            int res = 0;
            int count = 0;
            
            for (int i=1; i<str.Length; i = i + 2)
            {
                if (char.IsDigit(str[i]))
                {
                    res += str[i] - '0';
                    count++;
                }
            }

            Console.WriteLine("{0} {1}", count, res);
        }
    }
}