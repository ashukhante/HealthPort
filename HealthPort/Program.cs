using System;

namespace HealthPort
{
    class Program
    {
        static void Main(string[] args)
        {
           var myMemberServices = new MemberServices();
            myMemberServices.SubscriberName = "John";
            //myMemberServices.SubscriberId = 123456;
            myMemberServices.PrimaryAccountholdersName = "Jane";
            myMemberServices.EmailAddress = "janejohn@yahoo.com";
            //myMemberServices.MemberSince = new DateTime(2001, 1, 1);
            //myMemberServices.Statements = new DateTime(2001, 1, 1);
            //myMemberServices.BalanceAvailableInDeductible = 1234;
            myMemberServices.AddFundstobalace(1000);
            Console.WriteLine($"SubscriberName: {myMemberServices.SubscriberName},SubscriberId: {myMemberServices.SubscriberId}, PrimaryAccountholdersName: {myMemberServices.PrimaryAccountholdersName}, EmailAddress: {myMemberServices.EmailAddress},MemberSince.{myMemberServices.MemberSince}, Statements.{myMemberServices.Statements},BalanceAvailableInDeductible.{myMemberServices.BalanceAvailableInDeductible}");

           var myMemberservices2 = new MemberServices();
            Console.WriteLine($"SubscriberName: {myMemberservices2.SubscriberName},SubscriberId: {myMemberservices2.SubscriberId}, PrimaryAccountholdersName: {myMemberservices2.PrimaryAccountholdersName}, EmailAddress: {myMemberservices2.EmailAddress},MemberSince.{myMemberservices2.MemberSince}, Statements.{myMemberservices2.Statements},BalanceAvailableInDeductible.{myMemberservices2.BalanceAvailableInDeductible}");
        }
    }
}
