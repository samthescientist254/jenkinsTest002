using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class TrxnTypes
    {
        public string TrxnCode { get; set; }
        public string Description { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ExchRate { get; set; }
    }
}
