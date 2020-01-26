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
        private static int lastSubscriberId = 0;
        #region properties
        /// <summary>
        /// Unique Insurnace Information for the subscriber
        /// </summary>
        public int SubscriberId { get; set; }
        public string SubscriberName { get; set; }
        public string PrimaryAccountholdersName { get; set; }
        public DateTime MemberSince { get; private set; }
        public string EmailAddress { get; set; }
        public float BalanceAvailableInDeductible { get; private set; }
        public DateTime Statements { get; private set; }
        #endregion

        #region  Constructor
        public MemberServices()
        {
            //lastSubscriberId += 1;
            SubscriberId = ++lastSubscriberId;
            MemberSince = DateTime.UtcNow;
        }

        #endregion


        #region  Methods
        /// <summary>
        /// Add funds to the balance
        /// </summary>
        /// <param name="amount">Amount to add towards existing funds</param>
        public void AddFundstobalace(float amount)
        {
            BalanceAvailableInDeductible += amount;
        }

        public float WithdrawToPayTheBill(float amount)
        {
            BalanceAvailableInDeductible -= amount;
            return BalanceAvailableInDeductible;
        }
        #endregion
    }
}
