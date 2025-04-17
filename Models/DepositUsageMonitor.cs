using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class DepositUsageMonitor
    {
        public int InstId { get; set; }
        public string Institution { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Deposit { get; set; }
        public decimal? CashTaken { get; set; }
        public double? PercTaken { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdateStatus { get; set; }
        public double? PercDay { get; set; }
        public int? RaiseAlert { get; set; }
        public DateTime? NextCutoff { get; set; }
        public bool? Active { get; set; }
    }
}
