using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PptBins
    {
        public string Bin { get; set; }
        public int? Acquiring { get; set; }
        public int? Issuing { get; set; }
        public int InstId { get; set; }
        public string Description { get; set; }
        public int? Onus { get; set; }
        public int? Visa { get; set; }
        public string Abbrev { get; set; }
        public bool? Wagepoint { get; set; }
        public bool? Credit { get; set; }
        public bool? Pesaconnect { get; set; }
        public string PesaconnPastelAcct { get; set; }
        public DateTime? PesaconnJoinDt { get; set; }
        public double? PesaconnFee { get; set; }
        public bool? Mpesa { get; set; }
        public string PostilionSrcnode { get; set; }
        public bool? Interconnect { get; set; }
        public DateTime? InterconnectJoinDt { get; set; }
        public bool? Wallet { get; set; }
       
    }
}
