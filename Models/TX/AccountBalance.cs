using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
    public class AccountBalance
    {
		public string companyIdentification { get; set; }
		public string cardholderIdentification { get; set; }
		public string accountNumber { get; set; }
		public string currentBalance { get; set; }
		public string billingCurrency { get; set; }
		public string externalRid { get; set; }
	}
}
