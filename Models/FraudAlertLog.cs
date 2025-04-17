using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class FraudAlertLog
    {
        public long Id { get; set; }
        public DateTime? CurrDate { get; set; }
        public string Acctnum { get; set; }
        public string AlertType { get; set; }
        public string SentTo { get; set; }
        public DateTime? LocalDateTime { get; set; }
        public string Termid { get; set; }
        public string Termloc { get; set; }
        public decimal? Trace { get; set; }
        public decimal? Respcode { get; set; }
        public decimal? Amount { get; set; }
        public string Pan { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateFrom { get; set; }
    }
}
