using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.WriteNameOfNumberFrom0To999
{
    class Startup
    {
        static void Main()
        {
            Console.Write("Въведете число от 0 до 999: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int hundreds = num / 100;
            int tens;
            int ones = num % 10;

            if (num >= 0 && num <= 999)
            {
                if (num > 99)
                {
                    tens = num % 100;
                }

                else tens = num;

                if (hundreds >= 1 && hundreds <= 9)
                {
                    switch (hundreds)
                    {
                        case 1: Console.Write("Сто "); break;
                        case 2: Console.Write("Двеста "); break;
                        case 3: Console.Write("Триста "); break;
                        case 4: Console.Write("Четиристотин "); break;
                        case 5: Console.Write("Петстотин "); break;
                        case 6: Console.Write("Шестстотин "); break;
                        case 7: Console.Write("Седемстотин "); break;
                        case 8: Console.Write("Осемстотин "); break;
                        case 9: Console.Write("Деветстотин "); break;
                    }
                }

                if (tens >= 20 && tens < 30) Console.Write("двадесет");
                else if (tens >= 30 && tens < 40) Console.Write("тридесет");
                else if (tens >= 40 && tens < 50) Console.Write("четиридесет");
                else if (tens >= 50 && tens < 60) Console.Write("петдесет");
                else if (tens >= 60 && tens < 70) Console.Write("шестдесет");
                else if (tens >= 70 && tens < 80) Console.Write("седемдесет");
                else if (tens >= 80 && tens < 90) Console.Write("осемдесет");
                else if (tens >= 90 && tens < 100) Console.Write("деветдесет");

                switch (tens)
                {
                    case 1: Console.Write("Едно "); break;
                    case 2: Console.Write("Две "); break;
                    case 3: Console.Write("Три "); break;
                    case 4: Console.Write("Четири "); break;
                    case 5: Console.Write("Пет "); break;
                    case 6: Console.Write("Шест "); break;
                    case 7: Console.Write("Седем "); break;
                    case 8: Console.Write("Осем "); break;
                    case 9: Console.Write("Девет "); break;
                    case 10: Console.Write("десет "); break;
                    case 11: Console.Write("единадесет "); break;
                    case 12: Console.Write("дванадесет "); break;
                    case 13: Console.Write("тринадесет "); break;
                    case 14: Console.Write("четиринадесет "); break;
                    case 15: Console.Write("петнадесет "); break;
                    case 16: Console.Write("шестнадесет "); break;
                    case 17: Console.Write("седемнадесет "); break;
                    case 18: Console.Write("осемнадесет "); break;
                    case 19: Console.Write("деветнадесет "); break;
                }

                if (tens > 20)
                {
                    switch (ones)
                    {
                        case 1: Console.WriteLine(" и едно. \n\n"); break;
                        case 2: Console.WriteLine(" и две. \n\n"); break;
                        case 3: Console.WriteLine(" и три. \n\n"); break;
                        case 4: Console.WriteLine(" и четири. \n\n"); break;
                        case 5: Console.WriteLine(" и пет. \n\n"); break;
                        case 6: Console.WriteLine(" и шест. \n\n"); break;
                        case 7: Console.WriteLine(" и седем. \n\n"); break;
                        case 8: Console.WriteLine(" и осем. \n\n"); break;
                        case 9: Console.WriteLine(" и девет. \n\n"); break;
                    }
                }

                if (num == 0)
                {
                    Console.WriteLine("Нула.\n\n");
                }
            }

            else
            {
                Console.WriteLine("Грешка! Погледнете условието!\n\n");
            }
        }
    }
}
