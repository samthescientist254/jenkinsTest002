using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
    public class TxTranRes
    {
		[JsonProperty("loadTrasactionCode")]
		public string LOADTRANSACTIONCODE { get; set; }
		[JsonProperty("contractId")]
		public string CONTRACTID { get; set; }
		[JsonProperty("postingDate")]
		public string postingDate { get; set; }
		[JsonProperty("retrievalRefNumber")]
		public string RETRIEVALREFNUMBER { get; set; }
		[JsonProperty("transactionReference")]
		public string transactionReference { get; set; }
		[JsonProperty("acquiringBin")]
		public string ACQUIRINGBIN { get; set; }
		[JsonProperty("cardAcceptorId")]
		public string CARDACCEPTORID { get; set; }
		[JsonProperty("supplierName")]
		public string SUPPLIERNAME { get; set; }
		[JsonProperty("supplierCity")]
		public string SUPPLIERCITY { get; set; }
		[JsonProperty("supplierStateProvinceCode")]
		public string SUPPLIERSTATEPROVINCECODE { get; set; }
		[JsonProperty("supplierIsoCountryCode")]
		public string SUPPLIERISOCOUNTRYCODE { get; set; }
		[JsonProperty("supplierPostalCode")]
		public string SUPPLIERPOSTALCODE { get; set; }
		[JsonProperty("sourceAmount")]
		public string SOURCEAMOUNT { get; set; }
		[JsonProperty("billingAmount")]
		public string BILLINGAMOUNT { get; set; }
		[JsonProperty("sourceCurrencyCode")]
		public string SOURCECURRENCYCODE { get; set; }
		[JsonProperty("merchantCategoryCode")]
		public string MERCHANTCATEGORYCODE { get; set; }
		[JsonProperty("transactionTypeCode")]
		public string TRANSACTIONTYPECODE { get; set; }
		[JsonProperty("period")]
		public string period { get; set; }
		[JsonProperty("billingCurrecyCode")]
		public string BILLINGCURRENCYCODE { get; set; }
		[JsonProperty("TaxAmount")]
		public string TAXAMOUNT { get; set; }
		[JsonProperty("DisputeAmount")]
		public string DISPUTEAMOUNT { get; set; }
		[JsonProperty("DisputeReasonCode")]
		public string DISPUTEREASONCODE { get; set; }
		[JsonProperty("DisputeDate")]
		public string DISPUTEDATE { get; set; }
		[JsonProperty("ExratedPLength")]
		public string EXRATEDPLENGTH { get; set; }
		[JsonProperty("TokenId")]
		public string TOKENID { get; set; }
		[JsonProperty("accountNumber")]
		public string accountNumber { get; set; }
		[JsonProperty("sequenceNumber")]
		public string sequenceNumber { get; set; }
		[JsonProperty("STAN")]
		public string STAN { get; set; }
		[JsonProperty("AUTHORIZATIONID")]
		public string AUTHORIZATIONID { get; set; }
		[JsonProperty("TERMINALTYPE")]
		public string TERMINALTYPE { get; set; }
		[JsonProperty("MERCHANTNAME")]
		public string MERCHANTNAME { get; set; }

	}
}
