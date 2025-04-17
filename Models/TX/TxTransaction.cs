using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
    public class TxTransaction
	{ 
		public string LOADTRANSACTIONCODE { get; set; }

		public string CONTRACTID { get; set; }

		public string POSTINGDAY { get; set; }

		public string RETRIEVALREFNUMBER { get; set; }

		public string SEQUENCENUMBER { get; set; }

		public string ACQUIRINGBIN { get; set; }

		public string CARDACCEPTORID { get; set; }

		public string SUPPLIERNAME { get; set; }

		public string SUPPLIERCITY { get; set; }
	
		public string SUPPLIERSTATEPROVINCECODE { get; set; }
	
		public string SUPPLIERISOCOUNTRYCODE { get; set; }

		public string SUPPLIERPOSTALCODE { get; set; }

		public string SOURCEAMOUNT { get; set; }

		public string BILLINGAMOUNT { get; set; }
	
		public string SOURCECURRENCYCODE { get; set; }

		public string MERCHANTCATEGORYCODE { get; set; }

		public string TRANSACTIONTYPECODE { get; set; }

		public string TRANSACTIONDATE { get; set; }

		public string BILLINGCURRENCYCODE { get; set; }

		public string TAXAMOUNT { get; set; }

		public string DISPUTEAMOUNT { get; set; }

		public string DISPUTEREASONCODE { get; set; }

		public string DISPUTEDATE { get; set; }

		public string EXRATEDPLENGTH { get; set; }

		public string TOKENID { get; set; }

		public string RID { get; set; }

		public string STAN { get; set; }
		public string MERCHANTNAME { get; set; }

		public string AUTHORIZATIONID { get; set; }
		
		public string TERMINALTYPE { get; set; }
	}
}
