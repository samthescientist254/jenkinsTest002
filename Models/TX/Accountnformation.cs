using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
	public class Accountnformation
	{
		[JsonProperty("cardholderId")]
		public string cardholderId { get; set; }
		[JsonProperty("accountNumber")]
		public string AccountNumber { get; set; }
		[JsonProperty("accountOpenDate")]
		public string accountOpenDate { get; set; }
		[JsonProperty("cardType")]
		public string cardType { get; set; }
		[JsonProperty("statementType")]
		public string statementType { get; set; }
		[JsonProperty("statusCode")]
		public string statusCode { get; set; }
		[JsonProperty("annualFeeFlag")]
		public string annualFeeFlag { get; set; }
		[JsonProperty("annualFeeMonth")]
		public string annualFeeMonth { get; set; }
	}
}
