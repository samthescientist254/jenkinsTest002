using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SettlementProcLog
    {
        public int Id { get; set; }
        public DateTime StmtDate { get; set; }
        public string ProcGrp { get; set; }
        public int? Cutofftime { get; set; }
        public int? Due { get; set; }
        public string Comment { get; set; }
        public DateTime? Qdate { get; set; }
        public DateTime? Rundate { get; set; }
    }
}
