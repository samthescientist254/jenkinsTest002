using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class BinsBackups
    {
        public string Bin { get; set; }
        public int InstId { get; set; }
        public string Cur { get; set; }
        public decimal? Rate { get; set; }
        public decimal? CwdRate { get; set; }
        public decimal? BalRate { get; set; }
        public decimal? RejRate { get; set; }
        public decimal? ExchRate { get; set; }
        public int? Cutofftime { get; set; }
        public string Holidays { get; set; }
        public string ProcGrp { get; set; }
        public DateTime? JoinDate { get; set; }
        public decimal? PpRate { get; set; }
        public bool? PpEnabled { get; set; }
        public string BillingGrp { get; set; }
        public decimal? BpRate { get; set; }
        public bool? BpEnabled { get; set; }
        public bool? Active { get; set; }
        public DateTime? LeaveDateTime { get; set; }
        public string Description { get; set; }
        public int? IstInstid { get; set; }
        public string PostilionSinkName { get; set; }
        public DateTime? MigratedToPostilionOn { get; set; }
        public short? Binlength { get; set; }
    }
}
