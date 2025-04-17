using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class MonthlyTransactionsPerAcquirer
    {
        public decimal MonthYear { get; set; }
        public string Acquirer { get; set; }
        public int? Cwds { get; set; }
        public int? Balenqs { get; set; }
    }
}
