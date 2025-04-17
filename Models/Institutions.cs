using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class Institutions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Acctno { get; set; }
        public string Status { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Shortname { get; set; }
        public string Stmtsemail { get; set; }
        public string Detailsemail { get; set; }
        public string Abbrev { get; set; }
        public int? Isgroup { get; set; }
        public DateTime? Joindate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public decimal? PercPpRevenue { get; set; }
    }
}
