using System;
using System.Collections.Generic;

namespace TransactionDataApiSettlement.Models
{
    public partial class UptimeLog
    {
        public DateTime LogfileStart { get; set; }
        public string AtmId { get; set; }
        public string ObjectName { get; set; }
        public string AtmLocation { get; set; }
        public string DowntimeNarrative { get; set; }
        public DateTime? DowntimeStartDatetime { get; set; }
        public DateTime? DowntimeStopDatetime { get; set; }
        public short? CurrentState { get; set; }
    }
}
