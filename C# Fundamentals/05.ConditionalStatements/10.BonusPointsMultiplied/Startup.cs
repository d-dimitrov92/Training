using System;

namespace _10.BonusPointsMultiplied
{
    class Startup
    {
        static void Main()
        {
            Console.Write("Enter your result(min:1, max:9): ");
            float points = float.Parse(Console.ReadLine());

            if (points >= 1 && points <= 3)
            {
                Console.WriteLine("Your points: " + (points * 10));
            }
            else if (points >= 4 && points <= 6)
            {
                Console.WriteLine("Your points: " + (points * 100));
            }
            else if (points >= 7 && points <= 9)
            {
                Console.WriteLine("Your points: " + (points * 1000));
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}


//Напишете програма, която прилага бонус точки към дадени точки в
//интервала[1..9] чрез прилагане на следните правила:
//- Ако точките са между 1 и 3, програмата ги умножава по 10.
//- Ако точките са между 4 и 6, ги умножава по 100.
//- Ако точките са между 7 и 9, ги умножава по 1000.
//- Ако точките са 0 или повече от 9, се отпечатва съобщение за
//грешка.