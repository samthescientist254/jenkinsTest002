using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class PrimeTumPostings
    {
        public long Id { get; set; }
        public DateTime? Calcdate { get; set; }
        public DateTime? Txndate { get; set; }
        public string Ttype { get; set; }
        public string Branch { get; set; }
        public decimal? Amount { get; set; }
        public string Descr { get; set; }
        public string Termid { get; set; }
        public string Reference { get; set; }
    }
}
