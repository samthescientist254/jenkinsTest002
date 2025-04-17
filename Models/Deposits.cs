using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Deposits
    {
        public int InstId { get; set; }
        public DateTime DepDate { get; set; }
        public decimal Amount { get; set; }
        public string Bin { get; set; }
        public decimal? UnsettledAmt { get; set; }
    }
}
