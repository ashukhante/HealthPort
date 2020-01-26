
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthPort
{
    class Insurance
    {
        public MemberServices CreateMemberServices(string subscriberName,
            string primaryAccountholdersName, string emailAddress)
        {

            //Object initialization
            var memberservices = new MemberServices
            {
                SubscriberName = subscriberName,
                PrimaryAccountholdersName = primaryAccountholdersName,
                EmailAddress = emailAddress
            };

            //Save upsert and get modified MemberServices
            return memberservices;
        }
    }
}
