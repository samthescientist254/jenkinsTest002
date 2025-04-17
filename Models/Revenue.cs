using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Revenue
    {
        public DateTime StmtDate { get; set; }
        public string Termid { get; set; }
        public decimal? CwdOnus { get; set; }
        public decimal? CwdLocal { get; set; }
        public decimal? CwdIntnl { get; set; }
        public decimal? BalOnus { get; set; }
        public decimal? BalLocal { get; set; }
        public decimal? BalIntnl { get; set; }
        public decimal? RejOnus { get; set; }
        public decimal? RejLocal { get; set; }
        public decimal? RejIntnl { get; set; }
    }
}
