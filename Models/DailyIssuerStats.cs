using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class DailyIssuerStats
    {
        public DateTime LocalDate { get; set; }
        public string Institution { get; set; }
        public string Issuerabbrev { get; set; }
        public string CalcDate { get; set; }
        public int? Cwdcount { get; set; }
        public decimal? Cwdamount { get; set; }
        public int? Balenqcount { get; set; }
        public int? Visarejcount { get; set; }
        public int? Failedtxns { get; set; }
        public int? Ministmtcount { get; set; }
        public int? Fundstrfcount { get; set; }
        public int? Fundstrfamount { get; set; }
        public int? Ppcount { get; set; }
        public int? Ppamount { get; set; }
    }
}
