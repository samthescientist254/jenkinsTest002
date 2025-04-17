using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionDataApiSettlement.Models
{
    public class Company
    {
        [JsonProperty("companyId")]
        public string CompanyID { get; set; }
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
        [JsonProperty("isoCountryCode")]
        public string IsoCountryCode { get; set; }
        [JsonProperty("fiscalYearDate")]
        public string FiscalYearDate { get; set; }
        [JsonProperty("cardType")]
        public string CardType { get; set; }
        [JsonProperty("issuerName")]
        public string IssuerName { get; set; }
        [JsonProperty("organizationHierarchyManagementIndicator")]
        public string OrganizationHierarchyManagementIndicator { get; set; }
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }
}
