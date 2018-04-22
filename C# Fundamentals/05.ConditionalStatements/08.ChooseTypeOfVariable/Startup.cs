using System;

namespace _08.ChooseTypeOfVariable
{
    class Startup
    {
        static void Main()
        {
            Console.WriteLine("Choose yor type of variable.");
            Console.Write("Enter 0 for INT, 1 for DOUBLE and 2 for STRING:  ");
            int typeOfVariable = int.Parse(Console.ReadLine());

            switch (typeOfVariable)
            {
                case 0:
                    Console.Write("Enter the value of your variable: ");
                    int valueOfInt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value of INT + 1 = " + (valueOfInt + 1)); break;

                case 1:
                    Console.Write("Enter the value of your variable: ");
                    double valueOfDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("Value of DOUBLE + 1 = " + (valueOfDouble + 1)); break;

                case 2:
                    Console.Write("Enter the value of your variable: ");
                    string valueOfString = Console.ReadLine();
                    Console.WriteLine("String + * = " + valueOfString + "*"); break;

                default: Console.WriteLine("Only 0, 1 or 2!!!"); break;
            }
        }
    }
}
