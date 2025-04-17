using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class CustStmts
    {
        public int InstId { get; set; }
        public DateTime StmtDate { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public DateTime? LastDepositDate { get; set; }
        public decimal? LastDepositAmt { get; set; }
        public decimal? TotalDepositAmt { get; set; }
        public int? TxnCount { get; set; }
        public decimal? CashTaken { get; set; }
        public decimal? BalBfw { get; set; }
        public decimal? DepositsSincePrevious { get; set; }
        public DateTime? PreviousStmtDate { get; set; }
        public decimal? PreviousCashTaken { get; set; }
        public decimal? BalCfw { get; set; }
    }
}
