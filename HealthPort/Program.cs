using System;

namespace HealthPort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("Welcome to my Insurance!");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create new memberservices");
                Console.WriteLine("2. AddFundstobalace");
                Console.WriteLine("3. WithdrawToPayTheBil");
                Console.WriteLine("4. View all statements");

                Console.Write("Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Healthport!");
                        return;
                    case "1":
                        Console.Write("Account name: ");
                        var primaryAccountholdersName = Console.ReadLine();

                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();

                        Console.Write("subscriberName: ");
                        var subscriberName = Console.ReadLine();

                        

                        var account = Insurance.CreateMemberServices(subscriberName, primaryAccountholdersName, emailAddress);
                        Console.WriteLine($"AN: {account.SubscriberId}, " +
                            $"SName: {account.SubscriberName}, " +
                            $"Balance: {account.BalanceAvailableInDeductible:C}, " +
                            $"MS: {account.MemberSince}, " +
                            $"EA: {account.EmailAddress} ");

                        break;
                    case "2":

                    case "3":
                    case "4":
                    case "5":
                    default:
                        Console.WriteLine("Invalid option! Try again!");
                        break;
                }

            }
        }

    }
}
