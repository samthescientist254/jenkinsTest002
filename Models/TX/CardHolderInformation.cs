using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models.TX
{
    public class CardHolderInformation
    {
        [JsonProperty("companyIdentification")]
        public string CompanyIdentification { get; set; }
        [JsonProperty("cardholderIdentification")]
        public string CardholderIdentification { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("isoCountryCode")]
        public string IsoCountryCode { get; set; }
    }
}
