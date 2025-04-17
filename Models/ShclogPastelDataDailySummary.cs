using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class ShclogPastelDataDailySummary
    {
        public long Id { get; set; }
        public DateTime? LocalDate { get; set; }
        public int? Msgtype { get; set; }
        public int? Pcode { get; set; }
        public int? Respcode { get; set; }
        public string Acquirer { get; set; }
        public string Issuer { get; set; }
        public DateTime? RevDate { get; set; }
        public string Termid { get; set; }
        public int? Txncount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RevAmt { get; set; }
    }
}
