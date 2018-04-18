using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOfFiveIntegersWithErrorMessage
{
    class Startup
    {
        static void Main()
        {
            int a;
            string errorMessage = "Enter an integer";
            Console.Write("Enter five numbers. After every number hit Enter button: \n");
            bool firstBool = int.TryParse(Console.ReadLine(), out a);

            
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int fifth = int.Parse(Console.ReadLine());

        }
    }
}