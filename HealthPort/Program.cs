using System;

namespace HealthPort
{
    class Program
    {
        static void Main(string[] args)
        {
           var myMemberServices = new MemberServices();
            myMemberServices.subscribername = "John";
            myMemberServices.subscriberid = 123456;
            myMemberServices.primaryaccountholdersname = "Jane";
            myMemberServices.emailaddress = "janejohn@yahoo.com";
            myMemberServices.MemberSince = new DateTime(2001, 1, 1);
            myMemberServices.statements = new DateTime(2001, 1, 1);
            myMemberServices.BalanceAvailableIndeductible = 1234;

            var myMemberservices2 = new MemberServices();
            myMemberServices.subscribername = "Johny";
            myMemberServices.subscriberid = 123455;
            myMemberServices.primaryaccountholdersname = "Janel";
            myMemberServices.emailaddress = "janeljohny@yahoo.com";
            myMemberServices.MemberSince = new DateTime(2001, 1, 1);
            myMemberServices.statements = new DateTime(2001, 1, 1);
            myMemberServices.BalanceAvailableIndeductible = 12345;
        }
    }
}
