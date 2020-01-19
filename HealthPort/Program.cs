using System;

namespace HealthPort
{
    class Program
    {
        static void Main(string[] args)
        {
           var myMemberServices = new MemberServices();
            myMemberServices.SubscriberName = "John";
            myMemberServices.SubscriberId = 123456;
            myMemberServices.PrimaryAccountholdersName = "Jane";
            myMemberServices.EmailAddress = "janejohn@yahoo.com";
            myMemberServices.MemberSince = new DateTime(2001, 1, 1);
            myMemberServices.Statements = new DateTime(2001, 1, 1);
            myMemberServices.BalanceAvailableIndeductible = 1234;

            var myMemberservices2 = new MemberServices();
            myMemberServices.SubscriberName = "Johny";
            myMemberServices.SubscriberId = 123455;
            myMemberServices.PrimaryAccountholdersName = "Janel";
            myMemberServices.EmailAddress = "janeljohny@yahoo.com";
            myMemberServices.MemberSince = new DateTime(2001, 1, 1);
            myMemberServices.Statements = new DateTime(2001, 1, 1);
            myMemberServices.BalanceAvailableIndeductible = 12345;
        }
    }
}
