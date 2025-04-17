using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Banks
    {
        public string Issuer { get; set; }
        public string Bank { get; set; }
        public string Location { get; set; }
        public string Shortname { get; set; }
        public string Product { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Countryshortname { get; set; }
    }
}
