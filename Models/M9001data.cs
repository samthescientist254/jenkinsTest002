using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class M9001data
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public DateTime? Impdate { get; set; }
        public string Worksheet { get; set; }
        public string Termid { get; set; }
        public string Date1 { get; set; }
        public string Time1 { get; set; }
        public string Acquirer { get; set; }
        public string Pan { get; set; }
        public decimal? Pcode { get; set; }
        public decimal? Trace { get; set; }
        public decimal? Amount { get; set; }
        public int? Respcode { get; set; }
        public decimal? LocalTime { get; set; }
        public DateTime? LocalDate { get; set; }
        public int? Cnt { get; set; }
        public decimal? RevAmt { get; set; }
    }
}
