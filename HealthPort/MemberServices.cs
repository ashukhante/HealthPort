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
        #region properties
        /// <summary>
        /// Unique Insurnace Information for the subscriber
        /// </summary>
        public int SubscriberId { get; set; }
        public string SubscriberName { get; set; }
        public string PrimaryAccountholdersName { get; set; }
        public DateTime MemberSince { get; set; }
        public string EmailAddress { get; set; }
        public float BalanceAvailableIndeductible { get; set; }
        public DateTime Statements { get; set; }
        #endregion

        #region  Methods
        /// <summary>
        /// Add funds to the balance
        /// </summary>
        /// <param name="amount">Amount to add towards existing funds</param>
        public void AddFundsobalace(float amount)
        {
            BalanceAvailableIndeductible += amount;
        }

        public float WithdrawToPayTheBill(float amount)
        {
            BalanceAvailableIndeductible -= amount;
            return BalanceAvailableIndeductible;
        }
        #endregion
    }
}
