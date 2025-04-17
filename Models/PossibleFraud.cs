using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PossibleFraud
    {
        public long Id { get; set; }
        public string Pan { get; set; }
        public string Termid { get; set; }
        public string Location { get; set; }
        public decimal? LocalTime { get; set; }
        public DateTime? LocalDateTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Trace { get; set; }
        public decimal? Respcode { get; set; }
        public bool? AlertSentRunaway { get; set; }
        public bool? AlertSentMultiplecwd { get; set; }
        public string Acctnum { get; set; }

        public PossibleFraud IdNavigation { get; set; }
        public PossibleFraud InverseIdNavigation { get; set; }
    }
}
