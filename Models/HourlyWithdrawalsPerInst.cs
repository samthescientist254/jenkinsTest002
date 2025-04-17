using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class HourlyWithdrawalsPerInst
    {
        public int WdTermInstId { get; set; }
        public int WdYear { get; set; }
        public int WdMonth { get; set; }
        public int WdDate { get; set; }
        public int WdHour { get; set; }
        public decimal? WdAmount { get; set; }
        public int? WdCount { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? WdDateTime { get; set; }
    }
}
