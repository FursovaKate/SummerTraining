using System;
using NLog;

namespace StringRepresentations
{
    class Program
    {
        static void Main()
        {
            var customer = new Customer();
            customer.Name = "Jeffrey Richter";
            customer.ContactPhone = "+1 (425) 555-0100";
            customer.Revenue = 1000000;

            bool successParse;
            int info;

            do
            {
                Console.WriteLine(" \nPress 1 to get customer name, \n 2 to get contact form, \n 3 - to get revenue, " +
                                  "\n 4 - to get full info, \n 5 - to get name and revenue, \n 6 - to get name and phone,");

                successParse = int.TryParse(Console.ReadLine(), out  info);
                if (!successParse)
                {
                    var logger = LogManager.GetCurrentClassLogger();
                    logger.Error("Incorrect input");
                   
                    Console.WriteLine("Incorrect input");
                }
            } while (!successParse);

            var result = "";
            if (info == 1)
            {
                result = customer.Name;
            }
            if (info == 2)
            {
                result = customer.ContactPhone;
            }
            if (info == 3)
            {
                result = customer.GetRevenue();
            }
            if (info == 4)
            {
                result = customer.ReceiveFullInfo();
            }
            if (info == 5)
            {
                result = customer.ReceiveNameAndRevenue();
            }
            if (info == 6)
            {
                result = customer.ReceiveNameAndPhone();
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
