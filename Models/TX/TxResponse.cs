using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
    public class TxResponse
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        [JsonProperty("cardHolderInformartion", NullValueHandling = NullValueHandling.Ignore)]
        public List<CardHolderInformation> cardHolderInformartion { get; set; }
        [JsonProperty("cardHolderInformation", NullValueHandling = NullValueHandling.Ignore)]
        public List<CardHolderInformation> cardHolderInformation { get; set; }
        [JsonProperty("accInfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<Accountnformation> accInfo { get; set; }
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public List<Company> company { get; set; }
        [JsonProperty("txTransaction", NullValueHandling = NullValueHandling.Ignore)]
        public List<TxTransaction> txTransaction { get; set; }
        [JsonProperty("singleCompany", NullValueHandling = NullValueHandling.Ignore)]
        public Company singleCompany { get; set; }
        [JsonProperty("companyBillingReportingPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public companyBillingReportingPeriod companyBillingReportingPeriod { get; set; }
        [JsonProperty("txTransaction34", NullValueHandling = NullValueHandling.Ignore)]
        public List<TxTranRes> txTrans { get; set; }
        [JsonProperty("accountBalance", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountBalance> accountBalance { get; set; }
    }
}
