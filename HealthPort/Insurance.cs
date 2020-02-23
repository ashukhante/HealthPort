
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthPort
{
    class Insurance
    {
        private static List<MemberServices> MemberServices = new List<MemberServices>();

        public static MemberServices CreateMemberServices(string subscriberName,
            string primaryAccountholdersName, string emailAddress)
        {

            //Object initialization
            var memberservices = new MemberServices
            {
                SubscriberName = subscriberName,
                PrimaryAccountholdersName = primaryAccountholdersName,
                EmailAddress = emailAddress
            };

            Insurance.MemberServices.Add(memberservices);

            return memberservices;
        }

        internal static void ListMemebers()
        {
            foreach(var member in MemberServices)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Balance: {2}", member.SubscriberId, member.SubscriberName, member.BalanceAvailableInDeductible);
            }
        }

        internal static object CreateMemberServices(object subscriberName, object primaryAccountholdersName, string emailAddress)
        {
            throw new NotImplementedException();
        }

        public static void Addfundstobalance(int subscriberID, float amount)

        {
            var memberServices = Insurance.MemberServices.Where(m => m.SubscriberId == subscriberID);
            var member = memberServices.FirstOrDefault();
            member.BalanceAvailableInDeductible += amount;
        }

        public static void WithdrawToPayTheBill(int subscriberID, float amount)

        {
            var memberServices = Insurance.MemberServices.Where(m => m.SubscriberId == subscriberID);
            var member = memberServices.FirstOrDefault();
            member.BalanceAvailableInDeductible  -= amount;
        }
    }
}
    
