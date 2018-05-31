using System;

namespace _01._2_4_8
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine()), 
                b = int.Parse(Console.ReadLine()), 
                c = int.Parse(Console.ReadLine());
            int r = 0;

            switch (b)
            {
                case 2:
                    r = a % c; break;
                case 4:
                    r = a + c; break;
                case 8:
                    r = a * c; break;
            }

            int res = r % 4;

            if (res == 0)
            {
                Console.WriteLine(r / 4);
            }
            else Console.WriteLine(res);

            Console.WriteLine(r);
            }
    }
}
