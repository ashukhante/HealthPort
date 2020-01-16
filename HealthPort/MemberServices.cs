using System;
using System.Collections.Generic;
using System.Text;

namespace HealthPort
{/// <summary>
/// This represents the subscriber's insurance information
/// This will give the subscriber quick access to their own insurance information
/// This will also give them updated information about the latest bills
/// </summary>
    class MemberServices
    {
        #region Member Services properties
        /// <summary>
        /// Unique Insurnace Information for the subscriber
        /// </summary>
        public int subscriberid { get; set; }
        public string subscribername { get; set; }
        public string primaryaccountholdersname { get; set; }
        public DateTime MemberSince { get; set; }
        public string emailaddress { get; set; }
        public float Balanceavailableindeductiblle { get; set; }
        public DateTime statements { get; set; }
        #endregion
    }
}
}
