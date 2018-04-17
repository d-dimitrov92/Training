using System;

namespace _03.FirmData
{
    class Startup
    {
        static void Main()
        {
            Console.Write("Enter the name of firm: ");
            string firmName = Console.ReadLine();

            Console.Write("Enter the address of firm: ");
            string firmAddress = Console.ReadLine();

            Console.Write("Enter the phone number of firm: ");
            string firmNumber = Console.ReadLine();

            Console.Write("Enter the fax of firm: ");
            string firmFax = Console.ReadLine();

            Console.Write("Enter the web site of firm: ");
            string firmSite = Console.ReadLine();

            Console.Write("Enter the first name of firm's manager: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Enter the last name of firm's manager: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Enter the phone number of manager: ");
            string managerNumber = Console.ReadLine();


            Console.Write("\nFirm Name: {0} \nAddress: {1} \nPhone number: {2} \nFax: {3} \nWeb site: {4} \n", firmName, firmAddress, firmNumber, firmFax, firmSite);
            Console.Write("\nManager: {0} {1} \nPhone number: {2} \n \n", managerFirstName, managerLastName, managerNumber);

        }
    }
}