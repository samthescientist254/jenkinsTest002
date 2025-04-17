using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Reversals
    {
        public DateTime StmtDate { get; set; }
        public string Bin { get; set; }
        public int TrxnCount { get; set; }
        public decimal Amount { get; set; }
        public string ProcGrp { get; set; }
    }
}
