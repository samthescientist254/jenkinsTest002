using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class WgpStmts
    {
        public long Id { get; set; }
        public DateTime StmtDate { get; set; }
        public int InstId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? OpeningBal { get; set; }
    }
}
