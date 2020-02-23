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
                Console.WriteLine("2. List members");
                Console.WriteLine("3. AddFundstobalance");
                Console.WriteLine("4. WithdrawToPayTheBil");
                Console.WriteLine("5. View all statements");

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
                        Insurance.ListMemebers();
                        break;
                    case "3":
                        {
                            Console.Write("Subscriber ID: ");
                            var subscriberId = Console.ReadLine();
                            Console.Write("Balance: ");
                            var balance = Console.ReadLine();
                            Insurance.Addfundstobalance(Convert.ToInt32(subscriberId), (float)Convert.ToDecimal(balance));
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Subscriber ID: ");
                            var subscriberId = Console.ReadLine();
                            Console.Write("Balance: ");
                            var balance = Console.ReadLine();
                            Insurance.WithdrawToPayTheBill(Convert.ToInt32(subscriberId), (float)Convert.ToDecimal(balance));
                            break;
                        }
                    case "5":
                    default:
                        Console.WriteLine("Invalid option! Try again!");
                        break;
                }

            }
        }

    }
}
