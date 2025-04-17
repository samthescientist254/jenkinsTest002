using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class SettlStatementData
    {
        public long Uqid { get; set; }
        public int? InstId { get; set; }
        public DateTime? StmtDate { get; set; }
        public DateTime? GenTime { get; set; }
        public string Bin { get; set; }
        public int? TrxnCount { get; set; }
        public decimal? TrxnRate { get; set; }
        public decimal? Debits { get; set; }
        public decimal? Credits { get; set; }
        public string TrxnCode { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public short? RepGrp { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Description { get; set; }
        public decimal? Balance { get; set; }
        public int? Id { get; set; }
        public string Acctno { get; set; }
        public string BinDescr { get; set; }
    }
}
