using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ThresholdAlerts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? LowerThreshold { get; set; }
        public decimal? UpperThreshold { get; set; }
        public decimal? CurrentValue { get; set; }
        public DateTime? SmsupperSentAt { get; set; }
        public DateTime? SmslowerSentAt { get; set; }
        public string Smsto { get; set; }
        public string EmailTo { get; set; }
        public DateTime? EmailUpperSentAt { get; set; }
        public DateTime? EmailLowerSentAt { get; set; }
        public DateTime LastUpdateAt { get; set; }
    }
}
