using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PptRevenue
    {
        public string BillingGrp { get; set; }
        public string Issuer { get; set; }
        public string Termid { get; set; }
        public DateTime StmtDate { get; set; }
        public int? TxnCount { get; set; }
        public decimal? TxnFee { get; set; }
    }
}
