using System;

namespace HealthPort
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMemberServices = Insurance.CreateMemberServices("x",
                "y", "x@y.z");
            Console.WriteLine($"SubscriberName: {myMemberServices.SubscriberName},SubscriberId: {myMemberServices.SubscriberId}, PrimaryAccountholdersName: {myMemberServices.PrimaryAccountholdersName}, EmailAddress: {myMemberServices.EmailAddress},MemberSince.{myMemberServices.MemberSince}, Statements.{myMemberServices.Statements},BalanceAvailableInDeductible.{myMemberServices.BalanceAvailableInDeductible}");

           var myMemberservices2 = Insurance.CreateMemberServices("a",
                "b", "a@b.c");
            Console.WriteLine($"SubscriberName: {myMemberservices2.SubscriberName},SubscriberId: {myMemberservices2.SubscriberId}, PrimaryAccountholdersName: {myMemberservices2.PrimaryAccountholdersName}, EmailAddress: {myMemberservices2.EmailAddress},MemberSince.{myMemberservices2.MemberSince}, Statements.{myMemberservices2.Statements},BalanceAvailableInDeductible.{myMemberservices2.BalanceAvailableInDeductible}");
        }
    }
}
