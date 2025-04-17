using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class DailyTxnSummary
    {
        public DateTime TheDate { get; set; }
        public int Termid { get; set; }
        public int? Cwd { get; set; }
        public int? Bal { get; set; }
        public int? Mbt { get; set; }
        public int? Chqdep { get; set; }
        public int? Cshdep { get; set; }
        public int? Mstmt { get; set; }
        public int? Fndtrf { get; set; }
        public int? Othertxns { get; set; }
        public int? Total { get; set; }
        public decimal? Amtcwd { get; set; }
        public decimal? Amtchqdep { get; set; }
        public decimal? Amtcshdep { get; set; }
        public decimal? Amtcwdpeak { get; set; }
        public int? Peakhr { get; set; }
    }
}
