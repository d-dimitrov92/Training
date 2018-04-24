using System;

namespace _04.DeckOfCards
{
    class Startup
    {
        static void Main()
        {
            int color, card;

            for (color = 0; color < 4; color++)
            {
                for (card = 0; card < 13; card++)
                {
                    switch (card)
                    {
                        case 0: Console.Write("2 "); break;
                        case 1: Console.Write("3 "); break;
                        case 2: Console.Write("4 "); break;
                        case 3: Console.Write("5 "); break;
                        case 4: Console.Write("6 "); break;
                        case 5: Console.Write("7 "); break;
                        case 6: Console.Write("8 "); break;
                        case 7: Console.Write("9 "); break;
                        case 8: Console.Write("10 "); break;
                        case 9: Console.Write("Вале "); break;
                        case 10: Console.Write("Дама "); break;
                        case 11: Console.Write("Поп "); break;
                        case 12: Console.Write("Асо "); break;
                    }

                    switch (color)
                    {
                        case 0: Console.WriteLine("Спатия"); break;
                        case 1: Console.WriteLine("Каро"); break;
                        case 2: Console.WriteLine("Купа"); break;
                        case 3: Console.WriteLine("Пика"); break;
                    }
                }
            }
        }
    }
}
