using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Batches
    {
        public int Id { get; set; }
        public string ProcGrp { get; set; }
        public DateTime StmtDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
