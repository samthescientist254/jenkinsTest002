using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Statements
    {
        public int BatchId { get; set; }
        public string Bin { get; set; }
        public string TrxnCode { get; set; }
        public int TrxnCount { get; set; }
        public decimal? TrxnRate { get; set; }
        public decimal? Debits { get; set; }
        public decimal? Credits { get; set; }
        public string Repgrp { get; set; }
    }
}
