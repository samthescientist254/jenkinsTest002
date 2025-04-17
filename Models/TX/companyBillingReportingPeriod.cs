using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
    public class companyBillingReportingPeriod
    {
        [JsonProperty("loadTransactionCode")]
        public string loadTransactionCode { get; set; }
        [JsonProperty("companyIdentification")]
        public string companyIdentification { get; set; }
        [JsonProperty("period")]
        public string period { get; set; }
        [JsonProperty("cardType")]
        public string cardType { get; set; }
        [JsonProperty("startDate")]
        public string startDate  { get; set; }
        [JsonProperty("endDate")]
        public string endDate { get; set; }
        [JsonProperty("periodCompleteIndicator ")]
        public string periodCompleteIndicator { get; set; }
    }
}
